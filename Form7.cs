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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = "adm";
            string password = "123";
            if (textBox1.Text == login && textBox2.Text == password)
            {
                MessageBox.Show("Добро пожаловать");
                this.Close();
            }
            else
            {
                MessageBox.Show("НЕТ");
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
