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

namespace Project.Forms
{
    public partial class FormMemberList : Form
    {
        public FormMemberList()
        {
            InitializeComponent();
            LoadTheme();
        }

        Baglanti baglanti = new Baglanti();

        private void populate()
        {
            SqlConnection Con = new SqlConnection(baglanti.Adres);
            Con.Open();
            string query = "select * from Member";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridMember.DataSource = ds.Tables[0];
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


        //FormMemberList te bulunan datagride veritabanındaki bilgilerin gelmesini sağlar.
        private void FormMemberList_Load(object sender, EventArgs e)
        {
            populate();
        }

        //Tc'ye göre arama yapılmasını sağlar.
        private void btnTcSearch_Click_1(object sender, EventArgs e)
        {

            if (txtTcSearch.Text != "")
            {
                SqlConnection Con = new SqlConnection(baglanti.Adres);
                Con.Open();
                string query = "select * from Member where UyeTC = " + txtTcSearch.Text + "";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder();
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridMember.DataSource = ds.Tables[0];
                Con.Close();
                txtTcSearch.Text = "";
            }

            else
            {
                MessageBox.Show("Lütfen Tc Giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnListeyiGetir_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
