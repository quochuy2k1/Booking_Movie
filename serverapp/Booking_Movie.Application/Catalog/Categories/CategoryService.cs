using AutoMapper;
using Booking_Movie.Application.Common;
using Booking_Movie.Data.Entities;
using Booking_Movie.Data.Infrastructure;
using Booking_Movie.Data.Repositories;
using Booking_Movie.Utilities.Exceptions;
using Booking_Movie.ViewModel.Catalog.CategoryVM;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Application.Catalog.Categories
{
    public class CategoryService : ICateroryService
    {
        private readonly CategoryRepository categoryRepository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IFileStorageService _fileStorage;
        private readonly IMapper _mapper;
        private const string CATEGORY_CONTENT_FOLDER_NAME = "category-content"; // new directory (must first be created)

        public CategoryService(CategoryRepository categoryRepository, IUnitOfWork unitOfWork, IFileStorageService fileStorageService, IMapper mapper)
        {
            this.categoryRepository = categoryRepository;
            this.unitOfWork = unitOfWork;
            _fileStorage = fileStorageService;
            _mapper = mapper;
        }

        public async Task<int?> Create(CategoryCreateRequest Request)
        {
            var category = new Category()
            {
                Name = Request.Name,
                Description = Request.Description,
                DisplayOrder = Request.DisplayOrder,
                HomeFlag = Request.HomeFlag,
                ParentId = Request.ParentId
            };

            if (Request.Image != null)
            {
                category.Image = await SaveFile(Request.Image);
            }

            categoryRepository.Add(category);
            await unitOfWork.Commit();
            return category.Id;

        }

        public async Task<bool> Delete(int id)
        {
            var category = await categoryRepository.GetSingleById(id);
            if (category == null) throw new BookingMovieException("Can't find a category with id: " + id);

            await _fileStorage.DeleteFileAsync(category.Image!, CATEGORY_CONTENT_FOLDER_NAME);
            categoryRepository.Delete(category);
            return await unitOfWork.Commit();
        }

        public async Task<List<CategoryViewModel>?> GetAll()
        {
            var query = categoryRepository.GetAll();
            if (await query.AnyAsync())
            {
                var caterories = await query.ToListAsync();
                var mapping = _mapper.Map<List<CategoryViewModel>>(caterories);
                return mapping;
            }
            return null;
        }

        public async Task<bool> Update(int id, CategoryUpdateRequest Request)
        {
            var category = await categoryRepository.GetSingleById(Request.Id);

            if (category == null) throw new BookingMovieException("Can't find a category with id: " + Request.Id);

            else
            {
                category.Description = Request.Description;
                category.DisplayOrder = Request.DisplayOrder;
                category.ParentId = Request.ParentId;
                category.Name = Request.Name;
                category.HomeFlag = Request.HomeFlag;

                if (Request.Image != null)
                {
                    // xoá hình củ
                    await _fileStorage.DeleteFileAsync(category.Image!, CATEGORY_CONTENT_FOLDER_NAME);
                    // cập nhật lại hình mới
                    category.Image = await SaveFile(Request.Image);
                }

                categoryRepository.Update(category);

                return await unitOfWork.Commit();
            }


        }

        private async Task<string> SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName!.Trim('"'); // get original file name from Content Disposition Header
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}"; // create file name with Guid is the name of the file
            await _fileStorage.SaveFileAsync(file.OpenReadStream(), fileName, CATEGORY_CONTENT_FOLDER_NAME); // save file
            return fileName;
        }
    }
}
