using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishermanStore
{
    public partial class RegisterPage : Form
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=Matan-Asus\SQLEXPRESS;Initial Catalog=FishermenStore;Integrated Security=True");

        private void txt_confirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegisterPage_Load(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string username, password, confirmPass;
            username = txt_username_register.Text;
            password = txt_password_register.Text;
            confirmPass = txt_confirm.Text;

            // check if password == confirm passwaord 
            // insert data to SQL 
            //  LEARN - realevan SQL queries 
            // beck to login page 

        }
    }
}
