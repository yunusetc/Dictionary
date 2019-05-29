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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-JJH3V9R;Initial Catalog=Dictionary;Integrated Security=True");
        
        private void passwordTextBox_TextChanged(object sender, EventArgs e)//password için gerekli kurallar
        {
            
            passwordTextBox.MaxLength = 8;
            passwordTextBox.PasswordChar = '*';
        }


        private void loginButton_Click(object sender, EventArgs e)//giriş butonu 
        {

            connection.Open();//bağlantı başlatmak için

            SqlCommand cmd = new SqlCommand("Select * From loginTable where Username=@p1 and Password=@p2", connection);
            cmd.Parameters.AddWithValue("@p1", usernameTextBox.Text);
            cmd.Parameters.AddWithValue("@p2", passwordTextBox.Text);
            SqlDataReader dr = cmd.ExecuteReader();

            if(dr.Read())
            {
                this.Hide();
                MainMenu mm = new MainMenu();
                mm.Show();

            }
            else
            {
                MessageBox.Show("Username or password is incorrect!", "Incorrect entry.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();//bağlantı kapatmak için

        }

        private void newUserButton_Click(object sender, EventArgs e)
        {

            NewUser nu = new NewUser();
            this.Hide();
            nu.Show();

        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)//hakkımızda kısmı
        {
            MessageBox.Show("This site was made by Yunus Emre Etcibaşı !", "İnformation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

