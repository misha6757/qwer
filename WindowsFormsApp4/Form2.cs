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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bazaDataSet1.sklad". При необходимости она может быть перемещена или удалена.
            this.skladTableAdapter.Fill(this.bazaDataSet1.sklad);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idK = "";
            string FIO = "";
           
            string sum = "";
            idK = Convert.ToString(textBox1.Text);
            FIO = Convert.ToString(textBox2.Text);
           
            sum = "('" + idK + "', '" + FIO + "')";
            skladTableAdapter.Connection.Open();
            OleDbCommand command = skladTableAdapter.Connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "INSERT INTO sklad (idsklad, mesto) VALUES " + sum;
            command.ExecuteNonQuery();
            skladTableAdapter.Connection.Close();
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:\Users\АМС\source\repos\WindowsFormsApp4\WindowsFormsApp4\baza.mdb;Persist Security Info=False");
            conn.Open();
            command.Connection = conn;
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("склад добавлен");
            skladTableAdapter.Update(bazaDataSet1.sklad);
            skladTableAdapter.Fill(bazaDataSet1.sklad);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idK;
            idK = Convert.ToInt32(comboBox1.SelectedValue.ToString());
            skladTableAdapter.Connection.Open();
            OleDbCommand command = skladTableAdapter.Connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM sklad WHERE idsklad = " + idK;
            command.ExecuteNonQuery();
            skladTableAdapter.Connection.Close();
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:\Users\АМС\source\repos\WindowsFormsApp4\WindowsFormsApp4\baza.mdb;Persist Security Info=False");
            conn.Open();
            command.Connection = conn;
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM sklad WHERE idsklad = " + idK;
            command.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("склад удален");
            skladTableAdapter.Update(bazaDataSet1.sklad);
            skladTableAdapter.Fill(bazaDataSet1.sklad);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void поставщикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
        }

        private void товарToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
        }
    }
}
