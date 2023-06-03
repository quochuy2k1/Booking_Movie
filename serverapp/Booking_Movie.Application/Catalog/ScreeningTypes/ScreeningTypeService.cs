using AutoMapper;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.Data.Models;
using Booking_Movie.Data.Repositories;
using Booking_Movie.ViewModel.Catalog.MovieTypeVM;
using Booking_Movie.ViewModel.Catalog.ScreeningTypeVM;
using Booking_Movie.ViewModel.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Application.Catalog.ScreeningTypes
{
    public class ScreeningTypeService : IScreeningTypeService
    {
        private readonly ScreeningTypeRepository _screeningTypeRepository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper _mapper;

        public ScreeningTypeService(ScreeningTypeRepository screeningTypeRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _screeningTypeRepository = screeningTypeRepository;
            this.unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<PagedResult<ScreeningTypeViewModel>> GetAllPaging(GetScreeningTypePagingRequest pagingRequest)
        {
            //1. query
            int total = 0;
            Expression<Func<ScreeningType, bool>>? expression = null;
            IQueryable<ScreeningType> query = null!;


            //2. filter
            //if (!String.IsNullOrEmpty(pagingRequest.Nationality) && pagingRequest.Nationality != "all")
            //{
            //    //query = query.Where();
            //    Expression<Func<ScreeningType, bool>> nationalityFilter = m => m.nationality.Id.ToUpper().Contains(pagingRequest.Nationality.ToUpper()); ;
            //    expression!.Add(nationalityFilter);
            //}

            //3.paging
            query = _screeningTypeRepository.GetMultiPaging(expression, out total, pagingRequest.PageIndex.Value, pagingRequest.PageSize);


            //4. Get data


            var data = await query.Select(an => new ScreeningTypeViewModel()
            {

                Id = an.Id,
                Name = an.Name,
                Description = an.Description,


            }).ToListAsync();
            //var dataMapper = _mapper.Map<List<MovieViewModel>>(data);


            //dataMapper.ForEach((movie) => {
            //    movie.ImageBackground = $"{host}/{MOVIE_CONTENT_FOLDER_NAME}/{movie.ImageBackground}";
            //    movie.ImagePreview = $"{host}/{MOVIE_CONTENT_FOLDER_NAME}/{movie.ImagePreview}";
            //    movie.VideoTrailer = $"{host}/{MOVIE_CONTENT_FOLDER_NAME}/video-trailer/{movie.VideoTrailer}";
            //});

            var pagedResult = new PagedResult<ScreeningTypeViewModel>()
            {
                Result = data,
                Total = total,
            };

            return pagedResult;
        }

        public Task<List<ScreeningTypeViewModel>?> GetAllScreeningType()
        {
            var screeningTypes = _screeningTypeRepository.GetAll()
                .Select(x => _mapper.Map<ScreeningTypeViewModel>(x)).ToListAsync();

            return screeningTypes;
        }
    }
}
