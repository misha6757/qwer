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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bazaDataSet1.komp". При необходимости она может быть перемещена или удалена.
            this.kompTableAdapter.Fill(this.bazaDataSet1.komp);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idK = "";
            string FIO = "";
            string adress = "";
            string phone = "";
            string sum = "";
            idK = Convert.ToString(textBox1.Text);
            FIO = Convert.ToString(textBox2.Text);
            adress = Convert.ToString(textBox3.Text);
            phone = Convert.ToString(textBox4.Text);
            sum = "('" + idK + "', '" + FIO + "', '" + adress + "', '" + phone + "')";
            kompTableAdapter.Connection.Open();
            OleDbCommand command = kompTableAdapter.Connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO komp (idkomp, tovar, opisanie, chena) VALUES " + sum;
            command.ExecuteNonQuery();
            kompTableAdapter.Connection.Close();
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:\Users\АМС\source\repos\WindowsFormsApp4\WindowsFormsApp4\baza.mdb;Persist Security Info=False");
            conn.Open();
            command.Connection = conn;
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Товар добавлен");
            kompTableAdapter.Update(bazaDataSet1.komp);
            kompTableAdapter.Fill(bazaDataSet1.komp);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idK;
            idK = Convert.ToInt32(comboBox1.SelectedValue.ToString());
            kompTableAdapter.Connection.Open();
            OleDbCommand command = kompTableAdapter.Connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM komp WHERE idkomp = " + idK;
            command.ExecuteNonQuery();
            kompTableAdapter.Connection.Close();
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:\Users\АМС\source\repos\WindowsFormsApp4\WindowsFormsApp4\baza.mdb;Persist Security Info=False");
            conn.Open();
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM komp WHERE idkomp = " + idK;
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Товар удален");
            kompTableAdapter.Update(bazaDataSet1.komp);
            kompTableAdapter.Fill(bazaDataSet1.komp);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;
           Data Source=C:\Users\АМС\source\repos\WindowsFormsApp4\WindowsFormsApp4\baza.mdb;Persist Security Info=False");
            conn.Open();
            OleDbDataAdapter zapros = new
                OleDbDataAdapter("SELECT * FROM komp ORDER BY [komp.chena] ASC", conn);
            OleDbCommand command = new
                OleDbCommand("SELECT * FROM komp ORDER BY [komp.chena] ASC", conn);
            zapros.SelectCommand = command;
            DataTable DTzap = new DataTable();
            zapros.Fill(DTzap);
            BindingSource BSzap = new BindingSource();
            BSzap.DataSource = DTzap;
            dataGridView1.DataSource = BSzap;
            //dataGridView1.Columns[0].HeaderCell.Value = "Количество по убыванию";
            conn.Close();
            // MessageBox.Show("товар добавлен");
        }

        private void поставщикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
        }

        private void складToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }
    }
}
