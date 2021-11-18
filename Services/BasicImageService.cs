using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AddressBookMVC.Services.Interfaces;
using Microsoft.AspNetCore.Http;

namespace AddressBookMVC.Services
{
	public class BasicImageService : IImageService
	{
		public async Task<byte[]> ConvertFileToByteArrayAsync(IFormFile file)
		{
			using MemoryStream memoryStream = new();
			await file.CopyToAsync(memoryStream);
			byte[] byteFile = memoryStream.ToArray();

			return byteFile;
		}

		public string ConvertByteArrayToFile(byte[] fileData, string extension)
		{
			if (fileData is null) return string.Empty;

			string imageBase64Data = Convert.ToBase64String(fileData);
			return $"data:{extension};base64,{imageBase64Data}";
		}
	}
}
