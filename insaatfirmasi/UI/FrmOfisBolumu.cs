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
    public partial class FrmOfisBolumu : Form
    {
        public FrmOfisBolumu()
        {
            InitializeComponent();
        }
        public Ofisbolumu Ofisbolumu { get; set;}



        private void btnOK_Click(object sender, EventArgs e)
        {
          if(!ErrorControl(cbofisbolumu)) return;
        // Ofisbolumu.Bolumu=cbofisbolumu.Text;
            
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

        }
}
