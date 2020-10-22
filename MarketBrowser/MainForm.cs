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

        Dictionary<string, int> headerIndexDict = new Dictionary<string, int>();

        private void SetHeaderList(string header)
        {
            var values = parseCSVLine(header);
            // foreach (string value in values)
            //   listBoxHeaders.Items.Add(value);

            listBoxHeaders.Items.Clear();
            listBoxHeaders.Items.AddRange(values);

            for(int i=0; i<values.Length; i++)
            {
                string column = values[i];
                listBoxHeaders.Items.Add(column);
                headerIndexDict[column] = i;

            }
        }
        private List<List<string>> MakeRowBasedDataStructure(string filename)
        {
            StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open), Encoding.Default);


            var line = sr.ReadLine();
            SetHeaderList(line);

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

        private void printRowData_rowbased(List<List<string>> data, TextBox textbox) {
            string str = "";
            foreach(List<string> rowlist in data)
            {
                foreach(string value in rowlist) {
                    str += value + "\t";
                }
                str += "\r\n";
            }
            textbox.Text = str;
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

        List<List<string>> data;
        private void buttonOpenCSV_Click(object sender, EventArgs e)
        {
            var FD = new OpenFileDialog();
            DialogResult dResult = FD.ShowDialog();

            if (dResult == DialogResult.OK)
            {
                string filename = FD.FileName;
                MessageBox.Show(filename, "확인");

                data = MakeRowBasedDataStructure(filename);
                printRowData_rowbased(data, textBoxCSVViwer);
            }

            /*
            List<List<string>> data = MakeRowBasedDataStructure();
            printRowData_rowbased(data);
            //printColumnData_rowbased(data, 0);

            //List<List<string>> data = MakeColumnarDataStructure();
            //printColumnData_columnbased(data, 1);
            //printRowData_columnbased(data);
            */
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string keyword = textBoxSearchKeyword.Text;

            if (keyword == "")
            {
                MessageBox.Show("검색 키워드를 입력하세요.", "확인");
                return;
            }

            if(listBoxHeaders.SelectedItem == null)
            {
                MessageBox.Show("검색대상 컬럼을 선택하세요.", "확인");
                return;
            }
            string column = listBoxHeaders.SelectedItem.ToString();
            if (column == "")
            {
                MessageBox.Show("검색대상 컬럼을 선택하세요.", "확인");
                return;
            }

            MessageBox.Show("키워드 = " + keyword + " 컬럼 = " + column, "확인");

            DoSearch(keyword, column);
        }

        private void DoSearch(string keyword, string column)
        {
            // 대상 컬럼 확인
            // int targetColumnIndex = listBoxHeaders.SelectedIndex;
            if(headerIndexDict.ContainsKey(column) == false)
            {
                MessageBox.Show("검색대상 컬럼을 선택하세요.", "확인");
                return;
            }

            int targetColumnIndex = headerIndexDict[column];

            // 대상 컬럼에서 키워드를 포함하는지 확인
            List<List<string>> resultData = new List<List<string>>();
            foreach(List<string>row in data)
            {
                string value = row[targetColumnIndex];
                if (value.Contains(keyword))
                {
                    resultData.Add(row);
                }
            }

            printRowData_rowbased(resultData, textBoxSearchResult);

        }

    }
}
