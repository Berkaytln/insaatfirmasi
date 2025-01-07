using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insaatfirmasi.UI
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        public Musteri Musteri { get; set; }
        public bool Güncelleme { get; set; } = false;

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtMusteriAd)) return;
            if (!ErrorControl(txtMusteriSoyad)) return;
            DialogResult = DialogResult.OK;
            Musteri.Ad = txtMusteriAd.Text;
            Musteri.Soyad= txtMusteriSoyad.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;  
        }

       private bool ErrorControl(Control c) { 
        
        if (c is TextBox )
            {
            if(c.Text == "")
                {

                    errorProvider1.SetError(c, "eksik veya hatalı bilgi girdiniz !");
                    c.Focus();
                    return false;
                }
            else
                {
                    errorProvider1.SetError(c, "");
                    return true;   

                }

            
            }
        return true;    

        }

        private void FrmMusteriler_Load(object sender, EventArgs e)
        {
            txtID.Text = Musteri.ID.ToString();
            ;

            if (Güncelleme)
            { 
            txtMusteriAd.Text = Musteri.Ad;
                txtMusteriSoyad.Text = Musteri.Soyad;

            }
        }
    }
}
