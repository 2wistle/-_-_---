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
    public partial class Form3 : Form
    {
        string constr = @"Data Source=DESKTOP-44K3CQ8\SQLEXPRESS;Initial Catalog=b1;Integrated Security=True";
        SqlConnection cod = new SqlConnection();
        SqlCommand cmt = new SqlCommand();
        int ID;
        public Form3()
        {
            InitializeComponent();
            
            cod.ConnectionString = constr;
            cmt.Connection = cod;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cod.Open();
            cmt.CommandText = "update [Перевозки] set Бригада = '" + textBox1.Text + "', Груз = '" + textBox2.Text + "', Грузовик = '" + textBox3.Text + "', Населенный_пункт = '" + textBox4.Text + "', Дата_поставки = '" + textBox5.Text + "', Срочность = '" + textBox6.Text + "', Предоплата_процент = '" + textBox7.Text + "' where [ID_перевозки]= " + ID;
            cmt.ExecuteNonQuery();
            cod.Close();
            MessageBox.Show("Измененно");
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
