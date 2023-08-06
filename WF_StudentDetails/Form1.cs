using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_StudentDetails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBinary_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4\Student.dat";
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
                BinaryFormatter formatter = new BinaryFormatter();
                Student student = new Student();
                student.Id = Convert.ToInt32(Stu_Id.Text);
                student.Name = Stu_name.Text;
                student.Percentage = Convert.ToInt32(Stu_Per.Text);
                formatter.Serialize(fileStream, student);
                fileStream.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"D:\DP4\Student.dat";
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryFormatter formatter = new BinaryFormatter();
                Student student = new Student();
                // we done explicit type casting from Object --> Product
                student = (Student)formatter.Deserialize(fileStream);
                Stu_Id.Text = student.Id.ToString();
                Stu_name.Text = student.Name;
                Stu_Per.Text =student.Percentage.ToString();

                fileStream.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
