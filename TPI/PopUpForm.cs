using System;
using System.Windows.Forms;

namespace TPI
{
    public partial class PopUpForm : Form
    {
        public PopUpForm()
        {
            InitializeComponent();
        }

        public void LoadPopUp(string name, string description)
        {
            nameLabel.Text = name;
            if (description != null)
            {
                descriptionTextBox.Text = description;
            }
        }

        public string GetDescription()
        {
            return descriptionTextBox.Text;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
