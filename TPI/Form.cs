using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPI
{
    public partial class FileManager : Form
    {
        string filePath = "C:/";
        string itemSeleccionado = "";
        List<Descripcion> descripciones = new List<Descripcion>();
        FileInfo pathInfo;

        public FileManager()
        {
            InitializeComponent();
            CargarArchivosYCarpetas();
        }

        public void CargarArchivosYCarpetas()
        {
            DirectoryInfo listaArchivos;
            listaArchivos = new DirectoryInfo(filePath);

            DirectoryInfo[] carpetas = listaArchivos.GetDirectories();
            FileInfo[] archivos = listaArchivos.GetFiles();

            VistaEnLista.Items.Clear();

            Filefinder.BuscarArchivosPorCarpeta(filePath);
            CargarCarpetas(Filefinder.getDirectories().ToArray());
            CargarArchivos(Filefinder.getFiles().ToArray());

            //CargarCarpetas(carpetas);
            //CargarArchivos(archivos);

        }

        public void CargarCarpetas(DirectoryInfo[] carpetas)
        {
            for (int i = 0; i < carpetas.Length; i++)
            {
                if ((carpetas[i].Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                {
                    VistaEnLista.Items.Add(carpetas[i].Name, 0);
                }
            }
        }

        public void CargarArchivos(FileInfo[] archivos)
        {
            for (int i = 0; i < archivos.Length; i++)
            {
                if ((archivos[i].Attributes & FileAttributes.Hidden) != FileAttributes.Hidden)
                {
                    VistaEnLista.Items.Add(archivos[i].Name, 1);
                }
            }
        }

        private void VistaEnLista_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            itemSeleccionado = e.Item.Text;
            //barraBúsqueda.Text = filePath + "/" + itemSeleccionado;

        }

        private void VistaEnLista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FileAttributes atributos;
            try
            {
                atributos = File.GetAttributes(filePath + "/" + itemSeleccionado);
            }
            catch
            {
                atributos = File.GetAttributes(Directory.GetFiles(filePath, itemSeleccionado, SearchOption.AllDirectories).First());
                //atributos = File.GetAttributes(BuscarArchivo(filePath));
            }
            
            if ((atributos & FileAttributes.Directory) == FileAttributes.Directory)
            {
                filePath = filePath + "/" + itemSeleccionado;
                CargarArchivosYCarpetas();
            }
            else
            {
                Descripcion temp = CheckearDescripcionExistente();
                if (temp != null)
                {
                    descripcionTextBox.Text = temp.getDescripcion();
                }
                descripcionTextBox.Focus();
                botónGuardar.Enabled = true;
                botónCancelar.Enabled = true;
            }

            
        }

        public Descripcion CheckearDescripcionExistente()
        {
            Descripcion temp = null;

            Filefinder.BuscarArchivosPorNombre(filePath, itemSeleccionado);
            string actualPath = Filefinder.getFiles().First().FullName;

            foreach (Descripcion descripcion in descripciones)
            {
                

                if (descripcion.getPath().Equals(actualPath))
                {
                    temp = descripcion;
                    break;
                }
            }
            return temp;
        }

        private void botónVolver_Click(object sender, EventArgs e)
        {
            if (filePath != "C:/")
            {
                filePath = filePath.Substring(0, filePath.LastIndexOf("/"));
                CargarArchivosYCarpetas();
            }
            
        }

        private void botónCancelar_Click(object sender, EventArgs e)
        {
            descripcionTextBox.Text = "";
            descripcionTextBox.Focus();
        }

        public void descripcionTextBox_LostFocus(object sender, EventArgs e)
        {
            if (!botónCancelar.Focused && !botónGuardar.Focused)
            {
                botónCancelar.Enabled = false;
                botónGuardar.Enabled = false;
            }
            
        }

        private void botónGuardar_Click(object sender, EventArgs e)
        {
            string actualPath = null;

            Descripcion temp = CheckearDescripcionExistente();
            if (temp == null)
            {
                Filefinder.BuscarArchivosPorNombre(filePath, itemSeleccionado);
                actualPath = Filefinder.getFiles().First().FullName;

                descripciones.Add(new Descripcion(actualPath, descripcionTextBox.Text));
            }
            else
            {
                temp.setDescripcion(descripcionTextBox.Text);
            }
            descripcionTextBox.Focus();

            barraBúsqueda.Text = actualPath;
        }

        #region Big Mess
        /*
        //private static List<string> files = new List<string>();
        private void botónBuscar_Click(object sender, EventArgs e)
        {
            //files.Clear();
            List<FileInfo> fileInfo = new List<FileInfo>();
            string[] files = Directory.GetFiles(filePath, "*" +barraBúsqueda.Text+ "*", SearchOption.AllDirectories);
            //string[] files = Directory.EnumerateFiles(filePath, "*" +barraBúsqueda.Text+ "*", SearchOption.AllDirectories).ToArray();

            //BuscarArchivos(filePath);
            

            foreach (string file in files)
            {
                fileInfo.Add(new FileInfo(file));
            }

            VistaEnLista.Items.Clear();

            CargarArchivos(fileInfo.ToArray());
        }

        public string BuscarArchivo(string path)
        {
            foreach (string file in Directory.GetFiles(path))
            {
                if (file.Contains(itemSeleccionado))
                {
                    return file;
                }
            }
            foreach (string dir in Directory.GetDirectories(path))
            {
                return BuscarArchivo(dir);
            }
            return null;
        }

        public void BuscarArchivos(string path)
        {
            try
            {
                foreach (string file in Directory.GetFiles(path))
                {
                    if (file.ToLower().Contains(barraBúsqueda.Text.ToLower()))
                    {
                        files.Add(file);
                    }
                }

                foreach (string dir in Directory.GetDirectories(path))
                {
                    BuscarArchivos(dir);
                }
            }
            catch (UnauthorizedAccessException)
            {

            }
        }
        */
        #endregion


        private void botónBuscar_Click(object sender, EventArgs e)
        {
            Filefinder.BuscarArchivosPorNombre(filePath, barraBúsqueda.Text);

            VistaEnLista.Items.Clear();

            CargarArchivos(Filefinder.getFiles().ToArray());

        }
    }
}
