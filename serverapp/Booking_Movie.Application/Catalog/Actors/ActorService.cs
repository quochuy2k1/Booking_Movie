using AutoMapper;
using Booking_Movie.Application.Common;
using Booking_Movie.Data.EF;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.Data.Repositories;
using Booking_Movie.Utilities.Exceptions;
using Booking_Movie.ViewModel.Catalog.ActorVM;
using Booking_Movie.ViewModel.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
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

        public ActorService(ActorRepository actorRepository, IUnitOfWork unitOfWork,IMapper mapper, IFileStorageService fileStorage)
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
            return await Task.Run(() => actor.ID);
        }

        [HttpDelete]
        public async Task<bool> Delete(Guid id)
        {
            var actor = await actorRepository.GetSingleByCondition(a => a.ID == id);
            if (actor == null)
                throw new BookingMovieException($"Cann't find a actor with id: {id}");

            await _fileStorage.DeleteFileAsync(actor.Image!, ACTOR_CONTENT_FOLDER_NAME);
            actorRepository.Delete(actor);
            return await unitOfWork.Commit();
        }

        public async Task<List<ActorViewModel>> GetAll()
        {
            var actors = await actorRepository.GetAll().Select(actor => new ActorViewModel()
            {
                ID = actor.ID,
                Name = actor.Name,
                ViewCount = actor.ViewCount,
                DateOfBirth = actor.DateOfBirth,
                Height = actor.Height,
                Image = actor.Image,
                NationalityId = actor.NationalityId,
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

            query = actorRepository.GetMultiPaging(expression, out total, pagingRequest.PageIndex, pagingRequest.PageSize, new string[] {"Nationality"});


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

        public async Task<bool> Update(Guid id, ActorUpdateRequest Request)
        {
            var actor = await actorRepository.GetSingleByCondition(a=>a.ID == id);
            if (actor == null)
                throw new BookingMovieException($"Cann't find a actor with id: {id}");

            actor.Name = Request.Name;
            actor.Height = Request.Height;
            actor.DateOfBirth = Request.DateOfBirth;
            actor.NationalityId = Request.NationalityId;
            actor.UpdatedDate = DateTime.Now;

            if (Request.Image != null)
            {
                actor.Image = await SaveFile(Request.Image);
            }
            actorRepository.Update(actor);
            return await unitOfWork.Commit();
        }

        public async Task<bool> UpdateViewCount(Guid id)
        {
            var actor = await actorRepository.UpdateViewCount(id);
            if (actor == null)
                throw new BookingMovieException($"Cann't find a actor with id: {id}");

            return await unitOfWork.Commit();
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