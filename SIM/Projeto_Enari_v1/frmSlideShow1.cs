using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Enari_v1
{
    public partial class frmSlideShow1 : Form
    {
        public frmSlideShow1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Left == 10)
            {
                // slideA.Visible = false;
                slideTransition.HideSync(pictureBox1,true);
                pictureBox1.Left = -300;

                pictureBox2.Visible = false;
                pictureBox2.Left = 10;
                slideTransition2.ShowSync(pictureBox2,true);
                

                //slideB.Visible = false;
                //slideB.Left = 30;
                ////slideB.Visible = true;
                //loginTransition.ShowSync(slideB);

                ////bunifuSeparator1.Visible = false;
                //loginTransition.HideSync(bunifuSeparator1);
                //bunifuSeparator1.Left = bunifuThinButton22.Left;
                //bunifuSeparator1.Width = bunifuThinButton22.Width;

                //loginTransition.ShowSync(bunifuSeparator1);
            }

            timer1.Enabled = false;
            timer2.Enabled = true;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pictureBox2.Left == 10)
            {
                slideTransition.HideSync(pictureBox2,true);
                pictureBox2.Left = -300;

                pictureBox3.Visible = false;
                pictureBox3.Left = 10;
                slideTransition.ShowSync(pictureBox3,true);

            }
            timer2.Enabled = false;
            timer3.Enabled = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (pictureBox3.Left == 10)
            {
                slideTransition.HideSync(pictureBox3,true);
                pictureBox3.Left = -300;

                pictureBox1.Visible = false;
                pictureBox1.Left = 10;
                slideTransition.ShowSync(pictureBox1,true);

            }
            timer3.Enabled = false;
            timer1.Enabled = true;
        }
    }
}
