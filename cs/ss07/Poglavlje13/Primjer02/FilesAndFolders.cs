using System;
using System.IO;

namespace Primjer02
{
    class FilesAndFolders
    {
        private DirectoryInfo dir;
        private int maxFiles = 0;
        private string hasMostFiles = "";
        private string systemFolder = Environment.GetEnvironmentVariable("SystemRoot");

        public FilesAndFolders(string root)
        {
            dir = new DirectoryInfo(root);
        }

        public int MaxFiles
        {
            get { return maxFiles; }
            set { maxFiles = value; }
        }

        public string HasMostFiles
        {
            get { return hasMostFiles; }
            set { hasMostFiles = value; }
        }

        public void OpenDirectory()
        {
            DirectoryInfo[] directories = null;
            FileInfo[] files = null;


            try
            {
                directories = dir.GetDirectories();
                files = dir.GetFiles();
            }
            catch (Exception)
            {
                Console.WriteLine("Nemam pristup za: " + dir.FullName);
                return;
            }

            if(String.Compare(dir.FullName, 0, systemFolder, 0, systemFolder.Length, true) != 0
                && files.Length > maxFiles)
            {
                maxFiles = files.Length;
                hasMostFiles = dir.FullName;
            }

            foreach(DirectoryInfo nextDir in directories)
            {
                dir = nextDir;
                OpenDirectory();
            }
        }


    }
}
