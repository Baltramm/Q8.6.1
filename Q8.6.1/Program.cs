using System;
using System.IO;
namespace Q8._6._1
{
    class Program
    {
        static void Main(string[] args)
        {

            

            string filePath = @"C://Filex";
            
            if (!File.Exists(filePath))
            {
                try
                {
                    var directory = new DirectoryInfo(filePath);
                    foreach (FileInfo file in directory.GetFiles())
                    {
                        
                        var deltaTime = DateTime.Now - File.GetLastWriteTime(filePath); ;
                        if (deltaTime == TimeSpan.FromMinutes(30))
                        {
                            file.Delete();
                        }

                    }
                    foreach (DirectoryInfo direc in directory.GetDirectories())
                    {
                        var deltaTime = DateTime.Now - File.GetLastWriteTime(filePath);
                        if (deltaTime == TimeSpan.FromMinutes(30))
                        {
                            direc.Delete(true);
                        }


                    }



                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

    }
}
