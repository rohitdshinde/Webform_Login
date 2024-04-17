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

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection con=new SqlConnection("Data Source=DESKTOP-FF8E3E6\\SQLEXPRESS;Initial Catalog=userregcs;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[register]
           ([firstname]
           ,[lastname]
           ,[address]
           ,[gender]
           ,[email]
           ,[phone]
           ,[username]
           ,[password])
     VALUES
           ('" + textFname.Text + "','" + textLname.Text + "','" + textAdd.Text + "','" + comGender.SelectedItem.ToString() + "','" + textEmail.Text + "','" + textPhone.Text + "','" + textUser.Text + "','" + textPass.Text + "')",con);
             con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("REgister successfully");
        }
    }
}
