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

namespace FishermanStore
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=Matan-Asus\SQLEXPRESS;Initial Catalog=FishermenStore;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string username, password;

            // txt_name - name of text box
            username = txt_username.Text;
            password = txt_password.Text;

            try
            {
                /* 
                 sql query to find the use in DB 
                FROM - table in DB (name in Data connections)
                WHERE - mention the fields of table (name in Data connections)
                +NAME.TEXT+ - name of text box in page  
                 */
                string querry = "SELECT * FROM UsersFishermenStore WHERE username = '" + txt_username.Text + "' AND password = '" + txt_password.Text + "'";
                /*
                 conn - connection variable , set uper 
                querry - query of data in table 
                so now, sda - results of query 
                 */
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = txt_username.Text;
                    password = txt_password.Text;

                    // page that needed to be load next 
                    StoreP1 storeP1 = new StoreP1();
                    storeP1.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                    txt_username.Clear();
                    txt_password.Clear();

                    // focuse on username 
                    txt_username.Focus();

                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }


        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }
    }
}
