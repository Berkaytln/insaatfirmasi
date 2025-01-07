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
    public partial class FrmOfisCalisanlari : Form
    {
        public FrmOfisCalisanlari()
        {
            InitializeComponent();
        }
        public Ofisbolumu Ofisbolumu { get; set; }
        public Ofiscalisanlari Ofiscalisanlari { get; set; }    

        private void FrmOfisCalisanlari_Load(object sender, EventArgs e)
        {
           
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtOfisCalisanlariAd)) return;
            if (!ErrorControl(txtOfisCalisanlariSoyad)) return;
        
          //  FrmOfisCalisanlari.Ad=txtOfisCalisanlariAd.Text;

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


        }
}
