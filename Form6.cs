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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connecionString = @"Data Source=DESKTOP-44K3CQ8\SQLEXPRESS;Initial Catalog=b1;Integrated Security=True";
            string sql = "Insert into [Адреса] ([ID_Перевозки], [Адрес]) Values (N'" + textBox1.Text + "',N'" + textBox2.Text + "')";
            using (SqlConnection connection = new SqlConnection(connecionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

            }
            MessageBox.Show("Запись добавлена", "Добавлено");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "b1DataSet2.Адреса". При необходимости она может быть перемещена или удалена.
            this.адресаTableAdapter.Fill(this.b1DataSet2.Адреса);

        }
    }
    }

