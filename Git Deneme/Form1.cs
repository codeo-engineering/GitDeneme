using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Git_Deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Base Button");
        }

        private void gulserButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gulser");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DMY");
        }
    }
}
