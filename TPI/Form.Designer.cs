
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
            this.backButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.dirFilesListView = new System.Windows.Forms.ListView();
            this.listaIconos = new System.Windows.Forms.ImageList(this.components);
            this.driversListView = new System.Windows.Forms.ListView();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.escanedDirListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(182, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Volver";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
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
            this.searchBar.Location = new System.Drawing.Point(263, 14);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(515, 20);
            this.searchBar.TabIndex = 2;
            // 
            // dirFilesListView
            // 
            this.dirFilesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dirFilesListView.HideSelection = false;
            this.dirFilesListView.LargeImageList = this.listaIconos;
            this.dirFilesListView.Location = new System.Drawing.Point(182, 41);
            this.dirFilesListView.Name = "dirFilesListView";
            this.dirFilesListView.Size = new System.Drawing.Size(677, 354);
            this.dirFilesListView.SmallImageList = this.listaIconos;
            this.dirFilesListView.TabIndex = 3;
            this.dirFilesListView.UseCompatibleStateImageBehavior = false;
            this.dirFilesListView.View = System.Windows.Forms.View.Tile;
            this.dirFilesListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListView_ItemSelectionChanged);
            this.dirFilesListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView_MouseDoubleClick);
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
            this.driversListView.Location = new System.Drawing.Point(182, 401);
            this.driversListView.Name = "driversListView";
            this.driversListView.Size = new System.Drawing.Size(677, 63);
            this.driversListView.SmallImageList = this.listaIconos;
            this.driversListView.TabIndex = 8;
            this.driversListView.UseCompatibleStateImageBehavior = false;
            this.driversListView.View = System.Windows.Forms.View.Tile;
            this.driversListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.driversListView_ItemSelectionChanged);
            this.driversListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.driversListView_MouseDoubleClick);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(15, 441);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Guardar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.Enabled = false;
            this.cancelButton.Location = new System.Drawing.Point(101, 441);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.descriptionTextBox.Enabled = false;
            this.descriptionTextBox.Location = new System.Drawing.Point(15, 401);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(161, 25);
            this.descriptionTextBox.TabIndex = 5;
            this.descriptionTextBox.LostFocus += new System.EventHandler(this.DescriptionTextBox_LostFocus);
            // 
            // escanedDirListView
            // 
            this.escanedDirListView.HideSelection = false;
            this.escanedDirListView.Location = new System.Drawing.Point(12, 41);
            this.escanedDirListView.Name = "escanedDirListView";
            this.escanedDirListView.Size = new System.Drawing.Size(164, 354);
            this.escanedDirListView.TabIndex = 9;
            this.escanedDirListView.UseCompatibleStateImageBehavior = false;
            this.escanedDirListView.View = System.Windows.Forms.View.Details;
            this.escanedDirListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.escanedDirListView_ItemSelectionChanged);
            this.escanedDirListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.escanedDirListView_MouseDoubleClick);
            // 
            // FileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 481);
            this.Controls.Add(this.escanedDirListView);
            this.Controls.Add(this.driversListView);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.dirFilesListView);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.backButton);
            this.Name = "FileManager";
            this.Text = "FileManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.ListView dirFilesListView;
        private System.Windows.Forms.ImageList listaIconos;
        private System.Windows.Forms.ListView driversListView;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.ListView escanedDirListView;
    }
}

