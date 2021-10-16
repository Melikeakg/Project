
namespace Project.Forms
{
    partial class FormAppointTake
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTcSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateAppointment = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMemberNameSurname = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridAppointment = new System.Windows.Forms.DataGridView();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.comboUyeTC = new System.Windows.Forms.ComboBox();
            this.comboDoctor = new System.Windows.Forms.ComboBox();
            this.comboDateTime = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAppointment)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTcSearch
            // 
            this.txtTcSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTcSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTcSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTcSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtTcSearch.Location = new System.Drawing.Point(482, 108);
            this.txtTcSearch.MaxLength = 11;
            this.txtTcSearch.Name = "txtTcSearch";
            this.txtTcSearch.Size = new System.Drawing.Size(109, 13);
            this.txtTcSearch.TabIndex = 70;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(482, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(109, 1);
            this.panel2.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.label3.Location = new System.Drawing.Point(382, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 68;
            this.label3.Text = "Üye TC Giriniz : ";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReset.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReset.Location = new System.Drawing.Point(225, 460);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 31);
            this.btnReset.TabIndex = 66;
            this.btnReset.Text = "Tümünü Sil";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSave.Location = new System.Drawing.Point(120, 460);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 31);
            this.btnSave.TabIndex = 65;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.label1.Location = new System.Drawing.Point(96, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 36);
            this.label1.TabIndex = 64;
            this.label1.Text = "Randevu Saati\r\nseçiniz :";
            // 
            // dtpDateAppointment
            // 
            this.dtpDateAppointment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDateAppointment.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dtpDateAppointment.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
            this.dtpDateAppointment.CalendarTitleBackColor = System.Drawing.Color.Gainsboro;
            this.dtpDateAppointment.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dtpDateAppointment.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dtpDateAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateAppointment.Location = new System.Drawing.Point(204, 321);
            this.dtpDateAppointment.Name = "dtpDateAppointment";
            this.dtpDateAppointment.Size = new System.Drawing.Size(135, 20);
            this.dtpDateAppointment.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.label9.Location = new System.Drawing.Point(96, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 36);
            this.label9.TabIndex = 61;
            this.label9.Text = "Randevu Tarihi \r\nseçiniz:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.label10.Location = new System.Drawing.Point(96, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 36);
            this.label10.TabIndex = 60;
            this.label10.Text = "Diyetisyen \r\nseçiniz :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.label5.Location = new System.Drawing.Point(96, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 36);
            this.label5.TabIndex = 58;
            this.label5.Text = "Üye TC\'si\r\nseçiniz:";
            // 
            // txtMemberNameSurname
            // 
            this.txtMemberNameSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMemberNameSurname.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMemberNameSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMemberNameSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.txtMemberNameSurname.Location = new System.Drawing.Point(204, 177);
            this.txtMemberNameSurname.Name = "txtMemberNameSurname";
            this.txtMemberNameSurname.Size = new System.Drawing.Size(135, 13);
            this.txtMemberNameSurname.TabIndex = 57;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(204, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 1);
            this.panel1.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.label2.Location = new System.Drawing.Point(96, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 36);
            this.label2.TabIndex = 55;
            this.label2.Text = "Üye Ad-Soyad\r\ngiriniz:";
            // 
            // dataGridAppointment
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dataGridAppointment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridAppointment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridAppointment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridAppointment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridAppointment.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridAppointment.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridAppointment.Location = new System.Drawing.Point(385, 153);
            this.dataGridAppointment.Name = "dataGridAppointment";
            this.dataGridAppointment.Size = new System.Drawing.Size(377, 338);
            this.dataGridAppointment.TabIndex = 73;
            // 
            // btnAra
            // 
            this.btnAra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnAra.FlatAppearance.BorderSize = 0;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAra.Location = new System.Drawing.Point(606, 102);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(43, 31);
            this.btnAra.TabIndex = 71;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSil.Location = new System.Drawing.Point(654, 102);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(41, 31);
            this.btnSil.TabIndex = 72;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnList
            // 
            this.btnList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.btnList.FlatAppearance.BorderSize = 0;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnList.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnList.Location = new System.Drawing.Point(701, 102);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(61, 31);
            this.btnList.TabIndex = 85;
            this.btnList.Text = "Liste";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // comboUyeTC
            // 
            this.comboUyeTC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboUyeTC.FormattingEnabled = true;
            this.comboUyeTC.Location = new System.Drawing.Point(204, 112);
            this.comboUyeTC.Name = "comboUyeTC";
            this.comboUyeTC.Size = new System.Drawing.Size(135, 21);
            this.comboUyeTC.TabIndex = 86;
            this.comboUyeTC.SelectionChangeCommitted += new System.EventHandler(this.comboUyeTC_SelectionChangeCommitted_1);
            // 
            // comboDoctor
            // 
            this.comboDoctor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboDoctor.FormattingEnabled = true;
            this.comboDoctor.Location = new System.Drawing.Point(204, 246);
            this.comboDoctor.Name = "comboDoctor";
            this.comboDoctor.Size = new System.Drawing.Size(135, 21);
            this.comboDoctor.TabIndex = 87;
            // 
            // comboDateTime
            // 
            this.comboDateTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboDateTime.FormattingEnabled = true;
            this.comboDateTime.Items.AddRange(new object[] {
            "09:00",
            "09:45",
            "10:30",
            "11:15",
            "13:30",
            "14:15",
            "15:00",
            "15:45"});
            this.comboDateTime.Location = new System.Drawing.Point(204, 391);
            this.comboDateTime.Name = "comboDateTime";
            this.comboDateTime.Size = new System.Drawing.Size(135, 21);
            this.comboDateTime.TabIndex = 88;
            // 
            // FormAppointTake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(860, 595);
            this.Controls.Add(this.comboDateTime);
            this.Controls.Add(this.comboDoctor);
            this.Controls.Add(this.comboUyeTC);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.dataGridAppointment);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtTcSearch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDateAppointment);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMemberNameSurname);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAppointTake";
            this.Text = "Randevu Al";
            this.Load += new System.EventHandler(this.FormAppointTake_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAppointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTcSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateAppointment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMemberNameSurname;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridAppointment;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.ComboBox comboUyeTC;
        private System.Windows.Forms.ComboBox comboDoctor;
        private System.Windows.Forms.ComboBox comboDateTime;
    }
}