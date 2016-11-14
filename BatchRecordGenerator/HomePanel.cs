using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchRecordGenerator
{
    public partial class HomePanel : Form
    {
        public HomePanel()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            CreatePanel createPanel = new CreatePanel();
            createPanel.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // separator bevel line
            label1.AutoSize = false;
            label1.Height = 2;
            label1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void HomePanel_Load(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EditPanel editPanel = new EditPanel();
            editPanel.Show();
            this.Hide();
        }

        private void HomePanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Closes the application
            Application.Exit();
        }
    }
}
