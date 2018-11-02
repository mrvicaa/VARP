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

namespace VARP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Clear();
            txtUserName.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=VARP;Integrated Security=True");// "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ilija\source\repos\VARP\VARP\VARP.accdb"
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT *
                FROM [VARP].[dbo].[Login] Where UserName='"+txtUserName.Text+" ' and Password = '"+ txtPassword.Text+"'", con);
 
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                MainPage mainPage = new MainPage();
                mainPage.Show();
            }
            else {
               // LoginError loginError = new LoginError();
                //    loginError.Show();
                MessageBox.Show("Invalid Username & Password!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button1_Click(sender, e);
            }
            
        }

       
    }
}
