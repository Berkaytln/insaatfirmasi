using insaatfirmasi.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using insaatfirmasi.BL;
namespace insaatfirmasi

{
    public partial class Anaform : Form
    {

        public Anaform()
        {
            InitializeComponent();
        }


        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void btnMusteriDuzenle_Click(object sender, EventArgs e)
        {


            DataGridViewRow row = dataGridView1.SelectedRows[0];

            FrmMusteriler frmMusteri = new FrmMusteriler()
            {
                Text = "Müşteri Düzenle",
                
                Musteri = new Musteri()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Ad = row.Cells[1].Value.ToString(),
                    Soyad = row.Cells[2].Value.ToString(),
                },

            };
            var sonuc = frmMusteri.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MüşteriGüncelle(frmMusteri.Musteri);

                if (b)
                {

                    DataSet ds = BLogic.MüşteriGetir("");
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }

        }

        private void btnMusteriEkle1(object sender, EventArgs e)
        {
            FrmMusteriler frmMusteri = new FrmMusteriler()
            {
                Text = "Müşteri Ekle",
                Musteri = new Musteri() { ID = Guid.NewGuid() },
            };
            tekrar:
            var sonuc = frmMusteri.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MüşteriEkle(frmMusteri.Musteri);

                if (b)
                {

                    DataSet ds = BLogic.MüşteriGetir("");
                    dataGridView1.DataSource = ds.Tables[0];
                }
                else
                    goto tekrar;
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMusteriBul_Click(object sender, EventArgs e)
        {

            DataSet ds = BLogic.MüşteriGetir(txtaramayeri.Text);
            
            if(ds != null)
                    {
            dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void Anaform_Load(object sender, EventArgs e)
        {

            DataSet ds1 = BLogic.MüşteriGetir("");

            if (ds1 != null)
                dataGridView1.DataSource = ds1.Tables[0];

            DataSet ds2 = BLogic.EvGetir("");
            if (ds2 != null)

                dataGridView2.DataSource = ds2.Tables[0];

            this.BackColor = Color.LightCyan;
            btnMusteriEkle.BackColor = Color.PaleGreen;
            btnMusteriEkle.ForeColor = Color.DarkOliveGreen;
            btnMusteriDuzenle.BackColor = Color.SkyBlue;
            btnMusteriDuzenle.ForeColor = Color.Black; 
            btnMusteriBul.BackColor = Color.SkyBlue;
            btnMusteriBul.ForeColor = Color.DarkBlue;
            btnEvEkle.BackColor = Color.PaleGreen;
            btnEvEkle.ForeColor = Color.DarkSlateBlue;
            btnEvSil.BackColor = Color.Tomato;
            btnEvSil.ForeColor = Color.WhiteSmoke;
        }





        private void btnEvSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir Ev seçin.");
                return;
            }

            DataGridViewRow row = dataGridView1.SelectedRows[0];

            if (row.Cells[0].Value == null)
            {
                MessageBox.Show("ID değeri bulunamadı.");
                return;
            }

            string id = row.Cells[0].Value.ToString(); 

            DialogResult sonuc = MessageBox.Show("Bu Kaydı Silmek mi İstiyorsunuz?",
                                                 "Silme Onayı",
                                                 MessageBoxButtons.OKCancel,
                                                 MessageBoxIcon.Question);

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MüşteriSil(id);

                if (b)
                {
                    DataSet ds = BLogic.MüşteriGetir("");
                    dataGridView1.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("Müşteri silinemedi.");
                }
            }
        }

        private void toolStrip1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir müşteri seçin.");
                return;
            }

            DataGridViewRow row = dataGridView1.SelectedRows[0];

            if (row.Cells[0].Value == null)
            {
                MessageBox.Show("ID değeri bulunamadı.");
                return;
            }

            string id = row.Cells[0].Value.ToString(); 

            DialogResult sonuc = MessageBox.Show("Bu Kaydı Silmek mi İstiyorsunuz?",
                                                 "Silme Onayı",
                                                 MessageBoxButtons.OKCancel,
                                                 MessageBoxIcon.Question);

            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MüşteriSil(id);

                if (b)
                {
                    DataSet ds = BLogic.MüşteriGetir("");
                    dataGridView1.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("Müşteri silinemedi.");
                }
            }
        }

        private void toolStrip2_Click(object sender, EventArgs e)
        {

        }

        private void btnEvEkle_Click(object sender, EventArgs e)
        {
            FrmEv frmev = new FrmEv()
            {
                Text = "Ev Ekle",
                ev = new Ev() { ID = Guid.NewGuid() },
            };

            var sonuc = frmev.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.EvEkle(frmev);

                if (b)
                {

                    DataSet ds = BLogic.EvGetir("");
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private void btnmusteriduzenle2(object sender, EventArgs e)
        {

        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {

        }

        private void btnEvDuzenle2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}

