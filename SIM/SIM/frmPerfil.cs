using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIM
{
    public partial class frmPerfil : Form
    {
        public frmPrincipal principal;
        private readonly frmPrincipal _frmPrincipal;
        frmEditarPerfil telaEditarPerfil = new frmEditarPerfil();

        public frmPerfil(frmPrincipal frmPrincipal)
        {
            InitializeComponent();
            this._frmPrincipal = frmPrincipal;
            imgPerfilGrande.ImageLocation = @"FOTOS\Perfil\"+Constantes.idLogado+".png";
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 50)
            {
                panel1.Visible = false;
                imgPerfilGrande.Visible = true;
                btnEditarFotoPerfil.Visible = true;
                panel1.Width = 245;
                menuAnimator2.ShowSync(panel1);
                //logoAnimator.ShowSync(pictureBox1);
               
            }
            else
            {
                //logoAnimator.HideSync(pictureBox1);
                //pictureBox1.Visible = false;
                panel1.Visible = false;
                imgPerfilGrande.Visible = false;
                btnEditarFotoPerfil.Visible = false;
                panel1.Width = 50;
                menuAnimator1.ShowSync(panel1);

            }
        }

        public void SetImagemPerfil()
        {
            imgPerfilGrande.ImageLocation = @"FOTOS\Perfil\" + Constantes.idLogado + ".png";
            
        }

        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Title = "Selecione Imagem:";
            abrir.Filter = "png|*.png";
            if (abrir.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //verefica o tamanho do arquivo imag
                FileInfo info = new FileInfo(abrir.FileName);
                CopiarFoto cpy = new CopiarFoto();
                bool resultado = cpy.CopiarParaLocalDoAplicativo(info.FullName);
                if (resultado)
                {
                    this.SetImagemPerfil();
                    this._frmPrincipal.alterouFoto();
                    MessageBox.Show("Foto alterada com sucesso!"); 
                }
                else MessageBox.Show("Erro");
            }
        }

        private void btnEditarPerfil_Click_1(object sender, EventArgs e)
        {
            telaEditarPerfil.TopLevel = false;
            panel2.Controls.Clear();
            panel2.Controls.Add(telaEditarPerfil);
            telaEditarPerfil.FormBorderStyle = FormBorderStyle.None;
            telaEditarPerfil.Dock = DockStyle.None;
            telaEditarPerfil.Anchor = AnchorStyles.None;
            //telaEditarPerfil.Location = new Point(painelConteudoCentral.Width - telaEditarPerfil.Size.Width, painelConteudoCentral.Height / 2 - telaEditarPerfil.Size.Height / 2);
            //telaEditarPerfil.principal = this;
            telaEditarPerfil.Show();
        }
    }
}
