using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; // IV added for reading Data Base
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VARP
{
    public partial class RollingMill : Form
    {
        public RollingMill()
        {
            InitializeComponent();
        }

        private void RollingMill_Load(object sender, EventArgs e)
        {
            comboProductStatus.SelectedIndex = 1;
            LoadData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }            
        private bool IfProductExist(SqlConnection con, string productCode)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * From [VARP].[dbo].[Products] WHERE [ProductCode] = '" + productCode +"' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            return Convert.ToBoolean (dt.Rows.Count);
        }
        private void addProduct_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=VARP;Integrated Security=True");
            //IV Insert Logic
            con.Open();
            bool status = !Convert.ToBoolean( comboProductStatus.SelectedIndex); // 1 = Active; 0-Deactive
            var sqlQuery = "";

            if (IfProductExist(con, txtProcuctCode.Text)) {
                sqlQuery = @"UPDATE [Products] SET [ProductName] = '" + txtProductName.Text + "', [ProductStatus] ='" + status + "' WHERE [ProductCode] = '" + txtProcuctCode.Text + "'";
            
            } else {
                sqlQuery = @"INSERT INTO [VARP].[dbo].[Products]([ProductCode],[ProductName],[ProductStatus])
            VALUES
           ('" + txtProcuctCode.Text + "', '" + txtProductName.Text + "','" + status + "')";



            }
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();

            //IV Reading Data SQL
            LoadData();
        }

        private void productDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=VARP;Integrated Security=True");
            var sqlQuery = "";

            if (IfProductExist(con, txtProcuctCode.Text))
            {
                con.Open();
                sqlQuery = @"DELETE FROM [Products] WHERE [ProductCode] = '" + txtProcuctCode.Text + "'";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                cmd.ExecuteNonQuery();
                con.Close();
                txtProcuctCode.Text = "";
                txtProductName.Text = "";
                comboProductStatus.SelectedIndex = 1;
            }
            else
            {
                MessageBox.Show("Record Not Exist...");
            }
            
            LoadData();

        }
        private void LoadData()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=VARP;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select * From [VARP].[dbo].[Products]", con);
            DataTable dt = new DataTable();
            dataGridView1.Rows.Clear();
            sda.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["ProductCode"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["ProductName"].ToString();
                if ((bool)item["ProductStatus"])
                {
                    dataGridView1.Rows[n].Cells[2].Value = "Active";
                }
                else
                {
                    dataGridView1.Rows[n].Cells[2].Value = "Deactive";
                }

            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtProcuctCode.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtProductName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            if (dataGridView1.SelectedRows[0].Cells[2].Value.ToString() == "Active")
            {
                comboProductStatus.SelectedIndex = 0;
            }
            else
            {
                comboProductStatus.SelectedIndex = 1;
            }

             
        }

        
    }
}
