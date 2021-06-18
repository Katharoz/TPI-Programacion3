
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
            this.botónVolver = new System.Windows.Forms.Button();
            this.botónBuscar = new System.Windows.Forms.Button();
            this.barraBúsqueda = new System.Windows.Forms.TextBox();
            this.VistaEnLista = new System.Windows.Forms.ListView();
            this.listaIconos = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.botónGuardar = new System.Windows.Forms.Button();
            this.botónCancelar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // botónVolver
            // 
            this.botónVolver.Location = new System.Drawing.Point(182, 12);
            this.botónVolver.Name = "botónVolver";
            this.botónVolver.Size = new System.Drawing.Size(75, 23);
            this.botónVolver.TabIndex = 0;
            this.botónVolver.Text = "Volver";
            this.botónVolver.UseVisualStyleBackColor = true;
            this.botónVolver.Click += new System.EventHandler(this.botónVolver_Click);
            // 
            // botónBuscar
            // 
            this.botónBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botónBuscar.Location = new System.Drawing.Point(784, 12);
            this.botónBuscar.Name = "botónBuscar";
            this.botónBuscar.Size = new System.Drawing.Size(75, 23);
            this.botónBuscar.TabIndex = 1;
            this.botónBuscar.Text = "Buscar";
            this.botónBuscar.UseVisualStyleBackColor = true;
            this.botónBuscar.Click += new System.EventHandler(this.botónBuscar_Click);
            // 
            // barraBúsqueda
            // 
            this.barraBúsqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.barraBúsqueda.Location = new System.Drawing.Point(263, 14);
            this.barraBúsqueda.Name = "barraBúsqueda";
            this.barraBúsqueda.Size = new System.Drawing.Size(515, 20);
            this.barraBúsqueda.TabIndex = 2;
            // 
            // VistaEnLista
            // 
            this.VistaEnLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VistaEnLista.HideSelection = false;
            this.VistaEnLista.LargeImageList = this.listaIconos;
            this.VistaEnLista.Location = new System.Drawing.Point(182, 41);
            this.VistaEnLista.Name = "VistaEnLista";
            this.VistaEnLista.Size = new System.Drawing.Size(677, 394);
            this.VistaEnLista.SmallImageList = this.listaIconos;
            this.VistaEnLista.TabIndex = 3;
            this.VistaEnLista.UseCompatibleStateImageBehavior = false;
            this.VistaEnLista.View = System.Windows.Forms.View.Tile;
            this.VistaEnLista.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.VistaEnLista_ItemSelectionChanged);
            this.VistaEnLista.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.VistaEnLista_MouseDoubleClick);
            // 
            // listaIconos
            // 
            this.listaIconos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listaIconos.ImageStream")));
            this.listaIconos.TransparentColor = System.Drawing.Color.Transparent;
            this.listaIconos.Images.SetKeyName(0, "Folder_Icon.png");
            this.listaIconos.Images.SetKeyName(1, "File_Icon.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Descripción";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.descripcionTextBox.Location = new System.Drawing.Point(15, 41);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(161, 394);
            this.descripcionTextBox.TabIndex = 5;
            this.descripcionTextBox.LostFocus += new System.EventHandler(this.descripcionTextBox_LostFocus);
            // 
            // botónGuardar
            // 
            this.botónGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.botónGuardar.Enabled = false;
            this.botónGuardar.Location = new System.Drawing.Point(15, 441);
            this.botónGuardar.Name = "botónGuardar";
            this.botónGuardar.Size = new System.Drawing.Size(75, 23);
            this.botónGuardar.TabIndex = 6;
            this.botónGuardar.Text = "Guardar";
            this.botónGuardar.UseVisualStyleBackColor = true;
            this.botónGuardar.Click += new System.EventHandler(this.botónGuardar_Click);
            // 
            // botónCancelar
            // 
            this.botónCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.botónCancelar.Enabled = false;
            this.botónCancelar.Location = new System.Drawing.Point(101, 441);
            this.botónCancelar.Name = "botónCancelar";
            this.botónCancelar.Size = new System.Drawing.Size(75, 23);
            this.botónCancelar.TabIndex = 7;
            this.botónCancelar.Text = "Cancelar";
            this.botónCancelar.UseVisualStyleBackColor = true;
            this.botónCancelar.Click += new System.EventHandler(this.botónCancelar_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(182, 441);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(606, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // FileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 481);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.botónCancelar);
            this.Controls.Add(this.botónGuardar);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VistaEnLista);
            this.Controls.Add(this.barraBúsqueda);
            this.Controls.Add(this.botónBuscar);
            this.Controls.Add(this.botónVolver);
            this.Name = "FileManager";
            this.Text = "FileManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botónVolver;
        private System.Windows.Forms.Button botónBuscar;
        private System.Windows.Forms.TextBox barraBúsqueda;
        private System.Windows.Forms.ListView VistaEnLista;
        private System.Windows.Forms.ImageList listaIconos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.Button botónGuardar;
        private System.Windows.Forms.Button botónCancelar;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

