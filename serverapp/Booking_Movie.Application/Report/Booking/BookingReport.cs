using Booking_Movie.Data.Repositories;
using Booking_Movie.Utilities.Exceptions;
using Booking_Movie.ViewModel.Catalog.BookingVM;
using System.Drawing;
using System.Drawing.Imaging;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing.QrCode;
using Booking_Movie.Application.Common;
using Microsoft.AspNetCore.Hosting;
using Booking_Movie.Utilities.Common;
using Microsoft.Extensions.Configuration;

namespace Booking_Movie.Application.Report.Booking
{
    public class BookingReport : IBookingReport
    {
        private readonly BookingRepository _bookingRepository;
        private readonly IFileStorageService _fileStorage;

        private const string MOVIE_CONTENT_FOLDER_NAME = "movie-content"; // new moviey (must first be created)
        private const string BARCODE_FOLDER_NAME = "barcode"; // new moviey (must first be created)
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IConfiguration _configuration;

        private readonly string extension_barcode = ".png";


        public BookingReport(BookingRepository bookingRepository, IFileStorageService fileStorageService, IWebHostEnvironment webHostEnvironment, IConfiguration configuration) {
            _bookingRepository = bookingRepository;
            _fileStorage = fileStorageService;
            _webHostEnvironment = webHostEnvironment;
            _configuration = configuration;
        }
        public async Task<BookingHistoryViewModel?> GetBookingDetailByQrCode(string qrContent, string host)
        {
            var booking = await _bookingRepository.GetBookingDetailByQrCode(qrContent).FirstOrDefaultAsync();

            if (booking == null) throw new BookingMovieException("Không tìm thấy đơn đặt vé");

            booking.MovieImage = $"{host}/{MOVIE_CONTENT_FOLDER_NAME}/{booking.MovieImage}";


            BarcodeGen(booking.OrderId, booking.OrderId);
            booking.Barcode = $"{host}/{BARCODE_FOLDER_NAME}/{booking.OrderId + extension_barcode}";

            return booking;
        }

        private void BarcodeGen(string content, string fileName)
        {
            Byte[] byteArray;
            var width = 250; // width of the QR Code
            var height = 250; // height of the QR Code
            var margin = 0;
            var qrCodeWriter = new ZXing.BarcodeWriterPixelData
            {
                Format = ZXing.BarcodeFormat.QR_CODE,
                Options = new QrCodeEncodingOptions
                {
                    Height = height,
                    Width = width,
                    Margin = margin
                }
            };
            var contentEnc = EncryptorHelper.EncryptString(_configuration["QrSerect"], content, _configuration["QrVector"]);
            var pixelData = qrCodeWriter.Write(contentEnc);
            // creating a PNG bitmap from the raw pixel data; if only black and white colors are used it makes no difference if the raw pixel data is BGRA oriented and the bitmap is initialized with RGB
            using (var bitmap = new Bitmap(pixelData.Width, pixelData.Height, PixelFormat.Format32bppRgb))
            {
                using (var ms = new MemoryStream())
                {
                    var bitmapData = bitmap.LockBits(new Rectangle(0, 0, pixelData.Width, pixelData.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppRgb);
                    try
                    {
                        // we assume that the row stride of the bitmap is aligned to 4 byte multiplied by the width of the image
                       Marshal.Copy(pixelData.Pixels, 0, bitmapData.Scan0, pixelData.Pixels.Length);
                    }
                    finally
                    {
                        bitmap.UnlockBits(bitmapData);
                    }
                    
                    // save to stream as PNG
                    bitmap.Save(ms, ImageFormat.Png);
                    byteArray = ms.ToArray();
                    //

                    var path = Path.Combine(_webHostEnvironment.WebRootPath, BARCODE_FOLDER_NAME,  fileName + extension_barcode);
                    if(!_fileStorage.DoesFileExist(fileName, BARCODE_FOLDER_NAME))
                    {
                        bitmap.Save(path, ImageFormat.Png);

                    }
                }
            }

            //return byteArray;
        }
    }

   
}
