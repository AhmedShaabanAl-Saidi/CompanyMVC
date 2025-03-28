using Microsoft.AspNetCore.Http;

namespace Company.service.Helper
{
    public class DocumentSettings
    {
        public static string UploadFiles(IFormFile file,string folderName)
        {
            // 1 .Get Folder Path
            var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Files" , folderName);

            // 2. Get File Name
            var fileName = $"{Guid.NewGuid()}-{file.FileName}";

            // 3. Combine Folder Path and File Path
            var filePath = Path.Combine(folderPath, fileName);

            // 4. Save File
            using var fileStream = new FileStream(filePath, FileMode.Create);

            file.CopyTo(fileStream);

            return fileName;
        }

    }
}
