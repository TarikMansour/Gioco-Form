using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mosca
{
    public partial class Form1 : Form
    {
        Point xy;
        Random pos = new Random();
        string path = Environment.CurrentDirectory;
        private int errore = 0;
        private int score = 0;
       
        public Form1()
        {
            xy = new Point();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Chiudere l'app?", "Avviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
           
        }

        private async void insetto_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if(timer1.Interval > 50)
            {
                timer1.Interval -= 50;
              
            }
            else
            {
                MessageBox.Show("Hai vinto", "Congratulazioni", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            }
            score++;
            if(score >= 5)
            {
                level.Text = "Level: Hard";
            }else if (score >= 10)
            {
                level.Text = "Level: Hardcore";
            }
           
            punteggio.Text = "Punteggio:" + score.ToString();
            if (farfalla.Checked == true)
            {
                
                insetto.Image = Image.FromFile(path + "\\farfalla.gif");
                insetto.Image = Image.FromFile(path + "\\farfallaX.gif");
                await Task.Delay(100);
                timer1.Enabled = true;
                insetto.Image = Image.FromFile(path + "\\farfalla.gif");
            }
            if (Mosca.Checked == true)
            {
                insetto.Image = Image.FromFile(path + "\\mosca.gif");
                insetto.Image = Image.FromFile(path + "\\moscaX.gif");
                await Task.Delay(100);
                timer1.Enabled = true;
                insetto.Image = Image.FromFile(path + "\\mosca.gif");
            }
            if (Ape.Checked == true)
            {
                insetto.Image = Image.FromFile(path + "\\ape.gif");
                insetto.Image = Image.FromFile(path + "\\apeX.gif");
                await Task.Delay(100);
                timer1.Enabled = true;
                insetto.Image = Image.FromFile(path + "\\ape.gif");
            }
            if (Ragno.Checked == true)
            {
                insetto.Image = Image.FromFile(path + "\\ragno.gif");
                insetto.Image = Image.FromFile(path + "\\ragnoX.gif");
                await Task.Delay(100);
                timer1.Enabled = true;
                insetto.Image = Image.FromFile(path + "\\ragno.gif");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            xy.X = pos.Next(0,(prato.ClientSize.Width- insetto.Width)+1);
            xy.Y = pos.Next(0, (prato.ClientSize.Height - insetto.Height) - 1);
            insetto.Location = xy;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(farfalla.Checked == true)
            {
                insetto.Image = Image.FromFile(path + "\\farfalla.gif");
            }
            else if (Mosca.Checked == true)
            {
                insetto.Image = Image.FromFile(path + "\\mosca.gif");
            }
            else if (Ape.Checked == true)
            {
                insetto.Image = Image.FromFile(path + "\\ape.gif");
            }
            else if (Ragno.Checked == true)
            {
                insetto.Image = Image.FromFile(path + "\\ragno.gif");
            }


        }

        private void prato_Paint(object sender, PaintEventArgs e)
        {
            
        }
        
        private void prato_Click(object sender, EventArgs e)
        {
            errore++;
            errori.Text = "Errori:" + errore;
            if (errore == 5)
            {
                MessageBox.Show("Hai perso", "Game over", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
    }
}
}
