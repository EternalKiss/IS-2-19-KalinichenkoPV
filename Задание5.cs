using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ConnectDB;

namespace IS_2_19_KalinichenkoPV
{
    public partial class Задание5 : Form
    {
        public Задание5()
        {
            InitializeComponent();
        }

        private void Задание5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chert conn = new Chert();
            MySqlConnection connn = new MySqlConnection(conn.chertila);
            string fio = textBox1.Text;
            string vremia = textBox2.Text;
            string sql = $"INSERT INTO t_PraktStud (fioStud, datetimeStud)  VALUES ('{fio}','{vremia}');";
            int ny = 0;
            try
            {
                connn.Open();
                MySqlCommand command1 = new MySqlCommand(sql, connn);
                ny = command1.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("не не брат не то");
            }
            finally
            {
                connn.Close();
                if (ny != 0)
                {
                    MessageBox.Show("да брат то");
                }
            }
        }
    }
}
