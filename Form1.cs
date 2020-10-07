using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProgramming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TextBox myTextBox = new TextBox();

        private void buttonOK_Click_1(object sender, EventArgs e)
        {
            textBoxDisplay.Text = "Hello world";
        }
    }
}
