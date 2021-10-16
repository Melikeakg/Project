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
    public partial class FormMoney : Form
    {
        Baglanti baglanti = new Baglanti();
        public FormMoney()
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
                dt.Columns.Add("UyeTC", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                comboUyeTC.ValueMember = "UyeTC";
                comboUyeTC.DataSource = dt;
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
            string query = "Select * from Member where UyeTC =" + comboUyeTC.SelectedValue.ToString() + "";

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
        private void populate()
        {
            SqlConnection Con = new SqlConnection(baglanti.Adres);
            Con.Open();
            string query = "select * from Payment";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridPayment.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void FormMoney_Load(object sender, EventArgs e)
        {
            populate();
            populateCombo();
        }

        private void comboUyeTC_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchMemberName();

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (comboUyeTC.Text == "" || txtMemberNameSurname.Text == "" || txtPayAmount.Text == "" || dtpPayAppointment.Text == "")
            {
                MessageBox.Show("Eksik Alan Girdiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                SqlConnection Con = new SqlConnection(baglanti.Adres);
                Con.Open();
                string query = "insert into Payment values('" + comboUyeTC.Text + "','" + txtMemberNameSurname.Text + "','" + txtPayAmount.Text + "','" + dtpPayAppointment.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ödeme yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Con.Close();
                populate();

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            comboUyeTC.ResetText();
            txtMemberNameSurname.Clear();
            txtPayAmount.ResetText();
            dtpPayAppointment.Value = DateTime.Now;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtTcSearch.Text != "")
            {
                SqlConnection Con = new SqlConnection(baglanti.Adres);
                Con.Open();
                string query = "select * from Payment where UyeTC = " + txtTcSearch.Text + "";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder();
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridPayment.DataSource = ds.Tables[0];
                Con.Close();
            }
            else
            {
                MessageBox.Show("Lütfen TC  Giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            populate();
            txtTcSearch.Text = "";
        }
    }
}