using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM
{
    public partial class frmMessageBox : Form
    {
        public frmMessageBox(string msg, char tipo)
        {
            

            InitializeComponent();

            if (tipo == 'f')
            {
                picIcon.Image = Properties.Resources.fail;
                lblMensagem.ForeColor = Color.Red;
                this.BackColor = Color.Red;
                btnOK.Normalcolor = Color.DarkRed;
                btnOK.OnHovercolor = Color.Red;
                btnOK.Activecolor = Color.Red;
            }
            else if (tipo == 'a')
            {
                picIcon.Image = Properties.Resources.alert;
                lblMensagem.ForeColor = Color.Gold;
                this.BackColor = Color.Gold;
                btnOK.Normalcolor = Color.Orange;
                btnOK.OnHovercolor = Color.Gold;
                btnOK.Activecolor = Color.Gold;
            }
            else //aqui é melhor usar o 's' para manter padrao
            {
                picIcon.Image = Properties.Resources.success;
                lblMensagem.ForeColor = Color.LimeGreen;
                this.BackColor = Color.LimeGreen;
                btnOK.Normalcolor = Color.SeaGreen;
                btnOK.OnHovercolor = Color.LimeGreen;
                btnOK.Activecolor = Color.LimeGreen;
            }
            lblMensagem.Text = msg;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Dispose();
        }
    }
}
