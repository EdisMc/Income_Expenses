using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Globalization;
namespace USP___14
{
    public partial class UserControlInsertExpense : UserControl
    {
        public UserControlInsertExpense()
        {
            InitializeComponent();
            comboBox1.Items.Add("Сметки");
            comboBox1.Items.Add("Домакинство");
            comboBox1.Items.Add("Заеми");
            comboBox1.Items.Add("Лични разходи");
            comboBox1.Items.Add("Други");
            comboBox1.SelectedIndex = 0;

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Сума в лева")
            {
                textBox1.Text = "";
                panel1.BackColor = Color.FromArgb(0, 102, 204);
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Сума в лева";
                panel1.BackColor = Color.White;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Описание")
            {
                textBox2.Text = "";
                panel2.BackColor = Color.FromArgb(0, 102, 204);
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Описание";
                panel2.BackColor = Color.White;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Дата (dd/mm/yyyy)")
            {
                textBox4.Text = "";
                panel5.BackColor = Color.FromArgb(0, 102, 204);
            }

        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Дата (dd/mm/yyyy)";
                panel5.BackColor = Color.White;
            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserControlInsertExpense_Load(object sender, EventArgs e)
        {

        }

        private void flatButtonCreateRevenue_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\edy_d\OneDrive\Documents\svssystem.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();


            Regex regexDate = new Regex(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$");
            bool isValidDate = regexDate.IsMatch(textBox4.Text.Trim());
            DateTime dt;
            isValidDate = DateTime.TryParseExact(textBox4.Text, "dd/MM/yyyy", new CultureInfo("en-GB"), DateTimeStyles.None, out dt);
            Regex regexSuma = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
            bool isValidSuma = regexSuma.IsMatch(textBox1.Text.Trim());
            if (!isValidSuma || textBox1.Text.ToString().Equals("0"))
            {
                MessageBox.Show("Невалидна сума");
            }
            else if (textBox2.Text.Equals("Описание") || textBox2.Text.Equals(""))
            {
                MessageBox.Show("Полето \"Описание\" е празно!");
            }
            else if (!isValidDate)
            {
                MessageBox.Show("Невалидна дата!");
            }
            else
            {
                string Suma = textBox1.Text.ToString();
                string Data = textBox4.Text.ToString();
                string Opisanie = textBox2.Text.ToString();
                string Tip = "Разход";
                string Kategoria = comboBox1.Text;
                string Mesec = Data.Substring(3, 2);
                DataBaseClass exp = new DataBaseClass(Suma, Data, Opisanie, Tip, Kategoria, Mesec);
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string q = "insert into USP14_Table(Tip_DB,Suma_DB,Kategoria_DB,Data_DB,Opisanie_DB,Mesec_DB)values(N'" + exp.getTip() + "','" + exp.getSuma() + "',N'" + exp.getKategoria() + "',N'" + exp.getData()
                + "',N'" + exp.getOpisanie() + "','" + exp.getMesec() + "')";
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Успешно добавяне");
                    textBox1.Text = "Сума в лева";
                    textBox2.Text = "Описание";
                    textBox4.Text = "Дата (dd/mm/yyyy)";
                    comboBox1.SelectedIndex = 0;
                }
            }
        }
    }
}
