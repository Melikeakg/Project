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
using System.IO;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;


namespace Project.Forms
{
    public partial class FormMemberCodeEncode : Form
    {

        Baglanti baglanti = new Baglanti();

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice = new VideoCaptureDevice();

        public FormMemberCodeEncode()
        {
            InitializeComponent();
            LoadTheme();
        }
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

        private void FormMemberCodeEncode_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                comboxKamera.Items.Add(filterInfo.Name);
                comboxKamera.SelectedIndex = 0;
            }
            
           
        }

        private void btnKamera_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[comboxKamera.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBoxKamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBoxKamera.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBoxKamera.Image);
                if (result != null)
                {
                    txtKisi.Text = result.ToString();
                    timer1.Stop();
                    if (captureDevice.IsRunning)
                    {
                        captureDevice.Stop();
                    }
                }
            }
        }

        void populateComboAd()
        {
            SqlConnection Con = new SqlConnection(baglanti.Adres);
            string query = "Select * from Member where UyeAdSoyad Like '%" + txtKisi.Text + "%' ";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("UyeAdSoyad", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                comboxAdSoyad.ValueMember = "UyeAdSoyad";
                comboxAdSoyad.DataSource = dt;
                Con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        void populateComboTarih()
        {
            SqlConnection Con = new SqlConnection(baglanti.Adres);
            string query = "Select * from Member where UyeAdSoyad Like '%" + txtKisi.Text + "%'";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("KayitSuresi", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                comboxTarih.ValueMember = "KayitSuresi";
                comboxTarih.DataSource = dt;
                Con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        void populateComboGirisHakki()
        {
            SqlConnection Con = new SqlConnection(baglanti.Adres);
            string query = "Select * from Enter where UyeAdSoyad Like '%" + txtKisi.Text + "%'";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("GirisHakki", typeof(int));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                comboxGirisHakki.ValueMember = "GirisHakki";
                comboxGirisHakki.DataSource = dt;
                Con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
       


        private void btnGiris_Click(object sender, EventArgs e)
        {
            populateComboTarih();
            populateComboAd();
            populateComboGirisHakki();

            SqlConnection Con = new SqlConnection(baglanti.Adres);

            if (captureDevice == null)
            {
                MessageBox.Show("Karekod okutulmadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtKisi.Text=="")
            {
                MessageBox.Show("Lütfen karekod okutun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (comboxGirisHakki.Text != "0")
            {
                populateComboGirisHakki();
                Con.Open();
                SqlCommand cmd2 = new SqlCommand("Update Enter set GirisHakki=GirisHakki-1 where UyeAdSoyad like '%" + txtKisi.Text + "%'", Con);
                cmd2.ExecuteNonQuery();
                Con.Close();
           
                populateComboGirisHakki();
                label1.Text = txtKisi.Text + " üyeliğinizin bitiş tarihi " + comboxTarih.Text + " bu ay " + comboxGirisHakki.Text + " giriş hakkınız kaldı";
                MessageBox.Show(label1.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                pictureBoxKamera.Image = null;
                txtKisi.Text = "";
                comboxAdSoyad.Text = "";
                comboxGirisHakki.Text = "";
                comboxTarih.Text = "";

            }
            else
            {
                MessageBox.Show("Üyelik hakkınız bitmiştir. Hoşçakalın", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                pictureBoxKamera.Image = null;
                txtKisi.Text = "";
                comboxAdSoyad.Text = "";
                comboxGirisHakki.Text = "";
                comboxTarih.Text = "";
            }

        }

        private void FormMemberCodeEncode_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
            {
                captureDevice.Stop();
            }
        }

    }
}















