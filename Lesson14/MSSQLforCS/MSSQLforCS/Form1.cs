using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace MSSQLforCS
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;
        private SqlConnection secsqlConnection = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDBDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.testDBDataSet.Students);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "testDBDataSet.Groups". При необходимости она может быть перемещена или удалена.
            this.groupsTableAdapter.Fill(this.testDBDataSet.Groups);
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            sqlConnection.Open();
            secsqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["MSSQLforCS.Properties.Settings.TestDBConnectionString"].ConnectionString);
            secsqlConnection.Open();
            //if (sqlConnection.State == ConnectionState.Open)
            //    MessageBox.Show("Підключились до БД");
        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.groupsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.testDBDataSet);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(
                            "INSERT INTO Students (Name,LastName,Birthday,Phone,IdGroup) " +
                            $"VALUES (@Name,@LastName,@Birthday,@Phone,@IdGroup)",
                            sqlConnection);
            DateTime date = DateTime.Parse(dateTimePicker2.Text);

            cmd.Parameters.AddWithValue("Name", textBox1.Text);
            cmd.Parameters.AddWithValue("LastName", textBox2.Text);
            cmd.Parameters.AddWithValue("Birthday", $"{date.Month}/{date.Day}/{date.Year}");
            cmd.Parameters.AddWithValue("Phone", textBox3.Text);
            cmd.Parameters.AddWithValue("IdGroup", textBox4.Text);
            //MessageBox.Show(cmd.ExecuteNonQuery().ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(
                textBox5.Text, secsqlConnection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource= ds.Tables[0];
        }
    }
}

