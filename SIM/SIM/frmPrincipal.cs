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
using System.Xml.Serialization;

namespace SIM
{
    public partial class frmPrincipal : Form
    {
        frmSlideShow1 slideShow = new frmSlideShow1();
        frmLogin telaLogin = new frmLogin();
        

        public frmPrincipal()
        {
            InitializeComponent();

           
            telaLogin.TopLevel = false;
            painelConteudoCentral.Controls.Clear();
            painelConteudoCentral.Controls.Add(telaLogin);
            telaLogin.FormBorderStyle = FormBorderStyle.None;
            telaLogin.Dock = DockStyle.None;
            telaLogin.Anchor = AnchorStyles.None;
            telaLogin.Location = new Point(painelConteudoCentral.Width - telaLogin.Size.Width, painelConteudoCentral.Height / 2 - telaLogin.Size.Height / 2);
            telaLogin.principal = this;
            telaLogin.Show();

            // Slideshow
            
            slideShow.TopLevel = false;
            //painelConteudoCentral.Controls.Clear();
            painelConteudoCentral.Controls.Add(slideShow);
            slideShow.FormBorderStyle = FormBorderStyle.None;
            slideShow.Dock = DockStyle.None;
            slideShow.Anchor = AnchorStyles.None;
            //slideShow.Location = new Point(painelConteudoCentral.Width - slideShow.Size.Width, painelConteudoCentral.Height / 2 - slideShow.Size.Height / 2);
            slideShow.Show();

            if(File.Exists(@"XML\Usuarios.xml")) // talvez precise checar a existencia de todos
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Usuario>));
                XmlSerializer serializer2 = new XmlSerializer(typeof(List<Perfil>));

                FileStream stream = File.OpenRead(@"XML\Usuarios.xml");
                Usuario.UserList = (List<Usuario>)serializer.Deserialize(stream);

                FileStream stream2 = File.OpenRead(@"XML\Perfil.xml");
                Perfil.ProfileList = (List<Perfil>)serializer2.Deserialize(stream2);

                Usuario.lastID = Convert.ToInt32(File.ReadAllText(@"XML\LastID.xml"));
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message="";
            for(int i=0; i<Usuario.UserList.Count; i++)
            {
                message += string.Join(Environment.NewLine, Usuario.UserList[i].Username, Usuario.UserList[i].Email, Usuario.UserList[i].Tipo);
                message += "\r\n\n";
            }
            MessageBox.Show(message);
        }


        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            XmlSerializer serialiser = new XmlSerializer(typeof(List<Usuario>));
            XmlSerializer serialiser2 = new XmlSerializer(typeof(List<Perfil>));

            TextWriter Filestream = new StreamWriter(@"XML\Usuarios.xml");
            serialiser.Serialize(Filestream, Usuario.UserList);
            Filestream.Close();

            TextWriter Filestream2 = new StreamWriter(@"XML\LastID.xml");
            Filestream2.WriteLine(Convert.ToString(Usuario.lastID));
            Filestream2.Close();

            TextWriter Filestream3 = new StreamWriter(@"XML\Perfil.xml");
            serialiser2.Serialize(Filestream3, Perfil.ProfileList);
            Filestream3.Close();


            slideShow.Close();
            this.Close();

            //Application.Exit();
        }

        private void painelConteudoCentral_Paint(object sender, PaintEventArgs e)
        {

        }

        //public static void entrou(bool logou)
        //{
        //    if(logou == true)
        //    {
        //        //painelBarraTitulo.Visible = false;
        //        //painelBarraTitulo.Height = 50;
        //        //painel .ShowSync(panel1);
        //    }
        //}

        public void logou(int id)
        {
            painelBarraTitulo.Height = 50;
            picBoxLogoTelaLogin.Width = 78;
            picBoxLogoTelaLogin.Height = 50;
            bunifuMaterialTextbox1.Visible = true;
            lblNomeUsuario.Visible = true;

            //panel1.Visible = true;
            frmPerfil telaPerfil = new frmPerfil(this);
            telaPerfil.TopLevel = false;
            painelConteudoCentral.Controls.Clear();
            painelConteudoCentral.Controls.Add(telaPerfil);
            telaPerfil.FormBorderStyle = FormBorderStyle.None;
            telaPerfil.Dock = DockStyle.Fill;
            telaPerfil.SetImagemPerfil();

            telaPerfil.Show();

            //Atraves do id do usuario logado (recebido por parametro) busca o nome do usuario
            List <Usuario> resultado = Usuario.UserList.FindAll(x => x.id == Convert.ToString(id));
            lblNomeUsuario.Text = resultado[0].Username;
            imgPerfilMiniatura.ImageLocation = @"FOTOS\Perfil\" + Constantes.idLogado + ".png";

        }

        public void alterouFoto()
        {
            imgPerfilMiniatura.ImageLocation = @"FOTOS\Perfil\" + Constantes.idLogado + ".png";
        }

        private void bunifuMaterialTextbox1_OnClick(object sender, EventArgs e)
        {
            bunifuMaterialTextbox1.Text = "";
        }
    }
}
