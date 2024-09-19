using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Reflection.Metadata;

namespace App.PL.Helpers
{
	public class DocumentSettings
	{
		public static string UploadFile(IFormFile formFile , string Folder)
		{
			string FolderPath = Path.Combine(Directory.GetCurrentDirectory() , "wwwroot\\Files" , Folder);
			string FileName = $"{Guid.NewGuid()}{formFile.FileName}";
			string FilePath = Path.Combine(FolderPath ,FileName);
			FileStream fileStream = new FileStream(FilePath, FileMode.Create);
			formFile.CopyTo(fileStream);
			return FileName;
		}
		public static void DeleteFile(string FileName , string FolderName)
		{

			string FolderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Files", FolderName,FileName);
			if(File.Exists(FolderPath))
			{
				File.Delete(FolderPath);	
			}
		}
	}
}
