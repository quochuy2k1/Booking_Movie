﻿using Booking_Movie.Data.Models;
using Booking_Movie.ViewModel.Catalog.AuditoriumVM;
using Booking_Movie.ViewModel.Catalog.SeatNoVM;
using Booking_Movie.ViewModel.Catalog.SeatVM;
using Booking_Movie.ViewModel.Common;
using DevExtreme.AspNet.Data.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Movie.Application.Catalog.Auditoriums
{
    public interface IAuditoriumService
    {
        Task<List<SeatInAuditoriumViewModel>?> GetSeatByAuditoriumId(int id);
        Task<List<string>> GetRowOfSeatsByAuditoriumId(int Id);
        Task<PagedResult<AuditoriumViewModel>> GetAllPaging(GetAuditoriumPagingRequest pagingRequest, string host);
        Task<LoadResult> GetAuditoriumPagingAdmin(GetAuditoriumPagingAdminRequest pagingRequest, string host);
        Task<bool> SeatNoSaveChange(int auditoriumId, SeatNoSaveChangeRequest request);


    }
}
