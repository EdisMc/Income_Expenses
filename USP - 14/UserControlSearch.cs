using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace USP___14
{
    public partial class UserControlSearch : UserControl
    {
        public UserControlSearch()
        {
            InitializeComponent();

            comboBox2.Items.Add("Приход");
            comboBox2.Items.Add("Разход");
            comboBox3.Items.Add("Януари");
            comboBox3.Items.Add("Февруари");
            comboBox3.Items.Add("Март");
            comboBox3.Items.Add("Април");
            comboBox3.Items.Add("Май");
            comboBox3.Items.Add("Юни");
            comboBox3.Items.Add("Юли");
            comboBox3.Items.Add("Август");
            comboBox3.Items.Add("Септември");
            comboBox3.Items.Add("Октомври");
            comboBox3.Items.Add("Ноември");
            comboBox3.Items.Add("Декември");

            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == "Приход")
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Заплата");
                comboBox1.Items.Add("Наем от имот");
                comboBox1.Items.Add("Собствен бизнес");
                comboBox1.Items.Add("Хазарт");
                comboBox1.Items.Add("Други");
                comboBox1.SelectedIndex = 0;
            }
            else if (comboBox2.SelectedItem == "Разход")
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Сметки");
                comboBox1.Items.Add("Домакинство");
                comboBox1.Items.Add("Заеми");
                comboBox1.Items.Add("Лични разходи");
                comboBox1.Items.Add("Други");
                comboBox1.SelectedIndex = 0;
            }
        }

        private void flatButtonCreateRevenue_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\edy_d\\OneDrive\\Documents\\svssystem.mdf;Integrated Security=True;Connect Timeout=30";
            string Kategoria = comboBox1.Text;
            string Tip = comboBox2.Text;
            int Mesec = comboBox3.SelectedIndex + 1;

            string queryString = "SELECT ID_DB, Suma_DB, Mesec_DB  from USP14_Table where Mesec_DB='" + Mesec + "'and Tip_DB='" + Tip + "'and Kategoria_DB='" + Kategoria + "';";
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter(queryString, con);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView1.DataSource = dtbl;
                if (dataGridView1.Rows.Count == 1)
                {
                    MessageBox.Show("Не съществуват такива приходи/разходи!");
                }
            }
        }

        private void UserControlSearch_Load(object sender, EventArgs e)
        {

        }

        
    }
}
