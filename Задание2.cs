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

namespace IS_2_19_KalinichenkoPV
{
    public partial class Задание2 : Form
    {
        public Задание2()
        {
            InitializeComponent();
        }
        static class VozraT
        {
            public static string GetDVozraT()
            {
                string host = "caseum.ru";
                string port = "33333";
                string database = "db_test";
                string username = "test_user";
                string password = "test_pass";
                string connString = $"server={host};port={port};user={username};database={database};password={password};";
                return connString;
            }
        }
        MySqlConnection conn = new MySqlConnection(VozraT.GetDVozraT());
        private void button1_Click(object sender, EventArgs e)
        {
            
                try
                {
                    conn.Open();
                    MessageBox.Show("Подключение");
                    conn.Close();
                }
                catch (Exception osh)
                {
                    MessageBox.Show("Произошла ошибка" + osh);
                    conn.Close();
                }
            
        }

        private void Задание2_Load(object sender, EventArgs e)
        {

        }
    }
}
