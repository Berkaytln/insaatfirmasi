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
    public partial class FrmSahaBolumu : Form
    {
        public FrmSahaBolumu()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(cbsahabolumu)) return;
            DialogResult = DialogResult.OK; 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           
            DialogResult= DialogResult.Cancel;
        }

        private bool ErrorControl(Control c)
        {
          

            if (c is ComboBox)
            {
                ComboBox comboBox = (ComboBox)c;

                
                if (comboBox.SelectedIndex == -1)
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi girdiniz!");
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

        private void cbsahabolumu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
    

