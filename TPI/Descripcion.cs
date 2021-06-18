using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI
{
    public class Descripcion
    {
        private string path;
        private string descripcion;

        public Descripcion(string path, string descripcion)
        {
            this.path = path;
            this.descripcion = descripcion;
        }

        public string getPath()
        {
            return path;
        }

        public string getDescripcion()
        {
            return descripcion;
        }

        public void setPath(string path)
        {
            this.path = path;
        }

        public void setDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }

    }
}
