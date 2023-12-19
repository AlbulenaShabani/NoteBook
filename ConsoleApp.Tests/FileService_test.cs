

using LibraryApp.Interfaces;
using LibraryApp.Services;

namespace ConsoleApp.Tests;

public class FileService_test
{
    [Fact]

    public void SaveToFile_Should_SaveContentToFile_ThenReturnTrue()
    {
        //Arrange
        IFileService fileService = new FileServices();
        string filepath = @"c:\Projects\test.json";
        string content = "Succefully Saved";
        //Act
        var result = fileService.SaveContentToFile(filepath, content);
        //Assert
        Assert.True(result);
    }
   
}
