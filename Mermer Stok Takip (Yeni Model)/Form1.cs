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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string kullanıcıadı="";
        public static string  şifre="";
        OleDbConnection bağlantı;
        OleDbCommand sorgu;
        OleDbDataReader veri;
        private void kullaniciBilgileriniKontrolEt()
        {
            try
            {
                bağlantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= veri.mdb");
                bağlantı.Open();
                sorgu = new OleDbCommand();
                sorgu.CommandText = "select * from bilgi where k_a='" + tb1.Text + "' and k_s='" + tb2.Text + "'";
                sorgu.Connection = bağlantı;
                veri = sorgu.ExecuteReader();
                if (veri.Read())
                {
                    Form2 fr2 = new Form2();
                    fr2.ShowDialog();
                }
                else
                {
                    if (tb1.Text == "")
                    {
                        MessageBox.Show("Kullanıcı adınızı boş bıraktınız", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (tb2.Text == "")
                    {
                        MessageBox.Show("Şifrenizi boş bıraktınız", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (tb1.Text != tb2.Text)
                    {
                        MessageBox.Show("Kullanıcı Adı Ve Şifreniz Yanlış", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("GİRİŞ BAŞARISIZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception w)
            {

                int sil = 0;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            kullaniciBilgileriniKontrolEt();
        }
    }
}
