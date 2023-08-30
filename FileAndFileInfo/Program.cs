using System.IO;

namespace FileAndFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\somefile.jpg";

            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            File.Delete(path);
            if (File.Exists(path))
            {
                //
            }
            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }

            // Directory and DirectoryInfo

            Directory.CreateDirectory(@"c:\temp\folder1");

            var files = Directory.GetFiles(@"c:\projects\CSharpFundamentals", "*.*", SearchOption.AllDirectories);
            foreach ( var file in files)
            {
                Console.WriteLine(file);
            }

            var directories = Directory.GetDirectories(@"c:\projects\CSharpFundamentals", "*.*", 
                SearchOption.AllDirectories);
            foreach ( var directory in directories)
            {
                Console.WriteLine(directory);
            }

            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();

            // Path

            var path_1 = @"C:\Projects\CSharpFundamentals\HelloWorld\HelloWorld.sln";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine("Extension: " + Path.GetExtension(path_1));
            Console.WriteLine("File Name: " + Path.GetFileName(path_1));
            Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(path_1));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path_1));
        }
    }
}
