using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace TPI
{
    public partial class FileManager : Form
    {
        string filePath = "";
        string selectedItem = "";
        List<Description> descriptions = new List<Description>();
        string actualPath = null;

        List<string> escanedPaths = new List<string>();

        public FileManager()
        {
            InitializeComponent();
            LoadDisks();
        }

        public void LoadDisks()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            for (int i = 0; i < drives.Length; i++)
            {
                driversListView.Items.Add(drives[i].Name, 0);
            }
        }

        private void driversListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            selectedItem = e.Item.Text;
        }

        private void driversListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                filePath = fbd.SelectedPath;
                escanedPaths.Add(filePath);
            }
            //filePath = selectedItem;

            //LoadFilesAndDirectories();

            LoadEscaned();
        }

        public void LoadEscaned()
        {
            escanedDirListView.Items.Add(filePath.Substring(filePath.LastIndexOf("\\") + 1), 1);
        }



        public void LoadFilesAndDirectories()
        {
            dirFilesListView.Items.Clear();

            Filefinder.SearchFilesAndDirectories(filePath);
            LoadDirectories(Filefinder.GetDirectories(), dirFilesListView);
            LoadFiles(Filefinder.GetFiles());
        }

        public void LoadDirectories(List<DirectoryInfo> directories, ListView view)
        {
            foreach (DirectoryInfo dirInfo in directories)
            {
                if ((dirInfo.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                {
                    view.Items.Add(dirInfo.Name, 1);
                }
            }
        }

        public void LoadFiles(List<FileInfo> files)
        {
            foreach (FileInfo fileInfo in files)
            {
                if ((fileInfo.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                {
                    switch (fileInfo.Extension)
                    {
                        case ".mp4": dirFilesListView.Items.Add(fileInfo.Name, 3);  break;
                        case ".jpg":
                        case ".png": dirFilesListView.Items.Add(fileInfo.Name, 4);  break;
                        case ".pdf":
                        case ".txt": dirFilesListView.Items.Add(fileInfo.Name, 5);  break;
                        default: dirFilesListView.Items.Add(fileInfo.Name, 2);  break;
                    }
                }
            }
        }

        private void ListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            selectedItem = e.Item.Text;
        }

        private void ListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            searchBar.Text = "";
            descriptionTextBox.Text = "";

            FileAttributes attributes;
            try
            {
                attributes = File.GetAttributes(filePath + "/" + selectedItem);
            }
            catch
            {
                attributes = File.GetAttributes(Filefinder.GetActualPath(filePath, selectedItem));
            }
            
            if ((attributes & FileAttributes.Directory) == FileAttributes.Directory)
            {
                filePath = filePath + "/" + selectedItem;
                LoadFilesAndDirectories();
            }
            else
            {
                Description temp = CheckDescriptions();
                if (temp != null)
                {
                    ////PopUp(selectedItem, temp);
                    descriptionTextBox.Text = temp.GetDescripcion();
                }
                descriptionTextBox.Focus();
                saveButton.Enabled = true;
                cancelButton.Enabled = true;

                //PopUp(selectedItem, null);
            }
        }

        public Description CheckDescriptions()
        {
            Description temp = null;

            actualPath = Filefinder.GetActualPath(filePath, selectedItem);

            foreach (Description descripcion in descriptions)
            {
                if (descripcion.GetPath().Equals(actualPath))
                {
                    temp = descripcion;
                    break;
                }
            }
            return temp;
        }

        public void PopUp(string name, Description description)
        {
            var popUp = new PopUpForm();
            popUp.LoadPopUp(name, description);
            popUp.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (filePath != "C:/")
            {
                filePath = filePath.Substring(0, filePath.LastIndexOf("/"));
                LoadFilesAndDirectories();
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Filefinder.SearchFilesByName(filePath, searchBar.Text);
            Filefinder.SearchFilesByDescription(descriptions, searchBar.Text);

            dirFilesListView.Items.Clear();

            LoadFiles(Filefinder.GetFiles());
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            descriptionTextBox.Text = "";
            descriptionTextBox.Focus();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Description temp = CheckDescriptions();
            if (temp == null)
            {
                actualPath = Filefinder.GetActualPath(filePath, selectedItem);
                descriptions.Add(new Description(actualPath, descriptionTextBox.Text));
            }
            else
            {
                temp.SetDescripcion(descriptionTextBox.Text);
            }
            descriptionTextBox.Focus();
        }

        public void DescriptionTextBox_LostFocus(object sender, EventArgs e)
        {
            if (!cancelButton.Focused && !saveButton.Focused)
            {
                cancelButton.Enabled = false;
                saveButton.Enabled = false;
            }
            
        }
        private void escanedDirListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            selectedItem = e.Item.Text;
        }

        private void escanedDirListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (string str in escanedPaths)
            {
                if (str.Substring(str.LastIndexOf("\\") + 1).Equals(selectedItem))
                {
                    filePath = str;
                    break;
                }
            }
            LoadFilesAndDirectories();
        }
    }
}
