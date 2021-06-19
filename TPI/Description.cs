
namespace TPI
{
    public class Description
    {
        private string path;
        private string description;

        public Description(string path, string description)
        {
            this.path = path;
            this.description = description;
        }

        public string GetPath()
        {
            return path;
        }

        public string GetDescripcion()
        {
            return description;
        }

        public void SetPath(string path)
        {
            this.path = path;
        }

        public void SetDescripcion(string description)
        {
            this.description = description;
        }

    }
}
