namespace Booking_Movie.Application.Common
{
    public interface IFileStorageService
    {
        string GetFileUrl(string fileName, string folderName);
        string GetFilePath(string fileName, string folderName);
        Task SaveFileAsync(Stream mediaBinaryStream, string fileName, string folderName);
        Task DeleteFileAsync(string fileName, string folderName);
    }
}
