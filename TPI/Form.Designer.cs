
namespace TPI
{
    partial class FileManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileManager));
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.filesListView = new System.Windows.Forms.ListView();
            this.columnName_FileView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnType_FileView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLastM_FileView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnComentary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listaIconos = new System.Windows.Forms.ImageList(this.components);
            this.driversListView = new System.Windows.Forms.ListView();
            this.escanedDirListView = new System.Windows.Forms.ListView();
            this.columnName_escanneddisk = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Location = new System.Drawing.Point(784, 12);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Buscar";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // searchBar
            // 
            this.searchBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBar.Location = new System.Drawing.Point(182, 14);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(596, 20);
            this.searchBar.TabIndex = 2;
            // 
            // dirFilesListView
            // 
            this.filesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName_FileView,
            this.columnType_FileView,
            this.columnLastM_FileView,
            this.columnComentary});
            this.filesListView.HideSelection = false;
            this.filesListView.LargeImageList = this.listaIconos;
            this.filesListView.Location = new System.Drawing.Point(182, 41);
            this.filesListView.Name = "dirFilesListView";
            this.filesListView.Size = new System.Drawing.Size(677, 354);
            this.filesListView.SmallImageList = this.listaIconos;
            this.filesListView.TabIndex = 3;
            this.filesListView.UseCompatibleStateImageBehavior = false;
            this.filesListView.View = System.Windows.Forms.View.Details;
            this.filesListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView_MouseDoubleClick);
            // 
            // columnName_FileView
            // 
            this.columnName_FileView.Text = "Name";
            // 
            // columnType_FileView
            // 
            this.columnType_FileView.Text = "Type";
            // 
            // columnLastM_FileView
            // 
            this.columnLastM_FileView.Text = "Last Modified";
            // 
            // columnComentary
            // 
            this.columnComentary.Text = "Comentary";
            // 
            // listaIconos
            // 
            this.listaIconos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listaIconos.ImageStream")));
            this.listaIconos.TransparentColor = System.Drawing.Color.Transparent;
            this.listaIconos.Images.SetKeyName(0, "Driver_Icon.png");
            this.listaIconos.Images.SetKeyName(1, "Folder_Icon.png");
            this.listaIconos.Images.SetKeyName(2, "File_Icon.png");
            this.listaIconos.Images.SetKeyName(3, "Video_Icon.png");
            this.listaIconos.Images.SetKeyName(4, "Image_Icon.png");
            this.listaIconos.Images.SetKeyName(5, "Text_Icon.png");
            // 
            // driversListView
            // 
            this.driversListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.driversListView.HideSelection = false;
            this.driversListView.LargeImageList = this.listaIconos;
            this.driversListView.Location = new System.Drawing.Point(12, 401);
            this.driversListView.Name = "driversListView";
            this.driversListView.Size = new System.Drawing.Size(847, 63);
            this.driversListView.SmallImageList = this.listaIconos;
            this.driversListView.TabIndex = 8;
            this.driversListView.UseCompatibleStateImageBehavior = false;
            this.driversListView.View = System.Windows.Forms.View.Tile;
            this.driversListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.DriversListView_ItemSelectionChanged);
            this.driversListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DriversListView_MouseDoubleClick);
            // 
            // escanedDirListView
            // 
            this.escanedDirListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.escanedDirListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName_escanneddisk});
            this.escanedDirListView.HideSelection = false;
            this.escanedDirListView.Location = new System.Drawing.Point(12, 14);
            this.escanedDirListView.Name = "escanedDirListView";
            this.escanedDirListView.Size = new System.Drawing.Size(164, 381);
            this.escanedDirListView.SmallImageList = this.listaIconos;
            this.escanedDirListView.TabIndex = 9;
            this.escanedDirListView.UseCompatibleStateImageBehavior = false;
            this.escanedDirListView.View = System.Windows.Forms.View.Details;
            this.escanedDirListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.escanedDirListView_MouseDoubleClick);
            // 
            // columnName_escanneddisk
            // 
            this.columnName_escanneddisk.Text = "Name";
            // 
            // FileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 481);
            this.Controls.Add(this.escanedDirListView);
            this.Controls.Add(this.driversListView);
            this.Controls.Add(this.filesListView);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.searchButton);
            this.Name = "FileManager";
            this.Text = "FileManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.ListView filesListView;
        private System.Windows.Forms.ImageList listaIconos;
        private System.Windows.Forms.ListView driversListView;
        private System.Windows.Forms.ListView escanedDirListView;
        private System.Windows.Forms.ColumnHeader columnName_escanneddisk;
        private System.Windows.Forms.ColumnHeader columnName_FileView;
        private System.Windows.Forms.ColumnHeader columnType_FileView;
        private System.Windows.Forms.ColumnHeader columnLastM_FileView;
        private System.Windows.Forms.ColumnHeader columnComentary;
    }
}

