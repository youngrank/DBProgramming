using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketBrowser
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        string str = "";
        private void buttonOpenCSV_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(new FileStream("market.csv", FileMode.Open), Encoding.Default);

            var line = sr.ReadLine();
            var headers = line.Split(',');

            foreach(string header in headers)
            {
                textBoxCSVViwer.Text += header + "\t";
            }
            
            /*
            while (sr.EndOfStream == false)
            {
                line = sr.ReadLine();
                var value = line.Split(',');
                str += value[0] + "\r\n";
            }
            textBoxCSVViwer.Text = str;
            */
            sr.Close();
        }
    }
}
