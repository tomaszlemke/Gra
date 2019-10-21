using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace gra1
{
    public partial class gra : Form
    {
        Random losowe = new Random();
        Control.ControlCollection pola;
        bool czyKolej;
        Color KolorPrzeszkody = Color.DarkViolet, colorSterownika = Color.Crimson;
        int pozycja, ominieteElementy;

        private Stopwatch watch = new Stopwatch();

        private void UpdateTime()
        {

            lblCzas.Text = "Czas rozgrywki: " + GetTimeString(watch.Elapsed);

        }

        private string GetTimeString(TimeSpan elapsed)
        {
            string result = string.Empty;

            result = string.Format("{0:00}:{1:00}:{2:00}.{3:000}",
                elapsed.Hours,
                elapsed.Minutes,
                elapsed.Seconds,
                elapsed.Milliseconds);

            return result;
        }

        public gra()
        {
            InitializeComponent();
            UpdateTime();
        }

        private void PnlPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int j = 0; j< 11; j++)

            for (int i = 0; i < 5; i++)
            {
                TextBox pole = new TextBox();
                pole.Width = 70;
                pole.Left = i * 75 + 10;
                pole.Top = j * 30 +10;
                pole.Enabled = false;
                this.pnlPanel.Controls.Add(pole);
            }
        }

        private void TmrStoper_Tick(object sender, EventArgs e)
        {
            
            for (int i = 54; i > 4; i--)
                pola[i].BackColor = pola[i - 5].BackColor;
            
            for (int i = 0; i < 5; i++)
                pola[i].BackColor = SystemColors.Window;

            czyKolej = !czyKolej;

            if (czyKolej)
                for (int i = 0; i < 4; i++)
                    pola[losowe.Next(0, 5)].BackColor = KolorPrzeszkody;
                    
            tmrStoper.Interval = (int)(tmrStoper.Interval * 0.995);

            for (int i = 50; i < 55; i++)
                if (pola[i].BackColor == KolorPrzeszkody)
                    ominieteElementy++;
            
            if (pola[pozycja +50].BackColor == KolorPrzeszkody)
            {
                
                tmrStoper.Stop();
                tmrPomiarCzasuRozgrywki.Stop();
                pola[50 + pozycja].BackColor = Color.Black;
                MessageBox.Show("Game over. Liczba ominietych elementów: " + (ominieteElementy -1));
                btnStart.Enabled = true;
                foreach (Control pole in pnlPanel.Controls)
                   pole.BackColor = SystemColors.Window;
                watch.Stop();
            }

            else
                pola[50 + pozycja].BackColor = colorSterownika;
        }

        private void TmrPomiarCzasuRozgrywki_Tick(object sender, EventArgs e)
        {
            lblCzas.Text = "Czas rozgrywki: " + GetTimeString(watch.Elapsed);
        }

        private void Gra_KeyDown(object sender, KeyEventArgs e)
        {
            pola[50 + pozycja].BackColor = SystemColors.Window;

            
            if (e.KeyValue == 37 && pozycja > 0 && pola[pozycja +49].BackColor ==SystemColors.Window)
                pozycja--;
                

            if (e.KeyValue == 39 && pozycja < 4 && pola[pozycja + 51].BackColor == SystemColors.Window)
                pozycja++;
                
            pola[50 + pozycja].BackColor = colorSterownika;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            pola = this.pnlPanel.Controls;
            tmrStoper.Enabled = true;
            pozycja = 2;
            ominieteElementy = 0;
            tmrStoper.Interval = 1000;
            tmrPomiarCzasuRozgrywki.Enabled = true;
            btnStart.Enabled = false;
            pola[50 + pozycja].BackColor = colorSterownika;
            watch.Start();
        }

    }
}
