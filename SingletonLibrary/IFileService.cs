using System.IO;

namespace SingletonLibrary
{
    public interface IFileService:IService
    {
        string OpenFile();
        void SaveFile(string fileName, MemoryStream memoryStream);
        void DeleteFile(string fileName);
        void MoveFile(string fileFrom, string fileDist);
    }
}