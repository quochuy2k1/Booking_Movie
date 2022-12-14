using Microsoft.AspNetCore.Hosting;
namespace Booking_Movie.Application.Common
{
    public class FileStorageService : IFileStorageService
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        private const string USER_CONTENT_FOLDER_NAME = "user-content"; // new directory (must first be created)
        private const string MOVIE_CONTENT_FOLDER_NAME = "movie-content"; // new directory (must first be created)
        private const string DIRECTOR_CONTENT_FOLDER_NAME = "director-content"; // new directory (must first be created)

        public FileStorageService(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public async Task DeleteFileAsync(string fileName, string folderName)
        {
            string _ContentFolder = Path.Combine(_webHostEnvironment.WebRootPath, folderName); // path to the root diractory / user-content (directory)
                                                                                               // path to the root directory
            var filePath = Path.Combine(_ContentFolder, fileName); // Get the absolute path with the file name.
            if (File.Exists(filePath)) // If a file already exists
            {
                await Task.Run(() => File.Delete(filePath)); // delete file (async)
            }
        }

        public string GetFilePath(string fileName, string folderName)
        {
            return Path.Combine(_webHostEnvironment.WebRootPath, folderName, fileName);
        }
        public string GetFileUrl(string fileName, string folderName)
        {

            return $"/{folderName}/{fileName}";
        }

        public async Task SaveFileAsync(Stream mediaBinaryStream, string fileName, string folderName)
        {
            string _ContentFolder = Path.Combine(_webHostEnvironment.WebRootPath, folderName); // path to the root diractory / user-content (directory)

            var filePath = Path.Combine(_ContentFolder, fileName); // get the file path
            using var output = new FileStream(filePath, FileMode.Create); // make a new file with no name (empty file)
            await mediaBinaryStream.CopyToAsync(output); // copy the stream from the file save to the output file
        }
    }
}
