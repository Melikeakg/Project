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
    public partial class FormMemberAdd : Form
    {
        Baglanti baglanti = new Baglanti();
     
        public FormMemberAdd()
        {
            InitializeComponent();
            LoadTheme();
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

        //Form kaydet içindeki textboxlara girilen bilgileri temizler.
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNameSurname.Clear();
            txtTC.Clear();

            comboGender.ResetText();

            txtPhone.Clear();
            txtEmail.Clear();

            dtpBitisTarihi.Value = DateTime.Now;
            richTxtAdress.Clear();

            dtpBirth.Value = DateTime.Now;
            dtpJoindate.Value = DateTime.Now;

        }

        //Telefon numarasının sadece klavyeden sayı ve silme tuşunun girilmesine izin verir.
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        //Tc numarasının sadece klavyeden sayı ve silme tuşunun girilmesine izin verir.
        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

        }

        

        //Üyenin kaydedilmesini sağlar.İçerisinde veritabanı bağlantısı var.
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNameSurname.Text) ||
                (string.IsNullOrWhiteSpace(txtTC.Text)) || (string.IsNullOrWhiteSpace(txtPhone.Text)) ||
                (string.IsNullOrWhiteSpace(txtEmail.Text)) || (string.IsNullOrWhiteSpace(dtpBitisTarihi.Text)))
            {
                MessageBox.Show("Eksik bilgi girdiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtTC.TextLength < 11 && txtPhone.TextLength < 10)
            {
                MessageBox.Show("Tc kimlik numaranızı ve telefon numaranızı eksik girdiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtTC.TextLength < 11)
            {
                MessageBox.Show("Tc kimlik numarası 11 haneli olmalıdır..", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtPhone.TextLength < 10)
            {
                MessageBox.Show("Telefon numarası 10 haneli olmalılır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtEmail.Text.Contains("@") == false || txtEmail.Text.Contains(".com") == false)
            {
                MessageBox.Show("Mail adresinizi hatalı yazdınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                try
                {
                    SqlConnection Con = new SqlConnection(baglanti.Adres);
                    Con.Open();
                    string query = "insert into Member values('" + txtNameSurname.Text + "','" + txtTC.Text + "','" + comboGender.SelectedItem.ToString() + "','" + txtPhone.Text + "','" + dtpBirth.Text + "','" + richTxtAdress.Text + "','" + txtEmail.Text + "','" + dtpJoindate.Text + "','" + dtpBitisTarihi.Text+ "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Üye kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

     
    }
}
