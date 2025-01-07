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
    public partial class FrmMaliyet : Form
    {
        public FrmMaliyet()
        {
            InitializeComponent();
        }
        public FrmMaaslar FrmMaaslar { get; set; }

        private void FrmMaliyet_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(nmMaliyet))
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
    }
}
