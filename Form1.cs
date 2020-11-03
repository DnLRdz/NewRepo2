using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mysql.Data.MysqlClient;


namespace mylogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        
            string connect = "datasource=localhost;port=33068;username=Dnlpq66;password=irhN3e0c1Tzu;database=tabla";
            string query = "select * from login where user = '" + usertxtBox.Text + "' AND password = '" + pswtxtBox.Text + "'";
            MySqlConnection databaseConnection = new MySqlConnection(connect);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.Executereader();
                if (reader.Read())
                {
                    MessageBox.Show("Bienvenido al Sistema");
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta");
                }

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void UsuariotxtBox_textChanged(Object sender, EventArgs e)
        {

        }
    }
}
