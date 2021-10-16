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
    public partial class FormDoctorList : Form
    {
        public FormDoctorList()
        {
            InitializeComponent();
            LoadTheme();
        }

        Baglanti baglanti = new Baglanti();
        private void populate()
        {
            SqlConnection Con = new SqlConnection(baglanti.Adres);
            Con.Open();
            string query = "select * from Doctor";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridDoctor.DataSource = ds.Tables[0];
            Con.Close();
        }

        //Açılan formdaki butonların tema rengi ile uyumlu olmasını sağlar.
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
        //FormDoctorList te bulunan datagride veritabanındaki bilgilerin gelmesini sağlar.
        private void FormDoctorList_Load(object sender, EventArgs e)
        {
                populate();
        }

        
        private void btnListeyiGetir_Click(object sender, EventArgs e)
        {
            populate();
        }

        //Ad-Soyada göre arama yapılmasını sağlar.
        private void btnAdSoyadSearch_Click(object sender, EventArgs e)
        {
            if (txtNameSearch.Text != "")
            {
                SqlConnection Con = new SqlConnection(baglanti.Adres);
                Con.Open();
                string query = "select * from Doctor where DoctorAdSoyad like '%" + txtNameSearch.Text + "%'";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder();
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridDoctor.DataSource = ds.Tables[0];
                Con.Close();
                txtNameSearch.Text = "";
            }

            else
            {
                MessageBox.Show("Lütfen Ad-Soyad Giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

}

