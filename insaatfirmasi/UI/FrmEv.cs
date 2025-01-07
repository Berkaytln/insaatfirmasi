using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static insaatfirmasi.Anaform;

namespace insaatfirmasi.UI
{
    public partial class FrmEv : Form
    {

        public object ID { get; internal set; }
        public object Fiyat { get; internal set; }
        public object Ay { get; internal set; }
        public object MetreKare { get; internal set; }

        public FrmEv()
        {
            InitializeComponent();
        }
        public Ev ev { get; set; }

    



        private void FrmEv_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(nmAy))
            {
                return;
            }
            if (!ErrorControl(nmFiyat))
            {
                return;
            }
            if (!ErrorControl(nmMetrekare))
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