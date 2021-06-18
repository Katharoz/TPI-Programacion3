using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPI
{
    public class Filefinder
    {
        private static List<FileInfo> fileInfo = new List<FileInfo>();
        private static List<DirectoryInfo> directoryInfo = new List<DirectoryInfo>();

        public static void BuscarArchivosPorCarpeta(string filePath)
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

        public static void BuscarArchivosPorNombre(string filePath, string searchPattern)
        {
            fileInfo.Clear();

            foreach (string file in Directory.GetFiles(filePath, "*"+searchPattern+"*", SearchOption.AllDirectories))
            {
                fileInfo.Add(new FileInfo(file));
            }
        }



        public static List<DirectoryInfo> getDirectories()
        {
            return directoryInfo;
        }

        public static List<FileInfo> getFiles()
        {
            return fileInfo;
        }

    }
}
