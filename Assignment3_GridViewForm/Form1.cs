using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeWindowsForm
{
    public partial class Form1 : Form
    {
        private List<Student> lstStudent = new List<Student>();
        Student objStudent = new Student();
        DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataColumn colName = new DataColumn("Name", typeof(string));
            dt.Columns.Add(colName);
            DataColumn colEmailID = new DataColumn("EmailID", typeof(string));
            dt.Columns.Add(colEmailID);
            DataColumn colEducation = new DataColumn("Education", typeof(string));
            dt.Columns.Add(colEducation);
            DataColumn colBranch = new DataColumn("Branch", typeof(string));
            dt.Columns.Add(colBranch);
            DataColumn colMobileNumber = new DataColumn("MobileNumber", typeof(string));
            dt.Columns.Add(colMobileNumber);
            DataColumn colLanguages = new DataColumn("Languages", typeof(string));
            dt.Columns.Add(colLanguages);
            DataColumn colWebDevelopment = new DataColumn("Web Development", typeof(string));
            dt.Columns.Add(colWebDevelopment);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            GridStudent.DataSource = null;
            GridStudent.Refresh();
            GridStudent.DataSource = dt;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            objStudent.Name = textName.Text;
            objStudent.EmailID = textEmailID.Text;
            objStudent.Education = textEducation.Text;
            objStudent.Branch = textBranch.Text;
            objStudent.MobileNumber = textMobileNumber.Text;

            DataRow row = dt.NewRow();
            row["Name"] = textName.Text;
            row["EmailID"] = textEmailID.Text;
            row["Education"] = textEducation;
            row["Branch"] = textBranch.Text;
            row["MobileNumber"] = textMobileNumber.Text;
            dt.Rows.Add(row);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            objStudent.Languages = textLanguages.Text;
            objStudent.WebDevelopment = textWebDevelopment.Text;
            DataRow row = dt.NewRow();
            row["Languages"] = textLanguages.Text;
            row["Web Development"] = textWebDevelopment.Text;
            dt.Rows.Add(row);
        }
    }
}
