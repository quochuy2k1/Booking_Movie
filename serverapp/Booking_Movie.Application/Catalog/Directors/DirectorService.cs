using AutoMapper;
using Booking_Movie.Application.Common;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.Data.Repositories;
using Booking_Movie.Utilities.Exceptions;
using Booking_Movie.ViewModel.Catalog.DirectorVM;
using Booking_Movie.ViewModel.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Net.Http.Headers;

namespace Booking_Movie.Application.Catalog.Directors
{
    public class DirectorService : IDirectorService
    {
        private readonly DirectorRepository _directorRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFileStorageService _fileStorage;
        private readonly IMapper _mapper;
        private const string DIRECTOR_CONTENT_FOLDER_NAME = "director-content"; // new directory (must first be created)

        public DirectorService(DirectorRepository directorRepository, IUnitOfWork unitOfWork, IFileStorageService fileStorageService, IMapper mapper)
        {
            _directorRepository = directorRepository;
            _unitOfWork = unitOfWork;
            _fileStorage = fileStorageService;
            _mapper = mapper;
        }

        public async Task<Guid> Create(DirectorCreateRequest Request)
        {
            var director = new Director()
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
                director.Image = await SaveFile(Request.Image);
            }

            //_Context.Actors.Add(actor);
            //await _Context.SaveChangesAsync();
            var query = _directorRepository.Add(director);
            await _unitOfWork.Commit();
            return await Task.Run(() => director.ID);
        }

        public async Task<bool> Delete(Guid id)
        {
            var director = await _directorRepository.GetSingleByCondition(a => a.ID == id);
            if (director == null)
                throw new BookingMovieException($"Cann't find a director with id: {id}");

            await _fileStorage.DeleteFileAsync(director.Image!, DIRECTOR_CONTENT_FOLDER_NAME);
            _directorRepository.Delete(director);
            return await _unitOfWork.Commit();
        }

        public async Task<List<DirectorViewModel>> GetAll()
        {
            var directors = await _directorRepository.GetAll().Include(x=>x.Nationality).Select(director => new DirectorViewModel()
            {
                ID = director.ID,
                Name = director.Name,
                ViewCount = director.ViewCount,
                DateOfBirth = director.DateOfBirth,
                Height = director.Height!.Value,
                Image = director.Image,
                NationalityId = director.Nationality.Id,
            }).ToListAsync();

            return directors;
        }

        public async Task<PagedResult<DirectorViewModel>> GetAllPaging(GetDirectorPagingRequest pagingRequest, string host)
        {
            //1. query
            int total = 0;
            IQueryable<Director?> query = null!;
            Expression<Func<Director, bool>> expression = null!;

            //2. filter
            if (!String.IsNullOrEmpty(pagingRequest.Nationality))
            {
                //query = query.Where();
                expression = q => q.Nationality.Name.ToUpper().Contains(pagingRequest.Nationality.ToUpper());
            }

            query = _directorRepository.GetMultiPaging(expression, out total, pagingRequest.PageIndex, pagingRequest.PageSize, new string[] {"Nationality"});

            //3.paging

            //var totalRow = await query!.CountAsync();

            //query = query!.Skip((pagingRequest.PageIndex - 1) * pagingRequest.PageSize)
            //    .Take(pagingRequest.PageSize);

            if (pagingRequest.SortBy == ViewModel.Enums.SortByDirector.ViewCount)
            {
                query = query.OrderBy(q => q!.ViewCount);
            }

            //4. Get data

            var data = await query.ToListAsync();
            var dataMapper = _mapper.Map<List<DirectorViewModel>>(data);

            var pagedResult = new PagedResult<DirectorViewModel>()
            {
                Result = dataMapper,
                Total = total,
            };

            return pagedResult;
        }

        public async Task<DirectorViewModel> GetById(Guid id)
        {
            var director = await _directorRepository.GetSingleByCondition(a => a.ID == id);
            var directorVm = _mapper.Map<DirectorViewModel>(director);
            return directorVm!;
        }

        public async Task<bool> Update(Guid id, DirectorUpdateRequest Request)
        {
            var director = await _directorRepository.GetSingleByCondition(a => a.ID == id);
            if (director == null)
                throw new BookingMovieException($"Cann't find a director with id: {id}");

            director.Name = Request.Name;
            director.Height = Request.Height;
            director.DateOfBirth = Request.DateOfBirth;
            director.NationalityId = Request.NationalityId;
            director.UpdatedDate = DateTime.Now;

            if (Request.Image != null)
            {
                director.Image = await SaveFile(Request.Image);
            }
            _directorRepository.Update(director);
            return await _unitOfWork.Commit();
        }

        public async Task<bool> UpdateViewCount(Guid id)
        {
            var director = await _directorRepository.UpdateViewCount(id);
            if (director == null)
                throw new BookingMovieException($"Cann't find a director with id: {id}");

            return await _unitOfWork.Commit();
        }

        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName!.Trim('"'); // get original file name from Content Disposition Header
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}"; // create file name with Guid is the name of the file
            await _fileStorage.SaveFileAsync(file.OpenReadStream(), fileName, DIRECTOR_CONTENT_FOLDER_NAME); // save file
            return fileName;
        }
    }
}