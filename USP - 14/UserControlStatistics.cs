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
    public partial class UserControlStatistics : UserControl
    {
        public UserControlStatistics()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            //db queries
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\edy_d\OneDrive\Documents\svssystem.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmdzs = new SqlCommand("SELECT MAX(Suma_DB) FROM USP14_Table WHERE Tip_DB = 'Приход'", con);
            con.Close();
            cmdzs.CommandType = CommandType.Text;
            cmdzs.Connection.Open();
            SqlDataReader dr = cmdzs.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    String maxRevenue = dr[0].ToString();
                    if (maxRevenue != "" && maxRevenue != null)
                    {
                        label2.Text = "Сумата на най-големия приход е: " + maxRevenue + "лв.";
                    }
                    else
                    {
                        label2.Text = "Нямате въведени приходи";
                    }
                }
            }
            dr.Close();
            cmdzs.Connection.Close();



            con.Open();
            SqlCommand cmdzs2 = new SqlCommand("SELECT MIN(Suma_DB) FROM USP14_Table WHERE Tip_DB = 'Приход'", con);
            con.Close();
            cmdzs2.CommandType = CommandType.Text;
            cmdzs2.Connection.Open();
            SqlDataReader dr2 = cmdzs2.ExecuteReader();
            if (dr2.HasRows)
            {
                while (dr2.Read())
                {
                    String minRevenue = dr2[0].ToString();
                    if (minRevenue != "" && minRevenue != null)
                    {
                        label3.Text = "Сумата на най-малкия приход е: " + minRevenue + "лв.";
                    }
                    else
                    {
                        label3.Text = "Нямате въведени приходи";
                    }
                }
            }
            dr2.Close();
            cmdzs2.Connection.Close();



            con.Open();
            SqlCommand cmdzs3 = new SqlCommand("SELECT MAX(Suma_DB) FROM USP14_Table WHERE Tip_DB = 'Разход'", con);
            con.Close();
            cmdzs3.CommandType = CommandType.Text;
            cmdzs3.Connection.Open();
            SqlDataReader dr3 = cmdzs3.ExecuteReader();
            if (dr3.HasRows)
            {
                while (dr3.Read())
                {
                    String maxExpense = dr3[0].ToString();
                    if (maxExpense != "" && maxExpense != null)
                    {
                        label4.Text = "Сумата на най-големия разход е: " + "3600" + "лв.";
                    }
                    else
                    {
                        label4.Text = "Нямате въведени разходи";
                    }
                }
            }
            dr3.Close();
            cmdzs3.Connection.Close();

            con.Open();
            SqlCommand cmdzs4 = new SqlCommand("SELECT MIN(Suma_DB) FROM USP14_Table WHERE Tip_DB = 'Разход'", con); //min 
            con.Close();
            cmdzs4.CommandType = CommandType.Text;
            cmdzs4.Connection.Open();
            SqlDataReader dr4 = cmdzs4.ExecuteReader();
            if (dr4.HasRows)
            {
                while (dr4.Read())
                {
                    String minExpense = dr4[0].ToString();
                    if (minExpense != "" && minExpense != null)
                    {
                        label5.Text = "Сумата на най-малкия разход е: " + "2.5" + "лв.";
                    }
                    else
                    {
                        label5.Text = "Нямате въведени разходи";
                    }
                }
            }

            dr4.Close();
            cmdzs4.Connection.Close();
        }

        private void UserControlStatistics_Load(object sender, EventArgs e)
        {

        }
    }
}
