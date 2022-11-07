using AutoMapper;
using Booking_Movie.Application.Common;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.Data.Repositories;
using Booking_Movie.Utilities.Exceptions;
using Booking_Movie.ViewModel.Catalog.ProducerVM;
using Booking_Movie.ViewModel.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Application.Catalog.Producers
{
    public class ProducerService : IProducerService
    {
        private readonly ProducerRepository _producerRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFileStorageService _fileStorage;
        private readonly IMapper _mapper;
        private const string PRODUCER_CONTENT_FOLDER_NAME = "producer-content"; // new directory (must first be created)

        public ProducerService(ProducerRepository producerRepository, IUnitOfWork unitOfWork, IFileStorageService fileStorageService, IMapper mapper)
        {
            _producerRepository = producerRepository;
            _unitOfWork = unitOfWork;
            _fileStorage = fileStorageService;
            _mapper = mapper;
        }

        public async Task<Guid> Create(ProducerCreateRequest Request)
        {
            var producer = new Producer()
            {
                Name = Request.Name,
                NationalityId = Request.NationalityId,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
            };

            if (Request.Image != null)
            {
                producer.Image = await SaveFile(Request.Image);
            }

            //_Context.Actors.Add(actor);
            //await _Context.SaveChangesAsync();
            var query = _producerRepository.Add(producer);
            await _unitOfWork.Commit();
            return await Task.Run(() => producer.ID);
        }

        public async Task<bool> Delete(Guid id)
        {
            var producer = await _producerRepository.GetSingleByCondition(a => a.ID == id);
            if (producer == null)
                throw new BookingMovieException($"Cann't find a producer with id: {id}");

            await _fileStorage.DeleteFileAsync(producer.Image!, PRODUCER_CONTENT_FOLDER_NAME);
            _producerRepository.Delete(producer);
            return await _unitOfWork.Commit();
        }

        public async Task<List<ProducerViewModel>> GetAll()
        {
            var producers = await _producerRepository.GetAll().Include(x=>x.Nationality).Select(producer => new ProducerViewModel()
            {
                ID = producer.ID,
                Name = producer.Name,
                Image = producer.Image,
                NationalityId = producer.Nationality.Name,
            }).ToListAsync();

            return producers;
        }

        public async Task<PagedResult<ProducerViewModel>> GetAllPaging(GetMovieCategoryPagingRequest pagingRequest, string host)
        {
            //1. query
            int total = 0;
            IQueryable<Producer?> query = null!;
            Expression<Func<Producer, bool>> expression = null!;

            //2. filter
            if (!String.IsNullOrEmpty(pagingRequest.Nationality))
            {
                //query = query.Where();
                expression = q => q.Nationality.Name.ToUpper().Contains(pagingRequest.Nationality.ToUpper());
            }

            query = _producerRepository.GetMultiPaging(expression, out total, pagingRequest.PageIndex, pagingRequest.PageSize, new string[] { "Nationality" });

            //3.paging

            //var totalRow = await query!.CountAsync();

            //query = query!.Skip((pagingRequest.PageIndex - 1) * pagingRequest.PageSize)
            //    .Take(pagingRequest.PageSize);

            //if (pagingRequest.SortBy == ViewModel.Enums.SortByProducer.ViewCount)
            //{
            //    query = query.OrderBy(q => q!.ViewCount);
            //}

            //4. Get data

            var data = await query.ToListAsync();
            var dataMapper = _mapper.Map<List<ProducerViewModel>>(data);

            var pagedResult = new PagedResult<ProducerViewModel>()
            {
                Result = dataMapper,
                Total = total,
            };

            return pagedResult;
        }

        public async Task<ProducerViewModel> GetById(Guid id)
        {
            var producer = await _producerRepository.GetSingleByCondition(a => a.ID == id);
            var producerVm = _mapper.Map<ProducerViewModel>(producer);
            return producerVm!;
        }

        public async Task<bool> Update(Guid id, ProducerUpdateRequest Request)
        {
            var producer = await _producerRepository.GetSingleByCondition(a => a.ID == id);
            if (producer == null)
                throw new BookingMovieException($"Cann't find a producer with id: {id}");

            producer.Name = Request.Name;
            producer.NationalityId = Request.NationalityId;
            producer.UpdatedDate = DateTime.Now;

            if (Request.Image != null)
            {
                producer.Image = await SaveFile(Request.Image);
            }
            _producerRepository.Update(producer);
            return await _unitOfWork.Commit();
        }


        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName!.Trim('"'); // get original file name from Content Disposition Header
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}"; // create file name with Guid is the name of the file
            await _fileStorage.SaveFileAsync(file.OpenReadStream(), fileName, PRODUCER_CONTENT_FOLDER_NAME); // save file
            return fileName;

        }

       
    }
}
