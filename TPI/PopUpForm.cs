using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPI
{
    public partial class PopUpForm : Form
    {
        public PopUpForm()
        {
            InitializeComponent();
        }

        public void LoadPopUp(string name, Description description)
        {
            nameTextBox.Text = name;
            if (description != null)
            {
                descriptionTextBox.Text = description.GetDescripcion();
            }
        }

        public string GetName()
        {
            return nameTextBox.Text;
        }

        public string GetDescription()
        {
            return descriptionTextBox.Text;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
