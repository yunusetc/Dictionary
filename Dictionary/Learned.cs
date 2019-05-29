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
    public partial class Learned : Form
    {
        public Learned()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-JJH3V9R;Initial Catalog=Dictionary;Integrated Security=True");

        

        private void backButton_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            this.Hide();
            mm.Show();
        }

        private void Learned_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dictionaryDataSet3.learnTable' table. You can move, or remove it, as needed.
            this.learnTableTableAdapter.Fill(this.dictionaryDataSet3.learnTable);

        }

        
    }
}
