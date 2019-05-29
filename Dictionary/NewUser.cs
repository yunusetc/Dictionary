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

namespace Dictionary
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-JJH3V9R;Initial Catalog=Dictionary;Integrated Security=True");

        private void backButton_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();

        }

        bool status;

        void same()
        {
            connection.Open();

            SqlCommand cmd = new SqlCommand("select * from loginTable where Username=@p1", connection);
            cmd.Parameters.AddWithValue("@p1", usernameTextBox.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                status = false;
            }
            else
            {
                status = true;
            }

            connection.Close();

        }

        private void registerButton_Click(object sender, EventArgs e)
        {

            same();

            if (status == true)
            {

                connection.Open();

                SqlCommand cmd = new SqlCommand("insert into loginTable (Username, Password) values (@p1, @p2)", connection);
                cmd.Parameters.AddWithValue("@p1", usernameTextBox.Text);
                cmd.Parameters.AddWithValue("@p2", passwordTextBox.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("User Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                connection.Close();

            }

            else
            {
                MessageBox.Show("That user already exists!", "Unsuccess", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void NewUser_Load(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.MaxLength = 8;
        }
    }
}
