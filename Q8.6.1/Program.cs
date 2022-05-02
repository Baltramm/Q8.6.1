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

                        file.Delete();


                    }
                    foreach (DirectoryInfo direc in directory.GetDirectories())
                    {

                        direc.Delete(true);


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
