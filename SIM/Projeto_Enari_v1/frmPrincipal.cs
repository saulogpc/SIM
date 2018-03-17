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

namespace Projeto_Enari_v1
{
    public partial class frmPrincipal : Form
    {
        
        public frmPrincipal()
        {
            InitializeComponent();

            frmLogin telaLogin = new frmLogin();
            telaLogin.TopLevel = false;
            //painelConteudoCentral.Controls.Clear();
            painelConteudoCentral.Controls.Add(telaLogin);
            telaLogin.FormBorderStyle = FormBorderStyle.None;
            telaLogin.Dock = DockStyle.None;
            telaLogin.Anchor = AnchorStyles.None;
            telaLogin.Location = new Point(painelConteudoCentral.Width - telaLogin.Size.Width, painelConteudoCentral.Height / 2 - telaLogin.Size.Height / 2);
            telaLogin.Show();

            //// Slideshow
            //frmSlideShow1 slideShow = new frmSlideShow1();
            //slideShow.TopLevel = false;
            ////painelConteudoCentral.Controls.Clear();
            //painelConteudoCentral.Controls.Add(slideShow);
            //slideShow.FormBorderStyle = FormBorderStyle.None;
            //slideShow.Dock = DockStyle.None;
            //slideShow.Anchor = AnchorStyles.None;
            ////slideShow.Location = new Point(painelConteudoCentral.Width - slideShow.Size.Width, painelConteudoCentral.Height / 2 - slideShow.Size.Height / 2);
            //slideShow.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Usuario.lastID + 1;
            Usuario user = new Usuario(Convert.ToString(id), textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            Usuario.Adicionar(user);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message="";
            for(int i=0; i<Usuario.UserList.Count; i++)
            {
                message += string.Join(Environment.NewLine, Usuario.UserList[i].Username, Usuario.UserList[i].Email);
                message += "\n";
            }
            MessageBox.Show(message);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XmlSerializer serialiser = new XmlSerializer(typeof(List<Usuario>));
            TextWriter Filestream = new StreamWriter(@"XML\Usuarios.xml");
            serialiser.Serialize(Filestream, Usuario.UserList);
            //Filestream.WriteLine("\r\n<LastID>" + Convert.ToString(Usuario.lastID) + "</LastID>");
            Filestream.Close();
            TextWriter Filestream2 = new StreamWriter(@"XML\LastID.xml");
            Filestream2.WriteLine(Convert.ToString(Usuario.lastID));
            Filestream2.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Usuario>));
            FileStream stream = File.OpenRead(@"XML\Usuarios.xml");
            Usuario.UserList = (List<Usuario>)serializer.Deserialize(stream);
            Usuario.lastID=Convert.ToInt32(File.ReadAllText(@"XML\LastID.xml"));

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Usuario.Remover(Usuario.UserList[Usuario.UserList.Count-1]);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<Usuario> resBusca = Usuario.Buscar(textBox5.Text);
            string message = resBusca[0].Username;
            MessageBox.Show(message);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
