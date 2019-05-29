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
    public partial class Statistic : Form
    {
        public Statistic()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-JJH3V9R;Initial Catalog=Dictionary;Integrated Security=True");

        private void Statistic_Load(object sender, EventArgs e)
        {
            connection.Open();//bağlantıyı açmak için

            SqlCommand cmd = new SqlCommand("Select Sum(trueCount) From countTable", connection);//tablodaki sütünların değer toplamları için
           
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                chart1.Series["Correct"].Points.AddXY("Correct", dr[0]);//grafiğin değerlerini girmek için
                
            }
            
            connection.Close();//bağlantıyı kapatmak için

            connection.Open();

            SqlCommand cmdi = new SqlCommand("Select Sum(falseCount) From countTable", connection);
            SqlDataReader dri = cmdi.ExecuteReader();
            while (dri.Read())
            {

                
                chart1.Series["Incorrect"].Points.AddXY("Incorrect", dri[0]);//grafiğin değerlerini girmek için

            }


            connection.Close();

        }
  
        private void backButton_Click_1(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            this.Hide();
            mm.Show();
        }
    }
}
