using MySql.Data.MySqlClient;
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
        string strConn = "Server=49.50.174.201;Database=s5416212;Uid=s5416212;Pwd=s5416212;Charset=utf8";

        public Form1()
        {
            InitializeComponent();
            InitVariables();
        }

        private void InitVariables()
        {
            string[] genderData = { "Woman", "Man" };
            comboBoxStudent1Gender.Items.Clear();
            comboBoxStudent1Gender.Items.AddRange(genderData);
            comboBoxStudent2Gender.Items.Clear();
            comboBoxStudent2Gender.Items.AddRange(genderData);
            comboBoxStudent3Gender.Items.Clear();
            comboBoxStudent3Gender.Items.AddRange(genderData);
        }

        private void buttonLoadStudentInfo_Click(object sender, EventArgs e)
        {
            LoadStudent();
            loadCompleted_ = true;
        }
        

        #region Student Event handlers
        private void buttonStudent1Save_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("INSERT INTO student_info (num_student, name_student, id_student, gender_student)"
                    + "VALUES (1, '" + textBoxStudent1Name.Text + "', '" + textBoxStudent1ID.Text + "', '" + comboBoxStudent1Gender.Text + "')", conn);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    cmd = new MySqlCommand("UPDATE student_info SET name_student='" + textBoxStudent1Name.Text + "',"
                        + "id_student='" + textBoxStudent1ID.Text + "', gender_student='" + comboBoxStudent1Gender.Text + "' WHERE num_student = 1", conn);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        private void buttonStudent2Save_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("INSERT INTO student_info (num_student, name_student, id_student, gender_student) VALUES (2, '" + textBoxStudent2Name.Text + "', '" + textBoxStudent2ID.Text + "', '" + comboBoxStudent2Gender.Text + "')", conn);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    cmd = new MySqlCommand("UPDATE student_info SET name_student='" + textBoxStudent2Name.Text + "', id_student='" + textBoxStudent2ID.Text + "', gender_student='" + comboBoxStudent2Gender.Text + "' WHERE num_student = 2", conn);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }
        private void buttonStudent3Save_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("INSERT INTO student_info (num_student, name_student, id_student, gender_student) VALUES (3, '" + textBoxStudent3Name.Text + "', '" + textBoxStudent3ID.Text + "', '" + comboBoxStudent3Gender.Text + "')", conn);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    cmd = new MySqlCommand("UPDATE student_info SET name_student='" + textBoxStudent3Name.Text + "', id_student='" + textBoxStudent3ID.Text + "', gender_student='" + comboBoxStudent3Gender.Text + "' WHERE num_student = 3", conn);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }

        #endregion

        private void LoadStudent()
        {
            using (MySqlConnection conn = new MySqlConnection(strConn))
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM student_info ORDER BY num_student", conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                
                int i = 0;
                while (rdr.Read())
                {
                    if (rdr.GetString(3) == "1") // 학생 1 정보 출력
                    {   
                        textBoxStudent1Name.Text = rdr.GetString(0);
                        textBoxStudent1ID.Text = rdr.GetString(1);
                        comboBoxStudent1Gender.Text = rdr.GetString(2);
                    }
                    else if (rdr.GetString(3) == "2") // 학생 2 정보 출력
                    {
                        textBoxStudent2Name.Text = rdr.GetString(0);
                        textBoxStudent2ID.Text = rdr.GetString(1);
                        comboBoxStudent2Gender.Text = rdr.GetString(2);
                    }
                    else if (rdr.GetString(3) == "3") // 학생 3 정보 출력
                    {
                        textBoxStudent3Name.Text = rdr.GetString(0);
                        textBoxStudent3ID.Text = rdr.GetString(1);
                        comboBoxStudent3Gender.Text = rdr.GetString(2);
                    }
                    i++;
                }

                rdr.Close();
            }
        }
    }
}