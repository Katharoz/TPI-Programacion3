using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace TPI
{
    public partial class FileManager : Form
    {
        string filePath = "C:/";
        string selectedItem = "";
        List<Description> descriptions = new List<Description>();
        string actualPath = null;

        public FileManager()
        {
            InitializeComponent();
            LoadFilesAndDirectories();
        }

        public void LoadFilesAndDirectories()
        {
            listView.Items.Clear();

            Filefinder.SearchFilesAndDirectories(filePath);
            LoadDirectories(Filefinder.GetDirectories());
            LoadFiles(Filefinder.GetFiles());
        }

        public void LoadDirectories(List<DirectoryInfo> directories)
        {
            foreach (DirectoryInfo dirInfo in directories)
            {
                if ((dirInfo.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                {
                    listView.Items.Add(dirInfo.Name, 0);
                }
            }
        }

        public void LoadFiles(List<FileInfo> files)
        {
            foreach (FileInfo fileInfo in files)
            {
                if ((fileInfo.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                {
                    listView.Items.Add(fileInfo.Name, 1);
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
                    descriptionTextBox.Text = temp.GetDescripcion();
                }
                descriptionTextBox.Focus();
                saveButton.Enabled = true;
                cancelButton.Enabled = true;
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

            listView.Items.Clear();

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

    }
}
