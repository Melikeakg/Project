using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Project.Forms
{
    public partial class FormEmail : Form
    {
        public FormEmail()
        {
            InitializeComponent();
            LoadTheme(btnSend);
        }

        private void LoadTheme(Button btnSend)
        {
            btnSend.BackColor = ThemeColors.PrimaryColor;
            btnSend.ForeColor = Color.White;
            btnSend.FlatAppearance.BorderColor = ThemeColors.SecondaryColor;
        }

        string[] AttachmentArray;

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtKime.Text.Contains("@") == false || txtKime.Text.Contains(".com")==false)
            {

                MessageBox.Show("Mail adresini hatalı yazdınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

               
            }

            else if (txtKime.Text == "" || txtKonu.Text == "" || txtMesaj.Text == "")
            {
                MessageBox.Show("Eksik bilgi girdiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            else
            {
                SmtpClient ClientMailGonderme = new SmtpClient();
                ClientMailGonderme.Port = 587;
                ClientMailGonderme.Host = "smtp.live.com";
                ClientMailGonderme.EnableSsl = true;
                ClientMailGonderme.Credentials = new NetworkCredential("Your mail ", "your password");
                
                MailMessage mesajbilgileri = new MailMessage();
                mesajbilgileri.From = new MailAddress("Your mail");
                mesajbilgileri.To.Add(txtKime.Text.ToString());
                mesajbilgileri.Subject = txtKonu.Text.ToString();
                mesajbilgileri.Body = txtMesaj.Text.ToString();

                if (AttachmentArray != null)
                {
                    for (int a = 0; a < AttachmentArray.Length; a++)
                    {
                        mesajbilgileri.Attachments.Add(new Attachment(AttachmentArray[a]));
                    }
                }
                ClientMailGonderme.Send(mesajbilgileri);
                MessageBox.Show("Mesajınız gönderildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Temizle();


            }
        }

        private void btnDosyaEkle_Click(object sender, EventArgs e)
        {
            txtMailEki.ResetText();
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Multiselect = true;

            if (dosya.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            AttachmentArray = dosya.FileNames;

            foreach (string name in dosya.SafeFileNames)
            {
                txtMailEki.Text += name + ";";
            }
        }

        void Temizle()
        {
            txtKime.Clear();
            txtKonu.Clear();
            txtMailEki.Clear();
            txtMesaj.Clear();
        }

    }
}


