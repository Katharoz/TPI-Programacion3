using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace TPI
{
    public class Filefinder
    {
        private static List<FileInfo> fileInfo = new List<FileInfo>();

        public static void SearchFiles(string filePath)
        {
            fileInfo.Clear();

            foreach (string file in Directory.GetFiles(filePath))
            {
                fileInfo.Add(new FileInfo(file));
            }

        }

        public static void SearchFilesByName(string filePath, string searchPattern)
        {
            fileInfo.Clear();

            foreach (string file in Directory.GetFiles(filePath, "*"+searchPattern+"*"))
            {
                fileInfo.Add(new FileInfo(file));
            }
        }

        public static void SearchFilesByDescription(ListView descriptions, string searchPattern)
        {
            for (int i=0;i<descriptions.Items.Count;i++)
            {
                if (descriptions.Items[i].SubItems[3].Text.ToLower().Contains(searchPattern.ToLower()))
                {
                    fileInfo.Add(new FileInfo(descriptions.Items[i].SubItems[4].Text));
                    
                }
            }
        }

        public static List<FileInfo> GetFiles()
        {
            return fileInfo;
        }

    }
}
