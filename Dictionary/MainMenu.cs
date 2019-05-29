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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        

        private void addWordButton_Click(object sender, EventArgs e)//kelime kısmı
        {
            AddWord aw = new AddWord();
            aw.Show();
            this.Hide();
        }

        private void learnButton_Click(object sender, EventArgs e)//kelime öğrenme
        {
            Learn lr = new Learn();
            lr.Show();
            this.Hide();
        }

        private void logoutButton_Click(object sender, EventArgs e)//hesaptan çıkış
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void learnedButton_Click(object sender, EventArgs e)//öğrenilmiş kelimeler
        {
            Learned ld = new Learned();
            this.Hide();
            ld.Show();
        }

        private void testButton_Click(object sender, EventArgs e)//test
        {
            Test tt = new Test();
            this.Hide();
            tt.Show();
        }

        private void statisticsButton_Click(object sender, EventArgs e)//istatistik
        {
            Statistic ss = new Statistic();
            this.Hide();
            ss.Show();
        }
    }
}
