using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace donanımtanıma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            frmkapat cikis = new frmkapat();
            cikis.Show();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            about about = new about();
            about.Show();
            this.Hide();
        }
        
        private void bunifuImageButton2_Click_2(object sender, EventArgs e)
        {
            about about = new about();
            about.Show();
            this.Hide();

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            SoundPlayer a = new SoundPlayer();
            string b = "sound\\monitör.wav";
            a.SoundLocation = b;
            a.Play();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            SoundPlayer a = new SoundPlayer();
            string b = "sound\\mouse.wav";
            a.SoundLocation = b;
            a.Play();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            SoundPlayer a = new SoundPlayer();
            string b = "sound\\klavye.wav";
            a.SoundLocation = b;
            a.Play();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            SoundPlayer a = new SoundPlayer();
            string b = "sound\\kasa.wav";
            a.SoundLocation = b;
            a.Play();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            SoundPlayer a = new SoundPlayer();
            string b = "sound\\laptop.wav";
            a.SoundLocation = b;
            a.Play();
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            SoundPlayer a = new SoundPlayer();
            string b = "sound\\projeksiyon.wav";
            a.SoundLocation = b;
            a.Play();
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
            SoundPlayer a = new SoundPlayer();
            string b = "sound\\yazıcı.wav";
            a.SoundLocation = b;
            a.Play();
        }

        private void bunifuImageButton11_Click(object sender, EventArgs e)
        {
            SoundPlayer a = new SoundPlayer();
            string b = "sound\\hoparlör.wav";
            a.SoundLocation = b;
            a.Play();
        }
    }
}
