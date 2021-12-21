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
    public partial class Form1 : Form
    {
        string constr = @"Data Source=DESKTOP-44K3CQ8\SQLEXPRESS;Initial Catalog=b1;Integrated Security=True";
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public Form1()
        {
            Form7 f7 = new Form7();
            f7.ShowDialog();
            InitializeComponent();
            con.ConnectionString = constr;
            cmd.Connection = con;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "b1DataSet1.Статус". При необходимости она может быть перемещена или удалена.
            this.статусTableAdapter.Fill(this.b1DataSet1.Статус);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "b1DataSet.Перевозки". При необходимости она может быть перемещена или удалена.
            this.перевозкиTableAdapter.Fill(this.b1DataSet.Перевозки);

        }

        private void button1_Click(object sender, EventArgs e)
        {
                Form2 f2 = new Form2();
                f2.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constr = @"Data Source=DESKTOP-44K3CQ8\SQLEXPRESS;Initial Catalog=b1;Integrated Security=True";
            DataSet ds = new DataSet();
            string sql = "SELECT Перевозки.ID_перевозки, Бригады.ФИО_бригадира, Грузы.Груз, Грузовики.Номер_грузовика, [Населенный пункт].[Населенный пункт], Перевозки.Дата_поставки, Перевозки.Срочность, Перевозки.Предоплата_процент FROM Перевозки JOIN Бригады on Бригады.ID_бригады = Перевозки.Бригада JOIN Грузы on Грузы.ID_груза = Перевозки.Груз JOIN Грузовики on Грузовики.ID_грузовика = Перевозки.Грузовик JOIN[Населенный пункт] on[Населенный пункт].ID_наспункта = Перевозки.Населенный_пункт";
            SqlConnection con = new SqlConnection(constr);
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            ad.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "DELETE from Перевозки where [ID_перевозки] = " + dataGridView1.CurrentRow.Cells[0].Value;
            string constr = @"Data Source=DESKTOP-44K3CQ8\SQLEXPRESS;Initial Catalog=b1;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                sql = "SELECT * From Перевозки";
                cmd.ExecuteNonQuery();
                DataSet ds = new DataSet();
                SqlDataAdapter ad = new SqlDataAdapter(sql, constr);
                ad.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
                        dataGridView1.Rows[i].Selected = false;
                    }

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        

        private void перевозкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            string connecionString = @"Data Source=DESKTOP-44K3CQ8\SQLEXPRESS;Initial Catalog=b1;Integrated Security=True";
            //string sql = "SELECT  * from Перевозки";
            string sql = "SELECT Перевозки.ID_перевозки, Бригады.ФИО_бригадира, Грузы.Груз, Грузовики.Номер_грузовика, [Населенный пункт].[Населенный пункт], Перевозки.Дата_поставки, Перевозки.Срочность, Перевозки.Предоплата_процент FROM Перевозки JOIN Бригады on Бригады.ID_бригады = Перевозки.Бригада JOIN Грузы on Грузы.ID_груза = Перевозки.Груз JOIN Грузовики on Грузовики.ID_грузовика = Перевозки.Грузовик JOIN[Населенный пункт] on[Населенный пункт].ID_наспункта = Перевозки.Населенный_пункт";
            ;
            using (SqlConnection connection = new SqlConnection(connecionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void бригадыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
            string connecionString = @"Data Source=DESKTOP-44K3CQ8\SQLEXPRESS;Initial Catalog=b1;Integrated Security=True";
            string sql = "SELECT * FROM Бригады";
            using (SqlConnection connection = new SqlConnection(connecionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void грузыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            string connecionString = @"Data Source=DESKTOP-44K3CQ8\SQLEXPRESS;Initial Catalog=b1;Integrated Security=True";
            string sql = "SELECT * FROM Грузы";
            using (SqlConnection connection = new SqlConnection(connecionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string constring = @"Data Source=DESKTOP-44K3CQ8\SQLEXPRESS;Initial Catalog=b1;Integrated Security=True";
            string sql = "SELECT * from Перевозки where Срочность like N'%" + textBox2.Text + "%'";
            using (SqlConnection connection = new SqlConnection(constring))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void грузовикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            string connecionString = @"Data Source=DESKTOP-44K3CQ8\SQLEXPRESS;Initial Catalog=b1;Integrated Security=True";
            string sql = "SELECT * FROM Грузовики";
            using (SqlConnection connection = new SqlConnection(connecionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void наспунктыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            string connecionString = @"Data Source=DESKTOP-44K3CQ8\SQLEXPRESS;Initial Catalog=b1;Integrated Security=True";
            string sql = "SELECT * FROM [Населенный пункт]";
            using (SqlConnection connection = new SqlConnection(connecionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
        }
    }
}
