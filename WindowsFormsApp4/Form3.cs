using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
namespace WindowsFormsApp4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bazaDataSet1.post". При необходимости она может быть перемещена или удалена.
            this.postTableAdapter.Fill(this.bazaDataSet1.post);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idK = "";
            string FIO = "";

            string sum = "";
            idK = Convert.ToString(textBox1.Text);
            FIO = Convert.ToString(textBox2.Text);

            sum = "('" + idK + "', '" + FIO + "')";
            postTableAdapter.Connection.Open();
            OleDbCommand command = postTableAdapter.Connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO post (idpost, name) VALUES " + sum;
            command.ExecuteNonQuery();
            postTableAdapter.Connection.Close();
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:\Users\АМС\source\repos\WindowsFormsApp4\WindowsFormsApp4\baza.mdb;Persist Security Info=False");
            conn.Open();
            command.Connection = conn;
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("поставщик добавлен");
            postTableAdapter.Update(bazaDataSet1.post);
            postTableAdapter.Fill(bazaDataSet1.post);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idK;
            idK = Convert.ToInt32(comboBox1.SelectedValue.ToString());
            postTableAdapter.Connection.Open();
            OleDbCommand command = postTableAdapter.Connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM post WHERE idpost = " + idK;
            command.ExecuteNonQuery();
            postTableAdapter.Connection.Close();
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:\Users\АМС\source\repos\WindowsFormsApp4\WindowsFormsApp4\baza.mdb;Persist Security Info=False");
            conn.Open();
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM post WHERE idpost = " + idK;
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("поставщик удален");
            postTableAdapter.Update(bazaDataSet1.post);
            postTableAdapter.Fill(bazaDataSet1.post);
        }
    }
}
