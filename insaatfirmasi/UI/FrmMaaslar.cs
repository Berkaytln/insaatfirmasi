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
    public partial class FrmMaaslar : Form
    {
        public FrmMaaslar()
        {
            InitializeComponent();
        }

        public FrmSahaCalisanlari SahaCalisanlari { get; set; }
        public FrmOfisCalisanlari OfisCalisanlari { get; set; }

        private void FrmMaaslar_Load(object sender, EventArgs e)
        {
        
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
           
            if (!ErrorControl(nmMaaslar))
            {
                return;  
            }

         
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           
            DialogResult = DialogResult.Cancel;
        }

      
        private bool ErrorControl(Control c)
        {
            // Eğer c bir NumericUpDown ise
            if (c is NumericUpDown)
            {
                NumericUpDown nud = (NumericUpDown)c;


                if (nud.Value <= 0)
                {
                    errorProvider1.SetError(c, "Maas bilgisi sıfırdan büyük olmalıdır!");
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

        private void nmMaaslar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
