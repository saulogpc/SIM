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
    public partial class frmLogin : Form
    {
        string tipoUsuario="";
        int login;
        public frmPrincipal principal;

        public frmLogin()
        {
            InitializeComponent();
            //this.tip = new customToolTip();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (slideB.Left == 508)
            {
                // slideA.Visible = false;
                loginTransition.Hide(slideA,true);
                slideA.Left = 508;

                slideB.Visible = false;
                slideB.Left = 30;
                //slideB.Visible = true;
                loginTransition.Show(slideB,true);

                bunifuSeparator1.Visible = false;
                //loginTransition.Hide(bunifuSeparator1,true);
                bunifuSeparator1.Left = bunifuThinButton22.Left;
                bunifuSeparator1.Width = bunifuThinButton22.Width;
                
                loginTransition.Show(bunifuSeparator1,true);
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (slideA.Left == 508)
            {
                //slideB.Visible = false;
                loginTransition.Hide(slideB,true);
                slideB.Left = 508;

                slideA.Visible = false;
                slideA.Left = 30;
                //slideA.Visible = true;
                loginTransition.Show(slideA,true);

                bunifuSeparator1.Visible = false;
                //loginTransition.Hide(bunifuSeparator1,true);
                bunifuSeparator1.Left = bunifuThinButton21.Left;
                bunifuSeparator1.Width = bunifuThinButton21.Width;

                loginTransition.Show(bunifuSeparator1,true);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if(bunifuCheckbox1.Checked == true)
            {
                bunifuCheckbox2.Checked = false;
                tipoUsuario = "empresa";
            }
        }

        private void bunifuCheckbox2_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox2.Checked == true)
            {
                bunifuCheckbox1.Checked = false;
                tipoUsuario = "pessoa";
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked == true)
            {
                tipoUsuario = "empresa";
            }

            if (bunifuCheckbox2.Checked == true)
            {
                tipoUsuario = "pessoa";
            }

            int id = Usuario.lastID + 1;
            Usuario user = new Usuario(Convert.ToString(id), bunifuMetroTextbox1.Text, bunifuMetroTextbox2.Text, bunifuMetroTextbox3.Text, tipoUsuario);
            Usuario.Adicionar(user);
            Perfil profile = new Perfil(Convert.ToString(id), bunifuMetroTextbox1.Text, "-1");
            Perfil.Adicionar(profile);
            frmMessageBox msg = new frmMessageBox("Usuário Cadastrado com sucesso!", 's');
            msg.ShowDialog();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            this.login = Usuario.Logar(txtUserNameEntrar.Text, txtPasswordEntrar.Text);
            if(login!=-1)
            {
                frmMessageBox msg = new frmMessageBox("Usuário "+txtUserNameEntrar.Text+" Logado com Sucesso!", 's');
                msg.ShowDialog();
                Constantes.idLogado = this.login;
                if (principal != null) principal.logou(this.login);
            }
            else
            {
                frmMessageBox msg = new frmMessageBox("Usuário ou Senha Incorreta!", 'f');
                msg.ShowDialog();
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.pictureBox1, "Agora vai!");
        }
    }
}
