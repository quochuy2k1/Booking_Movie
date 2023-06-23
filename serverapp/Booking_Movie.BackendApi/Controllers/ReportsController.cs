using Booking_Movie.Application.Common;
using Booking_Movie.Application.Report.Booking;
using Booking_Movie.Utilities.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Reporting.NETCore;
using System.Data;

namespace Booking_Movie.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ReportsController : ControllerBase
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IBookingReport _bookingReport;
        private readonly IFileStorageService _fileStorage;

        private readonly string CINEMA_TICKET_PDF = "cinema-ticket-pdf";

        public ReportsController(IWebHostEnvironment webHostEnvironment, IBookingReport bookingReport, IFileStorageService fileStorageService) { 
            _webHostEnvironment = webHostEnvironment;
            _bookingReport = bookingReport;
            _fileStorage = fileStorageService;
        }


        [HttpGet("cinema-ticket")]
        public async Task<IActionResult> CinemaTicket([FromQuery]string qrContent)
        {
            string renderFormat = "PDF";
            string extension = "pdf";
            string mimetype = "application/pdf";

            var path = $"{_webHostEnvironment.WebRootPath}\\Reports\\BookingByQRCode.rdlc";

            var host = $"{Request.Scheme}://{Request.Host}";

            var booking = await _bookingReport.GetBookingDetailByQrCode(qrContent, host);


            var paramaters = new ReportParameter[] {
                new ReportParameter("MovieName", TextHelper.RemoveVietnameseDiacritics(booking.MovieName)),
                new ReportParameter("CinemaName", TextHelper.RemoveVietnameseDiacritics(booking.CinemaName)),
                new ReportParameter("CinemaAddress", TextHelper.RemoveVietnameseDiacritics(booking.CinemaAddress)),
                new ReportParameter("AuditoriumName", TextHelper.RemoveVietnameseDiacritics(booking.AuditoriumName)),
                new ReportParameter("MovieImage", booking.MovieImage),
                new ReportParameter("ShowTime", booking.ShowTime.ToLocalTime().ToString("HH:mm tt")),
                new ReportParameter("BookingDate", booking.BookingDate.ToString("dd/MM/yyyy")),
                new ReportParameter("ShowDate", booking.ShowDate != null ? booking.ShowDate!.Value.ToLocalTime().ToString("dd/MM/yyyy") : ""),
                new ReportParameter("seats", String.Join(", ", booking.BookingSeats)), 
                new ReportParameter("barCode", booking.Barcode) };
            using var report = new LocalReport();
            report.EnableExternalImages = true;
            report.DataSources.Add(new ReportDataSource("BookingTicket", booking.BookingTicket));
            report.DataSources.Add(new ReportDataSource("BookingCombo", booking.BookingCombo));
            report.ReportPath = path ;
            report.SetParameters(paramaters);

            var pdf = report.Render(renderFormat);

            var fileName = $"{booking.OrderId}.{extension}";
            await _fileStorage.SaveFileAsync(new MemoryStream(pdf), fileName, CINEMA_TICKET_PDF);
            return Ok(_fileStorage.GetFileUrl(fileName, CINEMA_TICKET_PDF));
            //return File(pdf, mimetype, "report."+ extension);
        }

        
    }
}
