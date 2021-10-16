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
    public partial class FormStaffUpDel : Form
    {
        public FormStaffUpDel()
        {
            InitializeComponent();
            LoadTheme();
        }

        Baglanti baglanti = new Baglanti();
        private void populate()
        {
            SqlConnection Con = new SqlConnection(baglanti.Adres);
            Con.Open();
            string query = "select * from Staff";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridArama.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void EmptyBox()
        {
            txtNameSurname.Clear();
            txtTC.Clear();

            comboxGender.ResetText();

            txtPhone.Clear();
            txtEmail.Clear();

            comboxjob.ResetText();
            richTxtAdress.Clear();

            dtpBirth.Value = DateTime.Now;
            dtpStartDate.Value = DateTime.Now;
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

        //Tc ye göre arama yapılır.Sqlden veri çeker.
        private void btnTcSearch_Click(object sender, EventArgs e)
        {
            if (txtTcSearch.Text != "")
            {
                SqlConnection Con = new SqlConnection(baglanti.Adres);
                Con.Open();
                string query = "select * from Staff where PersonelTC = " + txtTcSearch.Text + "";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder();
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridArama.DataSource = ds.Tables[0];
                Con.Close();
            }

            else
            {
                MessageBox.Show("Lütfen Tc Giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormStaffUpDel_Load(object sender, EventArgs e)
        {
            populate();
        }

       

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtTcSearch.Text == "")
            {
                MessageBox.Show("Lütfen Tc Giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    SqlConnection Con = new SqlConnection(baglanti.Adres);
                    Con.Open();
                    string query = "delete from Staff where PersonelTC=" + txtTcSearch.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Personel başarıyla silindi.", "Bilgi", MessageBoxButtons.OK);
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
              (string.IsNullOrWhiteSpace(txtEmail.Text)) || (string.IsNullOrWhiteSpace(comboxjob.Text)))
            {
                MessageBox.Show("Önce bilgileri düzenlemeniz gereklidir!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                try
                {
                    SqlConnection Con = new SqlConnection(baglanti.Adres);
                    Con.Open();
                    string query = "update Staff set PersonelAdSoyad='" + txtNameSurname.Text + "',PersonelTC='" + txtTC.Text + "',Cinsiyet='" + comboxGender.Text + "',Telefon='" + txtPhone.Text + "',DogumTarihi='" + dtpBirth.Text + "',Adres='" + richTxtAdress.Text + "',Email='" + txtEmail.Text + "',IseBaslamaTarihi='" + dtpStartDate.Text + "',Gorevi='" + comboxjob.Text + "' where PersonelTC=" + txtTC.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Personel başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK);
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

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            txtNameSurname.Text = dataGridArama.CurrentRow.Cells["PersonelAdSoyad"].Value.ToString();
            txtTC.Text = dataGridArama.CurrentRow.Cells["PersonelTC"].Value.ToString();
            comboxGender.Text = dataGridArama.CurrentRow.Cells["Cinsiyet"].Value.ToString();
            txtPhone.Text = dataGridArama.CurrentRow.Cells["Telefon"].Value.ToString();
            dtpBirth.Text = dataGridArama.CurrentRow.Cells["DogumTarihi"].Value.ToString();
            richTxtAdress.Text = dataGridArama.CurrentRow.Cells["Adres"].Value.ToString();
            txtEmail.Text = dataGridArama.CurrentRow.Cells["Email"].Value.ToString();
            comboxjob.Text = dataGridArama.CurrentRow.Cells["Gorevi"].Value.ToString();
            dtpStartDate.Text = dataGridArama.CurrentRow.Cells["IseBaslamaTarihi"].Value.ToString();
        }
    }
}
