using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TPI
{
    public class Filefinder
    {
        private static List<FileInfo> fileInfo = new List<FileInfo>();
        private static List<DirectoryInfo> directoryInfo = new List<DirectoryInfo>();

        public static void SearchFilesAndDirectories(string filePath)
        {
            fileInfo.Clear();
            directoryInfo.Clear();

            foreach (string file in Directory.GetFiles(filePath))
            {
                fileInfo.Add(new FileInfo(file));
            }

            foreach (string dir in Directory.GetDirectories(filePath))
            {
                directoryInfo.Add(new DirectoryInfo(dir));
            }

        }

        public static void SearchFilesByName(string filePath, string searchPattern)
        {
            fileInfo.Clear();

            foreach (string file in Directory.GetFiles(filePath, "*"+searchPattern+"*", SearchOption.AllDirectories))
            {
                fileInfo.Add(new FileInfo(file));
            }
        }

        public static void SearchFilesByDescription(List<Description> descriptions, string searchPattern)
        {
            foreach (Description description in descriptions)
            {
                if (description.GetDescripcion().ToLower().Contains(searchPattern.ToLower()))
                {
                    fileInfo.Add(new FileInfo(description.GetPath()));
                }
            }
        }

        public static string GetActualPath(string filepath, string selectedItem)
        {
            SearchFilesByName(filepath, selectedItem);
            return GetFiles().First().FullName;
        }

        public static List<DirectoryInfo> GetDirectories()
        {
            return directoryInfo;
        }

        public static List<FileInfo> GetFiles()
        {
            return fileInfo;
        }

    }
}
