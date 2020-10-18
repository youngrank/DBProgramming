using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

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

        private List<List<string>> MakeColumnarDataStructure()
        {
            StreamReader sr = new StreamReader(new FileStream("market.csv", FileMode.Open), Encoding.Default);

            var line = sr.ReadLine();
            var headers = line.Split(',');

            List<List<string>> data = new List<List<string>>();

            foreach (string header in headers)
            {
                List<string> list = new List<string>();
                list.Add(header);
                data.Add(list);
            }

            int row = 0;
            while (sr.EndOfStream == false)
            {
                line = sr.ReadLine();
                var values = line.Split(',');

                for(int i=0; i<values.Length; i++)
                {
                    data[i].Add(values[i]);
                }
                if (row++ == 10)
                    break;
            }

            sr.Close();
            return data;
        }

        private void printColumnData_columnbased(List<List<string>> data, int columnIIdx)
        {
            string str = "";
            textBoxCSVViwer.Text = ""; // 화면이 지워지는 효과
            foreach (string values in data[1])
            {
                str += values + "\r\n";
            }
            textBoxCSVViwer.Text = str;
        }

        private void printRowData_columnbased(List<List<string>> data)
        {
            string str = "";
            textBoxCSVViwer.Text = ""; // 화면이 지워지는 효과
            for(int row = 0; row < data[0].Count; row++)
            {
                foreach(List<string> list in data)
                {
                    str += list[row] + "\t";
                }
                str += "\r\n";
            }
            textBoxCSVViwer.Text = str;
        }

        private string[] parseCSVLine(string line)
        {
            // line에서 '"'를 찾지 못했을 때 line을 ','로 분할
            if (line.IndexOf('"') == -1) 
                return line.Split(',');

            // line에서 '"'를 포함할 때..
            // line을 '"'로 분할
            string[] splitLine1 = line.Split('"');
            ArrayList splitList = new ArrayList();
            for (int i = 0; i < splitLine1.Length; i++)
            {
                // splitLine1의 짝수번째 인덱스의 값들을 ','로 분할 후 splitList에 삽입
                if (i % 2 == 0)
                {
                    string[] splitLine2 = splitLine1[i].Split(',');
                    foreach (string val in splitLine2) splitList.Add(val);
                }
                // splitLine1의 홀수번째 인덱스의 값들을 splitList에 삽입
                else splitList.Add(splitLine1[i]);
            }

            // ArrayList -> string[]
            string[] result = new string[splitList.Count];

            for (int i = 0; i < splitList.Count; i++)      
                result[i] = splitList[i].ToString();

            return result;
        }

        private List<List<string>> MakeRowBasedDataStructure()
        {
            StreamReader sr = new StreamReader(new FileStream("market.csv", FileMode.Open), Encoding.Default);


            var line = sr.ReadLine();

            List<List<string>> data = new List<List<string>>();

            while (sr.EndOfStream == false)
            {
                line = sr.ReadLine();
                var values = parseCSVLine(line);

                data.Add(values.ToList());
            }

            sr.Close();
            return data;
        }

        private void printRowData_rowbased(List<List<string>> data) {
            string str = "";
            foreach(List<string> rowlist in data)
            {
                foreach(string value in rowlist) {
                    str += value + "\t";
                }
                str += "\r\n";
            }
            textBoxCSVViwer.Text = str;
        }
        private void printColumnData_rowbased(List<List<string>> data, int colIdx) {
            string str = "";
            foreach (List<string> rowlist in data)
            {
                foreach (string value in rowlist)
                {
                    if(rowlist[colIdx] == value)
                        str += value + "\t";
                }
                str += "\r\n";
            }
            textBoxCSVViwer.Text = str;
        }
        private void buttonOpenCSV_Click(object sender, EventArgs e)
        {
            List<List<string>> data = MakeRowBasedDataStructure();
            printRowData_rowbased(data);
            //printColumnData_rowbased(data, 0);

            //List<List<string>> data = MakeColumnarDataStructure();
            //printColumnData_columnbased(data, 1);
            //printRowData_columnbased(data);

        }
    }
}
