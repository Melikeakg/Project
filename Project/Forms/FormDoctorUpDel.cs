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
    public partial class FormDoctorUpDel : Form
    {
        public FormDoctorUpDel()
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
            dataGridArama.DataSource = ds.Tables[0];
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

        private void EmptyBox()
        {
            txtNameSurname.Clear();
            txtTC.Clear();

            comboxGender.ResetText();

            txtPhone.Clear();
            txtEmail.Clear();

            richTxtAdress.Clear();
            dtpBirth.Value = DateTime.Now;
        }

        //Ad soyada göre arama yapılır.Sqlden veri çeker.
        private void btnTcSearch_Click(object sender, EventArgs e)
        {
            if (txtAdSoyadSearch.Text != "")
            {
                SqlConnection Con = new SqlConnection(baglanti.Adres);
                Con.Open();
                string query = "select * from Doctor where DoctorAdSoyad like '%" + txtAdSoyadSearch.Text + "%'";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder();
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridArama.DataSource = ds.Tables[0];
                Con.Close();
            }

            else
            {
                MessageBox.Show("Lütfen Ad-Soyad Giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormDoctorUpDel_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (txtAdSoyadSearch.Text=="")
            {
                MessageBox.Show("Lütfen Ad-Soyad Giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                txtNameSurname.Text = dataGridArama.CurrentRow.Cells["DoctorAdSoyad"].Value.ToString();
                txtTC.Text = dataGridArama.CurrentRow.Cells["TC"].Value.ToString();
                comboxGender.Text = dataGridArama.CurrentRow.Cells["Cinsiyet"].Value.ToString();
                txtPhone.Text = dataGridArama.CurrentRow.Cells["Telefon"].Value.ToString();
                dtpBirth.Text = dataGridArama.CurrentRow.Cells["DogumTarihi"].Value.ToString();
                richTxtAdress.Text = dataGridArama.CurrentRow.Cells["Adres"].Value.ToString();
                txtEmail.Text = dataGridArama.CurrentRow.Cells["Email"].Value.ToString();
            }
            }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtAdSoyadSearch.Text == "")
            {
                MessageBox.Show("Lütfen Ad-Soyad Giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    SqlConnection Con = new SqlConnection(baglanti.Adres);
                    Con.Open();
                    string query = "delete from Doctor where DoctorAdSoyad like '%" + txtAdSoyadSearch.Text + "%'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Diyetisyen başarıyla silindi.", "Bilgi", MessageBoxButtons.OK);
                    Con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNameSurname.Text) ||
               (string.IsNullOrWhiteSpace(txtTC.Text)) || (string.IsNullOrWhiteSpace(txtPhone.Text)) ||
               (string.IsNullOrWhiteSpace(txtEmail.Text)))
            {
                MessageBox.Show("Önce bilgileri düzenlemeniz gereklidir!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    SqlConnection Con = new SqlConnection(baglanti.Adres);
                    Con.Open();
                    string query = "update Doctor set DoctorAdSoyad='" + txtNameSurname.Text + "',TC='" + txtTC.Text + "',Cinsiyet='" + comboxGender.Text + "',Telefon='" + txtPhone.Text + "',DogumTarihi='" + dtpBirth.Text + "',Adres='" + richTxtAdress.Text + "',Email='" + txtEmail.Text + "' where DoctorAdSoyad like '%" + txtAdSoyadSearch.Text + "%'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Diyetisyen başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK);
                    Con.Close();
                    populate();
                    EmptyBox();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
            }
        }
    }
}
