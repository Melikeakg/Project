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
    public partial class FormMemberUpDel : Form
    {
        public FormMemberUpDel()
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
            dataGridArama.DataSource = ds.Tables[0];
            Con.Close();
        }
        //tektbox ve diğer kutuların içini boşaltır.
        private void EmptyBox()
        {
            txtNameSurname.Clear();
            txtTC.Clear();

            comboxGender.ResetText();

            txtPhone.Clear();
            txtEmail.Clear();

            dtpBitisTarihi.Value = DateTime.Now;
            richTxtAdress.Clear();

            dtpBirth.Value = DateTime.Now;
            dtpJoindate.Value = DateTime.Now;
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
                string query = "select * from Member where UyeTC = " + txtTcSearch.Text + "";
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

        private void FormMemberUpDel_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
                txtNameSurname.Text = dataGridArama.CurrentRow.Cells["UyeAdSoyad"].Value.ToString();
                txtTC.Text = dataGridArama.CurrentRow.Cells["UyeTC"].Value.ToString();
                comboxGender.Text = dataGridArama.CurrentRow.Cells["Cinsiyet"].Value.ToString();
                txtPhone.Text = dataGridArama.CurrentRow.Cells["Telefon"].Value.ToString();
                dtpBirth.Text = dataGridArama.CurrentRow.Cells["DogumTarihi"].Value.ToString();
                richTxtAdress.Text = dataGridArama.CurrentRow.Cells["Adres"].Value.ToString();
                txtEmail.Text = dataGridArama.CurrentRow.Cells["Email"].Value.ToString();
                dtpJoindate.Text = dataGridArama.CurrentRow.Cells["KatilmaTarihi"].Value.ToString();
                dtpBitisTarihi.Text = dataGridArama.CurrentRow.Cells["KayitSuresi"].Value.ToString();
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
                    string query = "delete from Member where UyeTC=" + txtTcSearch.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Üye başarıyla silindi.", "Bilgi", MessageBoxButtons.OK);
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
                (string.IsNullOrWhiteSpace(txtEmail.Text)) || (string.IsNullOrWhiteSpace(dtpBitisTarihi.Text)))
            {
                MessageBox.Show("Önce bilgileri düzenlemeniz gereklidir!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else {
                try
                {
                    SqlConnection Con = new SqlConnection(baglanti.Adres);
                    Con.Open();
                    string query = "update Member set UyeAdSoyad='" + txtNameSurname.Text + "',UyeTC='" + txtTC.Text + "',Cinsiyet='" + comboxGender.Text + "',Telefon='" + txtPhone.Text + "',DogumTarihi='" + dtpBirth.Text + "',Adres='" + richTxtAdress.Text + "',Email='" + txtEmail.Text + "',KatilmaTarihi='" + dtpJoindate.Text + "',KayitSuresi='" + dtpBitisTarihi.Text + "' where UyeTC=" + txtTC.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Üye başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK);
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
