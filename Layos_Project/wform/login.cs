using Microsoft.Extensions.Configuration;
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

namespace wform
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog = pub_ItemDB; Integrated Security=True;Connect Timeout=60;");

        private void loginBTN_Click(object sender, EventArgs e)
        {

            String Username, Password;
            Username = TxtUsername.Text;
            Password = TxtPass.Text;

            try
            {
                String query = "SELECT * FROM users WHERE Username = '" + TxtUsername.Text + "' AND Password =  '" + TxtPass.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, connection);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if(dt.Rows.Count > 0 )
                {
                    Username = TxtUsername.Text;
                    Password = TxtPass.Text;

                    Form1 form = new Form1();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                connection.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            reg r = new reg();
            r.Show();
            this.Hide();
        }
    }
}
