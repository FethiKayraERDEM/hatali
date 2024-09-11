using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÖDEVV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void BTNB_CheckedChanged(object sender, EventArgs e)
        {
            BTNA.Enabled = false;
            BTNB.Enabled = false;
            BTNc.Enabled = false;
            BTND.Enabled = false;
            label5.Text=BTNB.Text;
            BTNSonraki.Enabled = true;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LBLDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LBLYanlıs.Text = yanlis.ToString(); 
                pictureBox2.Visible = true;
            }
        }

        private void BTNc_CheckedChanged(object sender, EventArgs e)
        {
            BTNA.Enabled = false;
            BTNB.Enabled = false;
            BTNc.Enabled = false;
            BTND.Enabled = false;
            label5.Text = BTNc.Text;
            BTNSonraki.Enabled = true;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LBLDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LBLYanlıs.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BTND_CheckedChanged(object sender, EventArgs e)
        {
            BTNA.Enabled = false;
            BTNB.Enabled = false;
            BTNc.Enabled = false;
            BTND.Enabled = false;
            label5.Text = BTND.Text;
            BTNSonraki.Enabled = true;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LBLDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LBLYanlıs.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BTNA_CheckedChanged(object sender, EventArgs e)
        {
            BTNA.Enabled = false;
            BTNB.Enabled = false;
            BTNc.Enabled = false;
            BTND.Enabled = false;
            label5.Text = BTNA.Text;
            BTNSonraki.Enabled = true;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LBLDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LBLYanlıs.Text = yanlis.ToString();     
                pictureBox2.Visible = true;                     
            }
        }
        private void BTNSonraki_Click(object sender, EventArgs e)
        {
            BTNA.Enabled = true;
            BTNB.Enabled = true;
            BTNc.Enabled = true;
            BTND.Enabled = true;
            BTNSonraki.Enabled = false; 
            pictureBox1 .Visible =false;
            pictureBox2.Visible =false;     

            soruno++;
            LBLSoruno.Text = soruno.ToString();
            if(soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir?";
                BTNA.Text = "1920"; 
                BTNB.Text = "1921";
                BTNc.Text = "1922";
                BTND.Text = "1923";
                label4.Text = "1923";
            }
            if(soruno == 2 )
            {
                richTextBox1.Text = "Hangi şehir Karadeniz bolgemizde bulunmaz?";
                BTNA.Text = "Gümüşhane";
                BTNB.Text = "Trabzon";
                BTNc.Text = "Ordu";
                BTND.Text = "Antalya";
                label4.Text = "Antalya";
            }
             if (soruno == 3 ) 
            {
                richTextBox1.Text = "Trabzonspor ne zaman şampiyon olmuştur ?";
                BTNA.Text = "21-22";
                BTNB.Text = "22-23";
                BTNc.Text = "20-21";
                BTND.Text = "19-20";
                label4.Text = "21-22";
                BTNSonraki.Text = "Sonuçları";
            }
             if (soruno == 4 )
            {
                BTNA.Enabled = false;
                BTNB.Enabled = false;
                BTNc.Enabled = false;   
                BTND.Enabled = false;
                BTNSonraki.Enabled = false;
                MessageBox.Show("Doğru: " + dogru + "\n" + "Yanlış:" + yanlis);
            }
        }
    }
}
