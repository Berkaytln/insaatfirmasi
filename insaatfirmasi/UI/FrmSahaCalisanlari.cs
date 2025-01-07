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
    public partial class FrmSahaCalisanlari : Form
    {
        public FrmSahaCalisanlari()
        {
            InitializeComponent();
        }
        public FrmSahaCalisanlari SahaCalisanlari { get; set; }
       


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            if (!ErrorControl(txtAd)) return;
            if (!ErrorControl(txtSahaCalisanlariSoyad)) return;
          
           
            DialogResult = DialogResult.OK; 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;      
        }
        private bool ErrorControl(Control c)
        {

            if (c is TextBox)
            {
                if (c.Text == "")
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

        private void txtSahaCalisanlariSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSahaCalisanlariAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmSahaCalisanlari_Load(object sender, EventArgs e)
        {

        }
    }
}
