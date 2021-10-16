using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class FormMainMenu : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public FormMainMenu()
        {
            InitializeComponent();
            CustomizeDesign();
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
        }

        // Mosue ile form1'i hareket ettirebilmek için gerekli kod.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        //Form1'in içindeki childformlara tıklanınca tema renginin değişmesini sağlayan fonksiyon
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColors.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColors.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColors.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }



        //Butonlara tıklayınca butonları aktifleştirip rengini ve özelliklerinii değiştiren fonksiyon.
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                    panelTitle.BackColor = color;
                    ThemeColors.PrimaryColor = color;
                    ThemeColors.SecondaryColor = ThemeColors.ChangeColorBrightness(color, -0.3);
                    panelLogo.BackColor = ThemeColors.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        //Butonu inaktik eden fonksiyon.
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));

                }
            }
        }

        //Menüdeki alt başlıklara tıklayınca ana kısımda childformları açan fonksiyon.
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(childForm);
            this.panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelHome.Text = childForm.Text;
        }

        //Başlangıçta menünün alt menüdeki seçeneklerinin gizlenmesini sağlayan fonksiyon. (Örn; Üye kaydet, personel sil vb.)
        private void CustomizeDesign()
        {
            panelMemberSubmenu.Visible = false;
            panelStaffSubmenu.Visible = false;
            panelDoctorSubmenu.Visible = false;
            panelAppointSubmenu.Visible = false;
            panelMoneySubmenu.Visible = false;
            panelMemberEntry.Visible = false;
        }

        //Alt seçeneklere tıklayınca tekrar alt seçenek menüsünün kapanmasını sağlayan fonksiyon. (Örn; Üye sil, personel kaydet vb.)
        private void HideSubMenu()
        {
            if (panelMemberSubmenu.Visible == true)
                panelMemberSubmenu.Visible = false;
            if (panelStaffSubmenu.Visible == true)
                panelStaffSubmenu.Visible = false;
            if (panelDoctorSubmenu.Visible == true)
                panelDoctorSubmenu.Visible = false;
            if (panelAppointSubmenu.Visible == true)
                panelAppointSubmenu.Visible = false;
            if (panelMoneySubmenu.Visible == true)
                panelMoneySubmenu.Visible = false;
            if (panelMemberEntry.Visible == true)
                panelMemberEntry.Visible = false;

        }

        //Ana seçeneklere  tıklayınca alt menüyü açan fonksiyon. (Örn; Üye işlemleri, personel işlemleri vb.)
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }

            else
            {
                subMenu.Visible = false;
            }
        }

        //Anasayfa başlığına bir değişken beirledik bu değişkeni label içinde o formun başlığını yazdıran fonksiyon.
        private void Title(string msg)
        {
            labelHome.Text = msg;
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelMemberSubmenu);
            ActivateButton(sender);
            btnCloseChildForm.Visible = false;
            Title("Üye İşlemleri");

        }

        private void btnAddMem_Click(object sender, EventArgs e)
        {
            //codes
            HideSubMenu();
            btnCloseChildForm.Visible = true;
            OpenChildForm(new Forms.FormMemberAdd(), sender);

        }

        private void btnListMem_Click(object sender, EventArgs e)
        {
            //codes
            HideSubMenu();
            btnCloseChildForm.Visible = true;
            OpenChildForm(new Forms.FormMemberList(), sender);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelStaffSubmenu);
            ActivateButton(sender);
            btnCloseChildForm.Visible = false;
            Title("Personel İşlemleri");
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelDoctorSubmenu);
            ActivateButton(sender);
            btnCloseChildForm.Visible = false;
            Title("Diyetisyen İşlemleri");

        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            //codes
            HideSubMenu();
            btnCloseChildForm.Visible = true;
            OpenChildForm(new Forms.FormStaffAdd(), sender);

        }

        private void btnListStaff_Click(object sender, EventArgs e)
        {
            //codes
            HideSubMenu();
            btnCloseChildForm.Visible = true;
            OpenChildForm(new Forms.FormStaffList(), sender);

        }

        private void BtnAddDoc_Click(object sender, EventArgs e)
        {
            //codes
            HideSubMenu();
            btnCloseChildForm.Visible = true;
            OpenChildForm(new Forms.FormDoctorAdd(), sender);

        }

        private void btnListDoc_Click(object sender, EventArgs e)
        {
            //codes
            HideSubMenu();
            btnCloseChildForm.Visible = true;
            OpenChildForm(new Forms.FormDoctorList(), sender);

        }

        private void btnAppoint_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelAppointSubmenu);
            ActivateButton(sender);
            btnCloseChildForm.Visible = false;
            Title("Randevu İşlemleri");

        }

        private void btnAddAppoint_Click(object sender, EventArgs e)
        {

            HideSubMenu();
            btnCloseChildForm.Visible = true;
            OpenChildForm(new Forms.FormAppointTake(), sender);
        }

        private void btnSeeAppoint_Click(object sender, EventArgs e)
        {

            HideSubMenu();
            btnCloseChildForm.Visible = true;
            OpenChildForm(new Forms.FormAppointSee(), sender);

        }

        //Oturum kapata tıklanınca login sayfasına geri gidilir.
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Oturumu kapatmak istediğinize emin misiniz?", "Oturumu Kapat", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
                Login lg = new Login();
                lg.Show();
            }
        }

        //Kapatma tuşuna basılınca uygulamayı sonlandırır.
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Form1'in büyüyüp küçülmesini  sağlar.
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        //Form1'in mininmum boyutua gelmesini sağlar.
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Menüdeki açılan childformu kapatır.
        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        //Anasayfaya geri dönülmesini sağlar.
        private void Reset()
        {
            DisableButton();
            labelHome.Text = "ANASAYFA";
            panelTitle.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        //Mosule ile Form1'in başlığından, panelden, logo yazısından, logo panelinden tutulunca hareket edebilmesini sağlar.(Alttaki dört fonksiyon için geçerlidir.)
        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void labelHome_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMemberUpDel_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            btnCloseChildForm.Visible = true;
            OpenChildForm(new Forms.FormMemberUpDel(), sender);
            Title("Üye Güncelle/Sil");

        }

        private void btnStaffUpDel_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            btnCloseChildForm.Visible = true;
            OpenChildForm(new Forms.FormStaffUpDel(), sender);
            Title("Personel Güncelle/Sil");


        }

        private void btnDoctorUpDel_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            btnCloseChildForm.Visible = true;
            OpenChildForm(new Forms.FormDoctorUpDel(), sender);
            Title("Diyetisyen Güncelle/Sil");

        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelMoneySubmenu);
            ActivateButton(sender);
            btnCloseChildForm.Visible = false;
            Title("Hesap İşlemleri");
        }

        private void btnSeeMoney_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            btnCloseChildForm.Visible = true;
            OpenChildForm(new Forms.FormMoney(), sender);
        }

        private void btnStaffMoney_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            btnCloseChildForm.Visible = true;
            OpenChildForm(new Forms.FormMoneyStaffPays(), sender);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            ActivateButton(sender);
            btnCloseChildForm.Visible = true;
            OpenChildForm(new Forms.FormCount(), sender);
            Title("Ayarlar");
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            ActivateButton(sender);
            btnCloseChildForm.Visible = true;
            OpenChildForm(new Forms.FormEmail(), sender);
            Title("E-mail");
        }

        private void btnQrCodeAdd_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            btnCloseChildForm.Visible = true;
            OpenChildForm(new Forms.FormMemberCodeAdd(), sender);
        }

        private void btnQrCodeEncode_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            btnCloseChildForm.Visible = true;
            OpenChildForm(new Forms.FormMemberCodeEncode(), sender);
        }

        private void btnEntry_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelMemberEntry);
            ActivateButton(sender);
            btnCloseChildForm.Visible = false;
            Title("Üye Giriş İşlemleri");
        }

        private void btnSettings_Click_1(object sender, EventArgs e)
        {
            HideSubMenu();
            ActivateButton(sender);
            btnCloseChildForm.Visible = true;
            OpenChildForm(new Forms.FormCount(), sender);
            Title("Toplam Kayıtlar");
        }

    }
}