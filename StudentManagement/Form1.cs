using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class Form1 : Form
    {
        private bool loadCompleted_ = false;
        public Form1()
        {
            InitializeComponent();
            InitVariables();
        }

        private void InitVariables()
        { 
            comboBoxStudent2Gender.Items.Clear();
            comboBoxStudent2Gender.Items.Add("여성");
            comboBoxStudent2Gender.Items.Add("남성");

            string[] genderData = { "여성", "남성" };
            comboBoxStudent3Gender.Items.Clear();
            comboBoxStudent3Gender.Items.AddRange(genderData);

        }

        private void buttonLoadStudentInfo_Click(object sender, EventArgs e)
        {
            LoadStudent();
            loadCompleted_ = true;
        }
        private void buttonStudent2Save_Click(object sender, EventArgs e)
        {
            SaveStudent();
        }
        private void buttonStudent3Save_Click(object sender, EventArgs e)
        {
            SaveStudent();
        }

        #region Student 1 Event handlers
        private void buttonStudent1Save_Click(object sender, EventArgs e)
        {
            SaveStudent();
        }
        private void comboBoxStudent1Gender_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  SaveStudent();
        }

        private void textBoxStudent1ID_TextChanged(object sender, EventArgs e)
        {
           // SaveStudent();
        }

        private void textBoxStudent1Name_TextChanged(object sender, EventArgs e)
        {
         //   SaveStudent();
        }
        #endregion

        private void LoadStudent()
        {
            Stream rs = new FileStream("student.bin", FileMode.Open);
            BinaryFormatter deserializer = new BinaryFormatter();

            StudentInfo studentInfo = (StudentInfo)deserializer.Deserialize(rs);

            rs.Close();

            textBoxStudent1Name.Text = studentInfo.name;
            textBoxStudent1ID.Text = studentInfo.sid;
            comboBoxStudent1Gender.Text = studentInfo.gender;
        
        }

        private void SaveStudent()
        {
         //   if (loadCompleted_ == false)
           //     return;

            StudentInfo studentInfo = new StudentInfo();

            studentInfo.name = textBoxStudent1Name.Text;
            studentInfo.gender = comboBoxStudent1Gender.Text;
            studentInfo.sid = textBoxStudent1ID.Text;

            Stream ws = new FileStream("student.bin", FileMode.Create);
            BinaryFormatter serializer = new BinaryFormatter();

            serializer.Serialize(ws, studentInfo);
            ws.Close();

            /*
            BinaryWriter bw = new BinaryWriter(new FileStream("student.bin", FileMode.Create));
            
            bw.Write(textBoxStudent1Name.Text);
            bw.Write(textBoxStudent1ID.Text);
            bw.Write(comboBoxStudent1Gender.Text);

            bw.Write(textBoxStudent2Name.Text);
            bw.Write(textBoxStudent2ID.Text);
            bw.Write(comboBoxStudent2Gender.Text);
            
            bw.Write(textBoxStudent3Name.Text);
            bw.Write(textBoxStudent3ID.Text);
            bw.Write(comboBoxStudent3Gender.Text);

            bw.Close();
            */

        }
    }
}