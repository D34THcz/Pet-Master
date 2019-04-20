using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Master
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bla");
        }


        private void labelLoadGameMenu_Click(object sender, EventArgs e)
        {

        }


        private void labelQuitGameMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
