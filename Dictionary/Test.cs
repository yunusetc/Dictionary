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
using System.Timers;

namespace Dictionary
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-JJH3V9R;Initial Catalog=Dictionary;Integrated Security=True");

        int corCount = 0;
        int incorCount = 0;
        int second = 16;

        private void answer()//cevapların kontrolu için fonksiyon
        {

            if (engtrRadioButton.Checked == true)// sözlük türü için
            {

                if (answerTextBox.Text == correctLabel.Text)//cevap kontrolu
                {
                    connection.Open();
                    
                    
                    timer.Enabled = true;//zamanlayıcı başlatmak için

                    corCount++;//doğru cevap puan sayacı
                    correctCountLabel.Text = corCount.ToString();
                    SqlCommand cmd = new SqlCommand("SELECT TOP 1 English, Turkish FROM wordsTable ORDER BY NEWID()", connection);//rastgele kelime çekmik için
                    cmd.ExecuteNonQuery();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                        questionLabel.Text = (dr["English"].ToString());
                        correctLabel.Text = (dr["Turkish"].ToString());
                    }
                    
                    connection.Close();
                    
                    answerTextBox.Text = "";
                    second = 16;
                }
                else
                {
                    incorCount++;//yanlış cevap puan sayacı
                    incorrectCountLabel.Text = incorCount.ToString();

                    answerTextBox.Text = "";
                    
                }
            }

            else if(trengRadioButton.Checked == true)
            {

                if (answerTextBox.Text == correctLabel.Text)
                {
                    connection.Open();

                    
                    timer.Enabled = true;

                    corCount++;
                    correctCountLabel.Text = corCount.ToString();
                    SqlCommand cmd = new SqlCommand("SELECT TOP 1 Turkish, English FROM wordsTable ORDER BY NEWID()", connection);
                    cmd.ExecuteNonQuery();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                        questionLabel.Text = (dr["Turkish"].ToString());
                        correctLabel.Text = (dr["English"].ToString());
                    }
                    connection.Close();

                    answerTextBox.Text = "";
                    second = 16;
                }

                else
                {
                    incorCount++;
                    incorrectCountLabel.Text = incorCount.ToString();

                    answerTextBox.Text = "";
                    

                }

            }

            else
            {

                MessageBox.Show("Please Select Dictionary Type!");

            }

        }

        private void answerTime()//sayac süresi bitiminde oluşacak durumlar için
        {

            if (engtrRadioButton.Checked == true)
            {

                if (answerTextBox.Text == correctLabel.Text)
                {
                    connection.Open();


                    timer.Enabled = true;

                    corCount++;
                    correctCountLabel.Text = corCount.ToString();
                    SqlCommand cmd = new SqlCommand("SELECT TOP 1 English, Turkish FROM wordsTable ORDER BY NEWID()", connection);//rastgele kelime için
                    cmd.ExecuteNonQuery();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                        questionLabel.Text = (dr["English"].ToString());
                        correctLabel.Text = (dr["Turkish"].ToString());
                    }

                    connection.Close();

                    answerTextBox.Text = "";
                    second = 16;
                }
                else
                {
                    connection.Open();

                    incorCount++;
                    incorrectCountLabel.Text = incorCount.ToString();
                    SqlCommand cmd = new SqlCommand("SELECT TOP 1 English, Turkish FROM wordsTable ORDER BY NEWID()", connection);
                    cmd.ExecuteNonQuery();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                        questionLabel.Text = (dr["English"].ToString());
                        correctLabel.Text = (dr["Turkish"].ToString());
                    }

                    connection.Close();

                    answerTextBox.Text = "";
                    second = 16;
                }
            }

            else if (trengRadioButton.Checked == true)
            {

                if (answerTextBox.Text == correctLabel.Text)
                {
                    connection.Open();


                    timer.Enabled = true;

                    corCount++;
                    correctCountLabel.Text = corCount.ToString();
                    SqlCommand cmd = new SqlCommand("SELECT TOP 1 Turkish, English FROM wordsTable ORDER BY NEWID()", connection);
                    cmd.ExecuteNonQuery();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                        questionLabel.Text = (dr["Turkish"].ToString());
                        correctLabel.Text = (dr["English"].ToString());
                    }
                    connection.Close();

                    answerTextBox.Text = "";
                    second = 16;
                }

                else
                {
                    connection.Open();

                    incorCount++;
                    incorrectCountLabel.Text = incorCount.ToString();

                    SqlCommand cmd = new SqlCommand("SELECT TOP 1 Turkish, English FROM wordsTable ORDER BY NEWID()", connection);
                    cmd.ExecuteNonQuery();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                        questionLabel.Text = (dr["Turkish"].ToString());
                        correctLabel.Text = (dr["English"].ToString());
                    }
                    connection.Close();

                    answerTextBox.Text = "";
                    second = 16;

                }

            }
            
        }

        private void actionButton_Click(object sender, EventArgs e)//testi başlatmak için
        {
            
            if(trengRadioButton.Checked == true)
            {
                timer.Enabled = true;
                second = 16;

                connection.Open();

                correctCountLabel.Text = corCount.ToString();
                incorrectCountLabel.Text = incorCount.ToString();
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 Turkish, English FROM wordsTable ORDER BY NEWID()", connection); 
 
                 cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    questionLabel.Text = (dr["Turkish"].ToString());
                    correctLabel.Text = (dr["English"].ToString());

                }
                connection.Close();

            }

            else if(engtrRadioButton.Checked == true)
            {
                timer.Enabled = true;
                second = 16;

                connection.Open();

                correctCountLabel.Text = corCount.ToString();
                incorrectCountLabel.Text = incorCount.ToString();
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 English, Turkish FROM wordsTable ORDER BY NEWID()", connection);
                cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    questionLabel.Text = (dr["English"].ToString());
                    correctLabel.Text = (dr["Turkish"].ToString());

                }
                connection.Close();
            }

            else
            {

                MessageBox.Show("Please Select Dictionary Type!");

            }
                    
        }

        private void stopButton_Click(object sender, EventArgs e)//testi durdurmak için
        {
            connection.Open();

            SqlCommand cmd = new SqlCommand("insert into countTable (trueCount,falseCount,Date) values (@p1, @p2, @p3)", connection);
            cmd.Parameters.AddWithValue("@p1", corCount);
            cmd.Parameters.AddWithValue("@p2", incorCount);
            cmd.Parameters.AddWithValue("@p3", DateTime.Now);
            cmd.ExecuteNonQuery();

            connection.Close();

            timer.Enabled = false;
            stopButton.Enabled = false;
             

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            this.Hide();
            mm.Show();
        }

        private void checkButton_Click(object sender, EventArgs e)//cevap kontrolu
        {
            
            answer();

        }
        
        private void timer_Tick(object sender, EventArgs e)//zamanlayıcı
        {

            second = second - 1;
            timeLabel.Text = second.ToString();

            if(second == 0)
            {
                
                answerTime();
                second = 16;
                timer.Enabled = true;
            }
            
            

        }

      
    }
}
