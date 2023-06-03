using AutoMapper;
using Booking_Movie.Application.Common;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.Data.Models;
using Booking_Movie.Data.Repositories;
using Booking_Movie.Utilities.Exceptions;
using Booking_Movie.ViewModel.Catalog.ActorVM;
using Booking_Movie.ViewModel.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Linq.Expressions;
using System.Net.Http.Headers;

namespace Booking_Movie.Application.Catalog.Actors
{
    public class ActorService : IActorService
    {
        private readonly ActorRepository actorRepository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IFileStorageService _fileStorage;
        private readonly IMapper _mapper;
        private const string ACTOR_CONTENT_FOLDER_NAME = "actor-content"; // new directory (must first be created)

        public ActorService(ActorRepository actorRepository, IUnitOfWork unitOfWork, IMapper mapper, IFileStorageService fileStorage)
        {
            this.actorRepository = actorRepository;
            this.unitOfWork = unitOfWork;
            _mapper = mapper;
            _fileStorage = fileStorage;
        }

        public async Task<Guid> Create(ActorCreateRequest Request)
        {
            var actor = new Actor()
            {
                Name = Request.Name,
                Height = Request.Height,
                ViewCount = 0,
                DateOfBirth = Request.DateOfBirth,
                Description = Request.Description,
                NationalityId = Request.NationalityId,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };

            if (Request.Image != null)
            {
                actor.Image = await SaveFile(Request.Image);
            }

            //_Context.Actors.Add(actor);
            //await _Context.SaveChangesAsync();
            var query = actorRepository.Add(actor);
            await unitOfWork.Commit();
            return actor.ID;
        }

        public async Task<Guid> Update(Guid id, ActorUpdateRequest Request)
        {
            var actor = await actorRepository.GetSingleByCondition(a => a.ID == id);
            if (actor == null)
                throw new BookingMovieException($"Cann't find a actor with id: {id}");

            if (Request.Name != null) actor.Name = Request.Name;
            if (Request.Height != null) actor.Height = Request.Height.Value;
            if (Request.DateOfBirth != null) actor.DateOfBirth = Request.DateOfBirth;
            if (Request.NationalityId != null) actor.NationalityId = Request.NationalityId;
            actor.UpdatedDate = DateTime.Now;

            if (Request.Image != null)
            {
                await _fileStorage.DeleteFileAsync(actor.Image!, ACTOR_CONTENT_FOLDER_NAME);
                actor.Image = await SaveFile(Request.Image);
            }
            actorRepository.Update(actor);
            await unitOfWork.Commit();
            return actor.ID;
        }

        public async Task<bool> UpdateViewCount(Guid id)
        {
            var actor = await actorRepository.UpdateViewCount(id);
            if (actor == null)
                throw new BookingMovieException($"Cann't find a actor with id: {id}");

            return await unitOfWork.Commit();
        }

        public async Task<int?> CreateActorImage(Guid id, ActorImageCreateRequest request)
        {
            var actorImage = new ActorImage()
            {
                ActorId = id,
                DateCreated = DateTime.Now,
                IsDefault = Equals(request.IsDefault, null) ? false : request.IsDefault.Value,
                SortOrder = request.SortOrder,

            };

            if (request.Image != null)
            {
                actorImage.ImagePath = await SaveFile(request.Image);
                actorImage.Caption = request.Image.FileName;
                actorImage.FileSize = new FileInfo(_fileStorage.GetFilePath(actorImage.ImagePath!, ACTOR_CONTENT_FOLDER_NAME)).Length;
            }

            await actorRepository.CreateActorImage(actorImage);
            if (await unitOfWork.Commit())
            {
                return actorImage.Id;
            }
            return null;

        }

        public async Task<int?> UpdateActorImage(int id, Guid actorId, ActorImageUpdateRequest request)
        {
            var actorImage = await actorRepository.GetActorImageDetail(id, actorId)!.FirstOrDefaultAsync();
            if (actorImage == null)
                throw new BookingMovieException($"Cann't find a actor image with id: {id}");

            
            if(request.SortOrder != null) actorImage.SortOrder = request.SortOrder;
            if(request.IsDefault != null) actorImage.IsDefault = request.IsDefault.Value;
            if (request.Image != null)
            {
                await _fileStorage.DeleteFileAsync(actorImage.ImagePath!, ACTOR_CONTENT_FOLDER_NAME);
                actorImage.ImagePath = await SaveFile(request.Image);
                actorImage.Caption = request.Image.FileName;
                actorImage.FileSize = new FileInfo(_fileStorage.GetFilePath(actorImage.ImagePath!, ACTOR_CONTENT_FOLDER_NAME)).Length;
            }
            actorRepository.UpdateActorImage(actorImage);
            await unitOfWork.Commit();
            return actorImage.Id;
        } 


            public async Task<List<Guid>?> Delete(Guid[] id)
        {
            if (id.Length == 1)
            {
                var actor = await actorRepository.GetSingleByCondition(a => a.ID == id[0]);
                if (actor == null)
                    throw new BookingMovieException($"Cann't find a actor with id: {id}");


                actorRepository.Delete(actor);
                if (await unitOfWork.Commit())
                {
                    await _fileStorage.DeleteFileAsync(actor.Image!, ACTOR_CONTENT_FOLDER_NAME);
                }
                return new List<Guid>()
                {
                    actor.ID,
                };
            }
            else if(id.Length > 1)
            {
                var actors = await actorRepository.DeleteMulti(id);
                if (actors == null)
                    throw new BookingMovieException($"can't delete much for some reason");
                
                if (await unitOfWork.Commit())
                {

                    foreach (var actor in actors)
                    {
                        await _fileStorage.DeleteFileAsync(actor.Image!, ACTOR_CONTENT_FOLDER_NAME);
                    }
                }
                return actors.Select(x => x.ID).ToList();
            }
            return null;
        }

        public async Task<List<ActorViewModel>> GetAll(string host)
        {
            var actors = await actorRepository.GetAll().Select(actor => new ActorViewModel()
            {
                ID = actor.ID,
                Name = actor.Name,
                ViewCount = actor.ViewCount,
                DateOfBirth = actor.DateOfBirth,
                Height = actor.Height,
                Image = $"{host}/{ACTOR_CONTENT_FOLDER_NAME}/{actor.Image}",
                NationalityId = actor.NationalityId,
            }).ToListAsync();

            return actors;
        }

        public async Task<ActorImageViewModel?> GetActorImageDetail(int id, Guid actorId, string host)
        {
            var actors = await actorRepository.GetActorImageDetail(id, actorId)!.Select(x => new ActorImageViewModel()
            {
                Id = x.Id,
                ActorId = x.ActorId,
                Caption = x.Caption,
                ImagePath = $"{host}/{ACTOR_CONTENT_FOLDER_NAME}/{x.ImagePath}",
                FileSize = x.FileSize,
                DateCreated = x.DateCreated,
                IsDefault = x.IsDefault,
                SortOrder = x.SortOrder
            }).FirstOrDefaultAsync();

            return actors;
        }
        public async Task<List<ActorImageViewModel>?> GetAllActorImage(Guid actorId, string host)
        {
            var actors = await actorRepository.GetAllActorImage(actorId)!.Select(x => new ActorImageViewModel()
            {
                Id = x.Id,
                ActorId = x.ActorId,
                Caption = x.Caption,
                ImagePath = $"{host}/{ACTOR_CONTENT_FOLDER_NAME}/{x.ImagePath}",
                FileSize = x.FileSize,
                DateCreated = x.DateCreated,
                IsDefault = x.IsDefault,
                SortOrder = x.SortOrder
            }).ToListAsync();

            return actors;
        }

        public async Task<PagedResult<ActorViewModel>> GetAllPaging(GetActorPagingRequest pagingRequest, string host)
        {
            //1. query
            int total = 0;
            IQueryable<Actor?> query = null!;
            Expression<Func<Actor, bool>> expression = null!;

            //2. filter
            if (!String.IsNullOrEmpty(pagingRequest.Nationality))
            {
                //query = query.Where();
                expression = q => q.Nationality.Name.ToUpper().Contains(pagingRequest.Nationality.ToUpper());
            }

            query = actorRepository.GetMultiPaging(expression, out total, pagingRequest.PageIndex.Value, pagingRequest.PageSize, new string[] {"Nationality"});


            //3.paging

            //var totalRow = await query!.CountAsync();

            //query = query!.Skip((pagingRequest.PageIndex - 1) * pagingRequest.PageSize)
            //    .Take(pagingRequest.PageSize);

            if (pagingRequest.SortBy == ViewModel.Enums.SortByActor.ViewCount)
            {
                query = query.OrderBy(q => q!.ViewCount);
            }

            //4. Get data

            var data = await query.ToListAsync();
            foreach (var actor in data)
            {
                actor!.Image = $"{host}/{ACTOR_CONTENT_FOLDER_NAME}/{actor.Image}";
                actor!.NationalityId = "Việt Nam";
            }
            var dataMapper = _mapper.Map<List<ActorViewModel>>(data);

            var pagedResult = new PagedResult<ActorViewModel>()
            {
                Result = dataMapper,
                Total = total,
            };

            return pagedResult;
        }

        public async Task<ActorViewModel> GetById(Guid id, string host)
        {
            var actor = await actorRepository.GetSingleByCondition(a => a.ID == id);
            var actorVm = _mapper.Map<ActorViewModel>(actor);
            actorVm.Image = actorVm.Image != null ? $"{host}/{ACTOR_CONTENT_FOLDER_NAME}/{actorVm.Image}" : null;
            return actorVm!;
        }

        

        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName!.Trim('"'); // get original file name from Content Disposition Header
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}"; // create file name with Guid is the name of the file
            await _fileStorage.SaveFileAsync(file.OpenReadStream(), fileName, ACTOR_CONTENT_FOLDER_NAME); // save file
            return fileName;
        }

        
    }
}