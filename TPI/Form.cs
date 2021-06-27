using System;
using System.IO;
using System.Windows.Forms;

namespace TPI
{
    public partial class FileManager : Form
    {
        string filePath;
        string selectedItem;
        
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

        private void DriversListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            selectedItem = e.Item.Text;
        }

        private void DriversListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = selectedItem;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                for(int i = 0; i < escanedDirListView.Items.Count; i++)
                {
                    if (escanedDirListView.Items[i].SubItems[2].Text.Equals(fbd.SelectedPath))
                        return;
                }
                filePath = fbd.SelectedPath;
                LoadEscanedDirsViewList(filePath);
            }
        }

        public void LoadEscanedDirsViewList(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            var item = new ListViewItem(dir.Name, 1);
            var subItems = new ListViewItem.ListViewSubItem[]
                {          new ListViewItem.ListViewSubItem(item,
                                dir.LastAccessTime.ToShortDateString()),
                            new ListViewItem.ListViewSubItem(item,dir.FullName),};
            item.SubItems.AddRange(subItems);
            escanedDirListView.Items.Add(item);
            escanedDirListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void escanedDirListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            searchBar.Text = "";
            filePath = escanedDirListView.SelectedItems[0].SubItems[2].Text;
            Filefinder.SearchFiles(filePath);
            LoadFiles();
        }

        public void LoadFiles()
        {
            int icon;
            filesListView.Items.Clear();

            foreach (FileInfo fileInfo in Filefinder.GetFiles())
            {
                if ((fileInfo.Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                {
                    icon = SelectIcon(fileInfo);
                    var item = new ListViewItem(fileInfo.Name, 2);
                    var subItems = new ListViewItem.ListViewSubItem[]
                        { new ListViewItem.ListViewSubItem(item,"File"),
                      new ListViewItem.ListViewSubItem(item,
                        fileInfo.LastAccessTime.ToShortDateString()),
                      new ListViewItem.ListViewSubItem(item,""),
                      new ListViewItem.ListViewSubItem(item,fileInfo.FullName)};
                    item.SubItems.AddRange(subItems);
                    filesListView.Items.Add(item);
                }
            }
            filesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }
        
        public int SelectIcon(FileInfo fileInfo)
        {
            int a = 0;
            switch (fileInfo.Extension)
            {
                
            }
            return a;
        }

        private void ListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string fileName = filesListView.SelectedItems[0].SubItems[4].Text;
            string description = filesListView.SelectedItems[0].SubItems[3].Text;

            var popUp = new PopUpForm();
            popUp.LoadPopUp(fileName.Substring(fileName.LastIndexOf("\\") + 1), description);
            popUp.ShowDialog();
            filesListView.SelectedItems[0].SubItems[3].Text = popUp.GetDescription();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(searchBar.Text) && !string.IsNullOrEmpty(filePath))
            {
                Filefinder.SearchFilesByName(filePath, searchBar.Text);
                Filefinder.SearchFilesByDescription(filesListView, searchBar.Text);

                LoadFiles();
            }
        }

    }
}
