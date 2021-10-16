using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class FormCount : Form
    {
        public FormCount()
        {
            InitializeComponent();
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColors.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColors.SecondaryColor;
                }
            }
        }

        Baglanti baglanti = new Baglanti();

        private void FormSettings_Load(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(baglanti.Adres);
            Con.Open();
            SqlDataAdapter sda1 = new SqlDataAdapter("select count(*) from Member",Con);
            DataTable dt = new DataTable();
            sda1.Fill(dt);
            lblMember.Text = dt.Rows[0][0].ToString();
            SqlDataAdapter sda2 = new SqlDataAdapter("select count(*) from Staff",Con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            lblStaff.Text = dt2.Rows[0][0].ToString();
            SqlDataAdapter sda3 = new SqlDataAdapter("select count(*) from Doctor", Con);
            DataTable dt3 = new DataTable();
            sda3.Fill(dt3);
            lblDoctor.Text = dt3.Rows[0][0].ToString();
            SqlDataAdapter sda4 = new SqlDataAdapter("select count(*) from Appointment", Con);
            DataTable dt4 = new DataTable();
            sda4.Fill(dt4);
            lblAppointment.Text = dt4.Rows[0][0].ToString();
            Con.Close(); 
        }

        
    }
}
