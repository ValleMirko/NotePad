using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormVaiAllaRiga : Form
    {
        public int NumeroRiga;

        private int totRighe;
        private bool isCancel = true;

        public FormVaiAllaRiga(int tr, int riga)
        {
            totRighe = tr;
            InitializeComponent();
            NumeroRiga = riga + 1;
            txtNumeroRiga.Text = NumeroRiga.ToString();
        }

        private void FormVaiAllaRiga_Load(object sender, EventArgs e)
        {

        }

        private void btnVaiA_Click(object sender, EventArgs e)
        {
            NumeroRiga = txtNumeroRiga.Text != "" && txtNumeroRiga.Text != "0" ? int.Parse(txtNumeroRiga.Text) : int.MaxValue;
            isCancel = false;

        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNumeroRiga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                errorProvider1.SetError((Control)sender, "Carattere non ammesso");
                e.Handled = true;
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void FormVaiAllaRiga_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (NumeroRiga > totRighe && !isCancel)
            {
                MessageBox.Show("Numero di riga maggiore del numero di righe totale","BloccoNote VaiAllaRiga");
                isCancel = true;
                e.Cancel = true;
            }
        }
    }
}
