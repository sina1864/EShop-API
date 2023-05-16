using Microsoft.AspNetCore.Http;

namespace Common.Application.FileUtil.Interfaces;

public interface IFileService
{
    Task SaveFile(IFormFile file, string directoryPath);
    Task<string> SaveFileAndGenerateName(IFormFile file, string directoryPath);
    void DeleteFile(string path, string fileName);
    void DeleteFile(string filePath);
    void DeleteDirectory(string directoryPath);
}