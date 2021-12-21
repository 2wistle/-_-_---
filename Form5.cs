using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ppsat
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connecionString = @"Data Source=DESKTOP-44K3CQ8\SQLEXPRESS;Initial Catalog=b1;Integrated Security=True";
            string sql = "Insert into [Статус] ([ID], [Статус]) Values (N'" + textBox1.Text + "',N'" + textBox2.Text + "')";
            using (SqlConnection connection = new SqlConnection(connecionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

            }
            MessageBox.Show("Запись добавлена", "Добавлено");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
