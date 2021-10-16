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
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode;
using AForge;
using AForge.Video.DirectShow;
using AForge.Video;
using ZXing;

namespace Project.Forms
{
    public partial class FormMemberCodeAdd : Form
    {

        Baglanti baglanti = new Baglanti();

        public FormMemberCodeAdd()
        {
            InitializeComponent();
            LoadTheme();
        }

        QRCodeEncoder code = new QRCodeEncoder();
        Image resim;
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


        void populateCombo()
        {
            SqlConnection Con = new SqlConnection(baglanti.Adres);
            string query = "SELECT * FROM Member";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("UyeID", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                comboUyeID.ValueMember = "UyeID";
                comboUyeID.DataSource = dt;
                Con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        string memberName;
        void fetchMemberName()
        {
            SqlConnection Con = new SqlConnection(baglanti.Adres);
            Con.Open();
            string query = "Select * from Member where UyeID =" + comboUyeID.SelectedValue.ToString() + "";

            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                memberName = dr["UyeAdSoyad"].ToString();
                txtMemberNameSurname.Text = memberName;
            }
            Con.Close();
        }

        private void FormMemberCodeAdd_Load(object sender, EventArgs e)
        {
            populateCombo();
        }

        private void comboUyeID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchMemberName();
           
        }

      
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            resim = code.Encode(txtMemberNameSurname.Text);
            pictureBoxQr.Image = resim;

            SqlConnection Con = new SqlConnection(baglanti.Adres);

            
            Con.Open();
            int sayac = 7;
            string query = "insert into Enter values('" + comboUyeID.Text + "','" + sayac + "','" + txtMemberNameSurname.Text + "')";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            Con.Close();

        }

        private void btnIndir_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "(*.jpeg)|*.jpg";
            DialogResult dr = save.ShowDialog();
            if (dr == DialogResult.OK)
            {
                pictureBoxQr.Image.Save(save.FileName);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(baglanti.Adres);
            Con.Open();
            SqlCommand cmd = new SqlCommand("Update Enter set GirisHakki=7 where UyeAdSoyad like '%" + txtMemberNameSurname.Text + "%'", Con);
            cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Üyelik hakkı güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSee_Click(object sender, EventArgs e)
        {
            resim = code.Encode(txtMemberNameSurname.Text);
            pictureBoxQr.Image = resim;
        }
    }
}

