using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        

        // Mosue ile form1'i hareket ettirebilmek için gerekli kod.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        //Sağ üstteki kapanma tuşuna basılınca uygulamayı sonlandırır.
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Giriş butonuna basılınca  form1 uygulamayı açar.
        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtboxUserName.Text == "admin" && txtboxPassword.Text == "admin")
            {
                FormMainMenu fm = new FormMainMenu();
                fm.Show();
                this.Hide();
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtboxUserName.Text) && (string.IsNullOrWhiteSpace(txtboxUserName.Text)))
                {
                    MessageBox.Show("Lütfen kullanıcı adı ve şifre girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (string.IsNullOrWhiteSpace(txtboxUserName.Text))
                {
                    MessageBox.Show("Lütfen kullanıcı adı girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (string.IsNullOrWhiteSpace(txtboxPassword.Text))
                {
                    MessageBox.Show("Lütfen şifre girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    MessageBox.Show("Yanlış kullanıcı adı veya parola", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Login formundaki panele tıklayınca hereket edebilmesini sağlar.
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Enter tuşu ile giriş yapılabilmesini sağlar.(İkisineden yazmamızını sebebi uyarı mesajlarını alabilmek.)
        private void txtboxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        //Enter tuşu ile giriş yapılabilmesini sağlar.(İkisineden yazmamızını sebebi uyarı mesajlarını alabilmek.)
        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        //Enter tuşu ile giriş yapılabilmesini sağlar.(İkisineden yazmamızını sebebi uyarı mesajlarını alabilmek.)
        private void txtboxUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

    }
}
