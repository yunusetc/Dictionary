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
    public partial class AddWord : Form
    {
        public AddWord()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-JJH3V9R;Initial Catalog=Dictionary;Integrated Security=True");

        private void AddWord_Load(object sender, EventArgs e)
        {
            
        }

        bool status;

        void same()
        {
            connection.Open();

            SqlCommand cmd = new SqlCommand("select * from wordsTable where English=@p1", connection);
            cmd.Parameters.AddWithValue("@p1", txtEnglish.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                status = false;
            }
            else
            {
                status = true;
            }

            connection.Close();
            
        }



        private void addButton_Click(object sender, EventArgs e)
        {
            same();

            if(status == true)
                {

                connection.Open();

                SqlCommand cmd = new SqlCommand("insert into wordsTable (English,Turkish) values (@p1, @p2)", connection);
                cmd.Parameters.AddWithValue("@p1", txtEnglish.Text);
                cmd.Parameters.AddWithValue("@p2", txtTurkish.Text);
                cmd.ExecuteNonQuery();
                
                    MessageBox.Show("Word Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                connection.Close();

            }

            else
            {
                MessageBox.Show("That word already exists.!", "Unsuccess", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

            txtEnglish.Clear();
            txtTurkish.Clear();

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            this.Hide();
            mm.Show();
        }
    }
}

