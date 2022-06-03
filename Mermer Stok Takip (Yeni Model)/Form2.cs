using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mermer_Stok_Takip__Yeni_Model_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti;
        OleDbCommand sorgu;
        OleDbDataReader veri;
        public void Baglanti()
        {
            try
            {
                baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Veritabani.mdb");
                baglanti.Open();
            }
            catch (Exception w)
            {
                MessageBox.Show(w.Message);
            }
        }
        private void btEkle_Click(object sender, EventArgs e)
        {
            baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bilgi.mdb");
            baglanti.Open();

            OleDbCommand sorgu = new OleDbCommand();
            sorgu.CommandText = "insert into veriler(m_a,m_b,m_t) values ('" + tbMalzemeAdi.Text + "','" + cbBirim.Text + "','" + comboBox1.Text + "')";
            sorgu.Connection = baglanti;
            sorgu.ExecuteNonQuery();
            baglanti.Close();
            tbMalzemeAdi.Text = "";
            cbBirim.Text = "";
            comboBox1.Text = "";
            gvMalzemeler.Refresh();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bilgiDataSet1.veriler' table. You can move, or remove it, as needed.
            this.verilerTableAdapter.Fill(this.bilgiDataSet1.veriler);

        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bilgi.mdb");
        OleDbCommand sorguu;
        OleDbDataReader verii;
        private void button1_Click(object sender, EventArgs e)
        {
            int silineceksatir = gvMalzemeler.Rows.GetFirstRow(DataGridViewElementStates.Selected);

            string id = gvMalzemeler.Rows[silineceksatir].Cells[0].Value.ToString();
            string m_a = gvMalzemeler.Rows[silineceksatir].Cells[1].Value.ToString();
            string m_b = gvMalzemeler.Rows[silineceksatir].Cells[2].Value.ToString();
            string m_t = gvMalzemeler.Rows[silineceksatir].Cells[3].Value.ToString();

            baglanti.Open();
            String sqlsorgu = "delete from ekle where id=@id and m_a=@m_a and m_b=@m_b and m_t=@m_t";
            OleDbCommand sorgu = new OleDbCommand();
            sorgu.CommandText = sqlsorgu;
            sorgu.Connection = con;
            sorgu.Parameters.AddWithValue("@id", id);
            sorgu.Parameters.AddWithValue("@m_a", m_a);
            sorgu.Parameters.AddWithValue("@m_b", m_b);
            sorgu.Parameters.AddWithValue("@m_t", m_t);
            sorgu.ExecuteNonQuery();

            con.Close();

            gvMalzemeler.Rows.RemoveAt(silineceksatir);
            gvMalzemeler.ClearSelection();

            MessageBox.Show("Kaydınız Silinmiştir", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        }
    } 

