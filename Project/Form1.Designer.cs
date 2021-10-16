
namespace Project
{
    partial class FormMainMenu
    {
        /// <summary>  
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.panelMemberEntry = new System.Windows.Forms.Panel();
            this.btnQrCodeEncode = new System.Windows.Forms.Button();
            this.btnQrCodeAdd = new System.Windows.Forms.Button();
            this.btnEntry = new System.Windows.Forms.Button();
            this.btnEmail = new System.Windows.Forms.Button();
            this.panelMoneySubmenu = new System.Windows.Forms.Panel();
            this.btnStaffMoney = new System.Windows.Forms.Button();
            this.btnSeeMoney = new System.Windows.Forms.Button();
            this.btnMoney = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelAppointSubmenu = new System.Windows.Forms.Panel();
            this.btnSeeAppoint = new System.Windows.Forms.Button();
            this.btnAddAppoint = new System.Windows.Forms.Button();
            this.btnAppoint = new System.Windows.Forms.Button();
            this.panelDoctorSubmenu = new System.Windows.Forms.Panel();
            this.btnDoctorUpDel = new System.Windows.Forms.Button();
            this.btnListDoc = new System.Windows.Forms.Button();
            this.BtnAddDoc = new System.Windows.Forms.Button();
            this.btnDoctor = new System.Windows.Forms.Button();
            this.panelStaffSubmenu = new System.Windows.Forms.Panel();
            this.btnStaffUpDel = new System.Windows.Forms.Button();
            this.btnListStaff = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.panelMemberSubmenu = new System.Windows.Forms.Panel();
            this.btnMemberUpDel = new System.Windows.Forms.Button();
            this.btnListMem = new System.Windows.Forms.Button();
            this.btnAddMem = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelHome = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelMemberEntry.SuspendLayout();
            this.panelMoneySubmenu.SuspendLayout();
            this.panelAppointSubmenu.SuspendLayout();
            this.panelDoctorSubmenu.SuspendLayout();
            this.panelStaffSubmenu.SuspendLayout();
            this.panelMemberSubmenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.panelMemberEntry);
            this.panelMenu.Controls.Add(this.btnEntry);
            this.panelMenu.Controls.Add(this.btnEmail);
            this.panelMenu.Controls.Add(this.panelMoneySubmenu);
            this.panelMenu.Controls.Add(this.btnMoney);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Controls.Add(this.btnExit);
            this.panelMenu.Controls.Add(this.panelAppointSubmenu);
            this.panelMenu.Controls.Add(this.btnAppoint);
            this.panelMenu.Controls.Add(this.panelDoctorSubmenu);
            this.panelMenu.Controls.Add(this.btnDoctor);
            this.panelMenu.Controls.Add(this.panelStaffSubmenu);
            this.panelMenu.Controls.Add(this.btnStaff);
            this.panelMenu.Controls.Add(this.panelMemberSubmenu);
            this.panelMenu.Controls.Add(this.btnMember);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 749);
            this.panelMenu.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 1040);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(203, 45);
            this.btnSettings.TabIndex = 26;
            this.btnSettings.Text = "  Toplam Kayıtlar";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click_1);
            // 
            // panelMemberEntry
            // 
            this.panelMemberEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelMemberEntry.Controls.Add(this.btnQrCodeEncode);
            this.panelMemberEntry.Controls.Add(this.btnQrCodeAdd);
            this.panelMemberEntry.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMemberEntry.Location = new System.Drawing.Point(0, 955);
            this.panelMemberEntry.Margin = new System.Windows.Forms.Padding(4);
            this.panelMemberEntry.Name = "panelMemberEntry";
            this.panelMemberEntry.Size = new System.Drawing.Size(203, 85);
            this.panelMemberEntry.TabIndex = 25;
            // 
            // btnQrCodeEncode
            // 
            this.btnQrCodeEncode.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQrCodeEncode.FlatAppearance.BorderSize = 0;
            this.btnQrCodeEncode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQrCodeEncode.ForeColor = System.Drawing.Color.LightGray;
            this.btnQrCodeEncode.Location = new System.Drawing.Point(0, 40);
            this.btnQrCodeEncode.Name = "btnQrCodeEncode";
            this.btnQrCodeEncode.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnQrCodeEncode.Size = new System.Drawing.Size(203, 40);
            this.btnQrCodeEncode.TabIndex = 1;
            this.btnQrCodeEncode.Text = "Karekod Girişi";
            this.btnQrCodeEncode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQrCodeEncode.UseVisualStyleBackColor = true;
            this.btnQrCodeEncode.Click += new System.EventHandler(this.btnQrCodeEncode_Click);
            // 
            // btnQrCodeAdd
            // 
            this.btnQrCodeAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQrCodeAdd.FlatAppearance.BorderSize = 0;
            this.btnQrCodeAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQrCodeAdd.ForeColor = System.Drawing.Color.LightGray;
            this.btnQrCodeAdd.Location = new System.Drawing.Point(0, 0);
            this.btnQrCodeAdd.Name = "btnQrCodeAdd";
            this.btnQrCodeAdd.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnQrCodeAdd.Size = new System.Drawing.Size(203, 40);
            this.btnQrCodeAdd.TabIndex = 0;
            this.btnQrCodeAdd.Text = "Karekod Oluştur";
            this.btnQrCodeAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQrCodeAdd.UseVisualStyleBackColor = true;
            this.btnQrCodeAdd.Click += new System.EventHandler(this.btnQrCodeAdd_Click);
            // 
            // btnEntry
            // 
            this.btnEntry.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEntry.FlatAppearance.BorderSize = 0;
            this.btnEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntry.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEntry.Image = ((System.Drawing.Image)(resources.GetObject("btnEntry.Image")));
            this.btnEntry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntry.Location = new System.Drawing.Point(0, 910);
            this.btnEntry.Margin = new System.Windows.Forms.Padding(4);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEntry.Size = new System.Drawing.Size(203, 45);
            this.btnEntry.TabIndex = 23;
            this.btnEntry.Text = "  Üye Giriş İşlemleri";
            this.btnEntry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEntry.UseVisualStyleBackColor = true;
            this.btnEntry.Click += new System.EventHandler(this.btnEntry_Click);
            // 
            // btnEmail
            // 
            this.btnEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmail.FlatAppearance.BorderSize = 0;
            this.btnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEmail.Image = ((System.Drawing.Image)(resources.GetObject("btnEmail.Image")));
            this.btnEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmail.Location = new System.Drawing.Point(0, 865);
            this.btnEmail.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEmail.Size = new System.Drawing.Size(203, 45);
            this.btnEmail.TabIndex = 21;
            this.btnEmail.Text = "  E-Mail";
            this.btnEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmail.UseVisualStyleBackColor = true;
            this.btnEmail.Click += new System.EventHandler(this.btnEmail_Click);
            // 
            // panelMoneySubmenu
            // 
            this.panelMoneySubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelMoneySubmenu.Controls.Add(this.btnStaffMoney);
            this.panelMoneySubmenu.Controls.Add(this.btnSeeMoney);
            this.panelMoneySubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMoneySubmenu.Location = new System.Drawing.Point(0, 780);
            this.panelMoneySubmenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMoneySubmenu.Name = "panelMoneySubmenu";
            this.panelMoneySubmenu.Size = new System.Drawing.Size(203, 85);
            this.panelMoneySubmenu.TabIndex = 20;
            // 
            // btnStaffMoney
            // 
            this.btnStaffMoney.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaffMoney.FlatAppearance.BorderSize = 0;
            this.btnStaffMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffMoney.ForeColor = System.Drawing.Color.LightGray;
            this.btnStaffMoney.Location = new System.Drawing.Point(0, 40);
            this.btnStaffMoney.Name = "btnStaffMoney";
            this.btnStaffMoney.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnStaffMoney.Size = new System.Drawing.Size(203, 40);
            this.btnStaffMoney.TabIndex = 1;
            this.btnStaffMoney.Text = "Personel Ödemeleri";
            this.btnStaffMoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaffMoney.UseVisualStyleBackColor = true;
            this.btnStaffMoney.Click += new System.EventHandler(this.btnStaffMoney_Click);
            // 
            // btnSeeMoney
            // 
            this.btnSeeMoney.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeeMoney.FlatAppearance.BorderSize = 0;
            this.btnSeeMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeeMoney.ForeColor = System.Drawing.Color.LightGray;
            this.btnSeeMoney.Location = new System.Drawing.Point(0, 0);
            this.btnSeeMoney.Name = "btnSeeMoney";
            this.btnSeeMoney.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSeeMoney.Size = new System.Drawing.Size(203, 40);
            this.btnSeeMoney.TabIndex = 0;
            this.btnSeeMoney.Text = "Müşteri Ödemeleri";
            this.btnSeeMoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeeMoney.UseVisualStyleBackColor = true;
            this.btnSeeMoney.Click += new System.EventHandler(this.btnSeeMoney_Click);
            // 
            // btnMoney
            // 
            this.btnMoney.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMoney.FlatAppearance.BorderSize = 0;
            this.btnMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoney.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMoney.Image = ((System.Drawing.Image)(resources.GetObject("btnMoney.Image")));
            this.btnMoney.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoney.Location = new System.Drawing.Point(0, 735);
            this.btnMoney.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoney.Name = "btnMoney";
            this.btnMoney.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMoney.Size = new System.Drawing.Size(203, 45);
            this.btnMoney.TabIndex = 19;
            this.btnMoney.Text = "  Hesap İşlemleri";
            this.btnMoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoney.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMoney.UseVisualStyleBackColor = true;
            this.btnMoney.Click += new System.EventHandler(this.btnMoney_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(0, 1068);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Size = new System.Drawing.Size(212, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "_______________________";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 1102);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(203, 45);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "  Oturumu Kapat";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelAppointSubmenu
            // 
            this.panelAppointSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelAppointSubmenu.Controls.Add(this.btnSeeAppoint);
            this.panelAppointSubmenu.Controls.Add(this.btnAddAppoint);
            this.panelAppointSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAppointSubmenu.Location = new System.Drawing.Point(0, 655);
            this.panelAppointSubmenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelAppointSubmenu.Name = "panelAppointSubmenu";
            this.panelAppointSubmenu.Size = new System.Drawing.Size(203, 80);
            this.panelAppointSubmenu.TabIndex = 8;
            // 
            // btnSeeAppoint
            // 
            this.btnSeeAppoint.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeeAppoint.FlatAppearance.BorderSize = 0;
            this.btnSeeAppoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeeAppoint.ForeColor = System.Drawing.Color.LightGray;
            this.btnSeeAppoint.Location = new System.Drawing.Point(0, 40);
            this.btnSeeAppoint.Name = "btnSeeAppoint";
            this.btnSeeAppoint.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSeeAppoint.Size = new System.Drawing.Size(203, 33);
            this.btnSeeAppoint.TabIndex = 1;
            this.btnSeeAppoint.Text = "Randevu Görüntüle";
            this.btnSeeAppoint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeeAppoint.UseVisualStyleBackColor = true;
            this.btnSeeAppoint.Click += new System.EventHandler(this.btnSeeAppoint_Click);
            // 
            // btnAddAppoint
            // 
            this.btnAddAppoint.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddAppoint.FlatAppearance.BorderSize = 0;
            this.btnAddAppoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAppoint.ForeColor = System.Drawing.Color.LightGray;
            this.btnAddAppoint.Location = new System.Drawing.Point(0, 0);
            this.btnAddAppoint.Name = "btnAddAppoint";
            this.btnAddAppoint.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAddAppoint.Size = new System.Drawing.Size(203, 40);
            this.btnAddAppoint.TabIndex = 0;
            this.btnAddAppoint.Text = "Randevu Al";
            this.btnAddAppoint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAppoint.UseVisualStyleBackColor = true;
            this.btnAddAppoint.Click += new System.EventHandler(this.btnAddAppoint_Click);
            // 
            // btnAppoint
            // 
            this.btnAppoint.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAppoint.FlatAppearance.BorderSize = 0;
            this.btnAppoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppoint.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAppoint.Image = ((System.Drawing.Image)(resources.GetObject("btnAppoint.Image")));
            this.btnAppoint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppoint.Location = new System.Drawing.Point(0, 610);
            this.btnAppoint.Margin = new System.Windows.Forms.Padding(4);
            this.btnAppoint.Name = "btnAppoint";
            this.btnAppoint.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAppoint.Size = new System.Drawing.Size(203, 45);
            this.btnAppoint.TabIndex = 7;
            this.btnAppoint.Text = "  Randevu İşlemleri";
            this.btnAppoint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppoint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAppoint.UseVisualStyleBackColor = true;
            this.btnAppoint.Click += new System.EventHandler(this.btnAppoint_Click);
            // 
            // panelDoctorSubmenu
            // 
            this.panelDoctorSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelDoctorSubmenu.Controls.Add(this.btnDoctorUpDel);
            this.panelDoctorSubmenu.Controls.Add(this.btnListDoc);
            this.panelDoctorSubmenu.Controls.Add(this.BtnAddDoc);
            this.panelDoctorSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDoctorSubmenu.Location = new System.Drawing.Point(0, 485);
            this.panelDoctorSubmenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelDoctorSubmenu.Name = "panelDoctorSubmenu";
            this.panelDoctorSubmenu.Size = new System.Drawing.Size(203, 125);
            this.panelDoctorSubmenu.TabIndex = 6;
            // 
            // btnDoctorUpDel
            // 
            this.btnDoctorUpDel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoctorUpDel.FlatAppearance.BorderSize = 0;
            this.btnDoctorUpDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctorUpDel.ForeColor = System.Drawing.Color.LightGray;
            this.btnDoctorUpDel.Location = new System.Drawing.Point(0, 79);
            this.btnDoctorUpDel.Name = "btnDoctorUpDel";
            this.btnDoctorUpDel.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDoctorUpDel.Size = new System.Drawing.Size(203, 39);
            this.btnDoctorUpDel.TabIndex = 3;
            this.btnDoctorUpDel.Text = "Diyetisyen Güncelle/Sil";
            this.btnDoctorUpDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctorUpDel.UseVisualStyleBackColor = true;
            this.btnDoctorUpDel.Click += new System.EventHandler(this.btnDoctorUpDel_Click);
            // 
            // btnListDoc
            // 
            this.btnListDoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListDoc.FlatAppearance.BorderSize = 0;
            this.btnListDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListDoc.ForeColor = System.Drawing.Color.LightGray;
            this.btnListDoc.Location = new System.Drawing.Point(0, 39);
            this.btnListDoc.Name = "btnListDoc";
            this.btnListDoc.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnListDoc.Size = new System.Drawing.Size(203, 40);
            this.btnListDoc.TabIndex = 2;
            this.btnListDoc.Text = "Diyetisyen Listesi";
            this.btnListDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListDoc.UseVisualStyleBackColor = true;
            this.btnListDoc.Click += new System.EventHandler(this.btnListDoc_Click);
            // 
            // BtnAddDoc
            // 
            this.BtnAddDoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAddDoc.FlatAppearance.BorderSize = 0;
            this.BtnAddDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddDoc.ForeColor = System.Drawing.Color.LightGray;
            this.BtnAddDoc.Location = new System.Drawing.Point(0, 0);
            this.BtnAddDoc.Name = "BtnAddDoc";
            this.BtnAddDoc.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BtnAddDoc.Size = new System.Drawing.Size(203, 39);
            this.BtnAddDoc.TabIndex = 0;
            this.BtnAddDoc.Text = "Diyetisyen Kaydet";
            this.BtnAddDoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddDoc.UseVisualStyleBackColor = true;
            this.BtnAddDoc.Click += new System.EventHandler(this.BtnAddDoc_Click);
            // 
            // btnDoctor
            // 
            this.btnDoctor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoctor.FlatAppearance.BorderSize = 0;
            this.btnDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctor.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDoctor.Image = ((System.Drawing.Image)(resources.GetObject("btnDoctor.Image")));
            this.btnDoctor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctor.Location = new System.Drawing.Point(0, 440);
            this.btnDoctor.Margin = new System.Windows.Forms.Padding(4);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDoctor.Size = new System.Drawing.Size(203, 45);
            this.btnDoctor.TabIndex = 5;
            this.btnDoctor.Text = "  Diyetisyen İşlemleri";
            this.btnDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoctor.UseVisualStyleBackColor = true;
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click);
            // 
            // panelStaffSubmenu
            // 
            this.panelStaffSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelStaffSubmenu.Controls.Add(this.btnStaffUpDel);
            this.panelStaffSubmenu.Controls.Add(this.btnListStaff);
            this.panelStaffSubmenu.Controls.Add(this.btnAddStaff);
            this.panelStaffSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStaffSubmenu.Location = new System.Drawing.Point(0, 315);
            this.panelStaffSubmenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelStaffSubmenu.Name = "panelStaffSubmenu";
            this.panelStaffSubmenu.Size = new System.Drawing.Size(203, 125);
            this.panelStaffSubmenu.TabIndex = 4;
            // 
            // btnStaffUpDel
            // 
            this.btnStaffUpDel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaffUpDel.FlatAppearance.BorderSize = 0;
            this.btnStaffUpDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffUpDel.ForeColor = System.Drawing.Color.LightGray;
            this.btnStaffUpDel.Location = new System.Drawing.Point(0, 80);
            this.btnStaffUpDel.Name = "btnStaffUpDel";
            this.btnStaffUpDel.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnStaffUpDel.Size = new System.Drawing.Size(203, 40);
            this.btnStaffUpDel.TabIndex = 3;
            this.btnStaffUpDel.Text = "Personel Güncelle/Sil";
            this.btnStaffUpDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaffUpDel.UseVisualStyleBackColor = true;
            this.btnStaffUpDel.Click += new System.EventHandler(this.btnStaffUpDel_Click);
            // 
            // btnListStaff
            // 
            this.btnListStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListStaff.FlatAppearance.BorderSize = 0;
            this.btnListStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListStaff.ForeColor = System.Drawing.Color.LightGray;
            this.btnListStaff.Location = new System.Drawing.Point(0, 40);
            this.btnListStaff.Name = "btnListStaff";
            this.btnListStaff.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnListStaff.Size = new System.Drawing.Size(203, 40);
            this.btnListStaff.TabIndex = 2;
            this.btnListStaff.Text = "Personel Listesi";
            this.btnListStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListStaff.UseVisualStyleBackColor = true;
            this.btnListStaff.Click += new System.EventHandler(this.btnListStaff_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddStaff.FlatAppearance.BorderSize = 0;
            this.btnAddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStaff.ForeColor = System.Drawing.Color.LightGray;
            this.btnAddStaff.Location = new System.Drawing.Point(0, 0);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAddStaff.Size = new System.Drawing.Size(203, 40);
            this.btnAddStaff.TabIndex = 0;
            this.btnAddStaff.Text = "Personel Kaydet";
            this.btnAddStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnStaff.Image")));
            this.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.Location = new System.Drawing.Point(0, 270);
            this.btnStaff.Margin = new System.Windows.Forms.Padding(4);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnStaff.Size = new System.Drawing.Size(203, 45);
            this.btnStaff.TabIndex = 3;
            this.btnStaff.Text = "  Personel İşlemleri";
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // panelMemberSubmenu
            // 
            this.panelMemberSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelMemberSubmenu.Controls.Add(this.btnMemberUpDel);
            this.panelMemberSubmenu.Controls.Add(this.btnListMem);
            this.panelMemberSubmenu.Controls.Add(this.btnAddMem);
            this.panelMemberSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMemberSubmenu.Location = new System.Drawing.Point(0, 145);
            this.panelMemberSubmenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMemberSubmenu.Name = "panelMemberSubmenu";
            this.panelMemberSubmenu.Size = new System.Drawing.Size(203, 125);
            this.panelMemberSubmenu.TabIndex = 2;
            // 
            // btnMemberUpDel
            // 
            this.btnMemberUpDel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMemberUpDel.FlatAppearance.BorderSize = 0;
            this.btnMemberUpDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberUpDel.ForeColor = System.Drawing.Color.LightGray;
            this.btnMemberUpDel.Location = new System.Drawing.Point(0, 80);
            this.btnMemberUpDel.Name = "btnMemberUpDel";
            this.btnMemberUpDel.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMemberUpDel.Size = new System.Drawing.Size(203, 40);
            this.btnMemberUpDel.TabIndex = 3;
            this.btnMemberUpDel.Text = "Üye Güncelle/Sil";
            this.btnMemberUpDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMemberUpDel.UseVisualStyleBackColor = true;
            this.btnMemberUpDel.Click += new System.EventHandler(this.btnMemberUpDel_Click);
            // 
            // btnListMem
            // 
            this.btnListMem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListMem.FlatAppearance.BorderSize = 0;
            this.btnListMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListMem.ForeColor = System.Drawing.Color.LightGray;
            this.btnListMem.Location = new System.Drawing.Point(0, 40);
            this.btnListMem.Name = "btnListMem";
            this.btnListMem.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnListMem.Size = new System.Drawing.Size(203, 40);
            this.btnListMem.TabIndex = 2;
            this.btnListMem.Text = "Üye Listesi";
            this.btnListMem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListMem.UseVisualStyleBackColor = true;
            this.btnListMem.Click += new System.EventHandler(this.btnListMem_Click);
            // 
            // btnAddMem
            // 
            this.btnAddMem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddMem.FlatAppearance.BorderSize = 0;
            this.btnAddMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMem.ForeColor = System.Drawing.Color.LightGray;
            this.btnAddMem.Location = new System.Drawing.Point(0, 0);
            this.btnAddMem.Name = "btnAddMem";
            this.btnAddMem.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAddMem.Size = new System.Drawing.Size(203, 40);
            this.btnAddMem.TabIndex = 0;
            this.btnAddMem.Text = "Üye Kaydet";
            this.btnAddMem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMem.UseVisualStyleBackColor = true;
            this.btnAddMem.Click += new System.EventHandler(this.btnAddMem_Click);
            // 
            // btnMember
            // 
            this.btnMember.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMember.FlatAppearance.BorderSize = 0;
            this.btnMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMember.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMember.Image = ((System.Drawing.Image)(resources.GetObject("btnMember.Image")));
            this.btnMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMember.Location = new System.Drawing.Point(0, 100);
            this.btnMember.Margin = new System.Windows.Forms.Padding(4);
            this.btnMember.Name = "btnMember";
            this.btnMember.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMember.Size = new System.Drawing.Size(203, 45);
            this.btnMember.TabIndex = 1;
            this.btnMember.Text = "  Üye İşlemleri";
            this.btnMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(203, 100);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogo_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(50, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "FITGYM";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelTitle.Controls.Add(this.btnCloseChildForm);
            this.panelTitle.Controls.Add(this.btnMaximize);
            this.panelTitle.Controls.Add(this.btnMinimize);
            this.panelTitle.Controls.Add(this.btnClose);
            this.panelTitle.Controls.Add(this.labelHome);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(220, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(981, 100);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseChildForm.Image")));
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(100, 100);
            this.btnCloseChildForm.TabIndex = 4;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.Location = new System.Drawing.Point(913, 1);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(29, 30);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.Text = "O";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.Location = new System.Drawing.Point(877, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Text = "O";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClose.Location = new System.Drawing.Point(948, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "O";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelHome
            // 
            this.labelHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelHome.AutoSize = true;
            this.labelHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelHome.Location = new System.Drawing.Point(437, 36);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(140, 26);
            this.labelHome.TabIndex = 0;
            this.labelHome.Text = "ANASAYFA";
            this.labelHome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelHome_MouseDown);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.pictureBox2);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(220, 100);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(981, 649);
            this.panelMain.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(229, 87);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(619, 438);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1201, 749);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "FormMainMenu";
            this.Text = "FormMainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelMemberEntry.ResumeLayout(false);
            this.panelMoneySubmenu.ResumeLayout(false);
            this.panelAppointSubmenu.ResumeLayout(false);
            this.panelDoctorSubmenu.ResumeLayout(false);
            this.panelStaffSubmenu.ResumeLayout(false);
            this.panelMemberSubmenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelMemberSubmenu;
        private System.Windows.Forms.Button btnAddMem;
        private System.Windows.Forms.Button btnListMem;
        private System.Windows.Forms.Panel panelDoctorSubmenu;
        private System.Windows.Forms.Button btnListDoc;
        private System.Windows.Forms.Button BtnAddDoc;
        private System.Windows.Forms.Button btnDoctor;
        private System.Windows.Forms.Panel panelStaffSubmenu;
        private System.Windows.Forms.Button btnListStaff;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Button btnMemberUpDel;
        private System.Windows.Forms.Button btnDoctorUpDel;
        private System.Windows.Forms.Button btnStaffUpDel;
        private System.Windows.Forms.Panel panelAppointSubmenu;
        private System.Windows.Forms.Button btnSeeAppoint;
        private System.Windows.Forms.Button btnAddAppoint;
        private System.Windows.Forms.Button btnAppoint;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Panel panelMoneySubmenu;
        private System.Windows.Forms.Button btnStaffMoney;
        private System.Windows.Forms.Button btnSeeMoney;
        private System.Windows.Forms.Button btnMoney;
        private System.Windows.Forms.Button btnEntry;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel panelMemberEntry;
        private System.Windows.Forms.Button btnQrCodeEncode;
        private System.Windows.Forms.Button btnQrCodeAdd;
    }
}

