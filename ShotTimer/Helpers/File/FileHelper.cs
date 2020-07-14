using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Net;
using System.Security;

namespace Helpers.File
{
    public static class FileHelper
    {
        public static bool WriteFile(string path, string fileName, string fileContent, bool deleteIfExists = true) 
        {
            bool response = true;
            try
            {
                var fullPath = Path.Combine(path, fileName);
                if (System.IO.File.Exists(fullPath)) 
                {
                    if (deleteIfExists) System.IO.File.Delete(fullPath);
                    else response = false;

                    if (response) 
                    {
                        using (var writer = new StreamWriter(fullPath)) 
                        {
                            writer.WriteLine(fileContent);
                            writer.Flush();
                            writer.Dispose();
                        }
                    }
                }
            }
            catch (Exception ex) 
            {
                string sErr = $"EXCEPTION: {ex.Message}";
                response = false;
            }
            return response;
        }
    }
}
