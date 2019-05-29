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
    public partial class Learn : Form
    {
        public Learn()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-JJH3V9R;Initial Catalog=Dictionary;Integrated Security=True");

        public void refresh()//kelime çekme için kullanılan fonksiyon
        {

            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 English,Turkish FROM wordsTable ORDER BY NEWID()", connection);//rastgele kelime çekmek için
            cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                englishLabel.Text = dr["English"].ToString();
                turkishLabel.Text = dr["Turkish"].ToString();
            }
            else
            {
                MessageBox.Show("Error","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }




            connection.Close();

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            this.Hide();
            mm.Show();
        }
        
        private void saveButton_Click(object sender, EventArgs e)//öğrenilen kelimeleri havuza eklemek için
        {

            connection.Open();

            SqlCommand cmd = new SqlCommand("insert into learnTable (English,Turkish,Date) values (@p1, @p2, @p3)", connection);
            cmd.Parameters.AddWithValue("@p1", englishLabel.Text);
            cmd.Parameters.AddWithValue("@p2", turkishLabel.Text);
            cmd.Parameters.AddWithValue("@P3", DateTime.Now);
            object check = null;
            check = cmd.ExecuteNonQuery();

            if (check != null)
                MessageBox.Show("Word Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Word Not Added!", "Unsuccess", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            connection.Close();

            refresh();

        }

        private void knowButton_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void Learn_Load(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
