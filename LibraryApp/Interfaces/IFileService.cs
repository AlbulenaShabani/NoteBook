namespace LibraryApp.Interfaces;

public interface IFileService
{
    bool SaveContentToFile(string filePath, string content);

    string GetContentFromFile(string filePath);

}
