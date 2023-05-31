using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Blackjack_Spel : Form
    {
        private int DatornsPoäng = 0;
        private int DinaPoäng = 0;

        private int[] KortVärden = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };

        public Blackjack_Spel()
        {
            InitializeComponent();

            Datorns_Poäng.Text = $"Datorns Poäng: {DatornsPoäng}";
            Din_Poäng.Text = $"Dina Poäng: {DinaPoäng}";

            button_Hit.Enabled = false;
            button_Stand.Enabled = false;
            button_Fortsätt.Enabled = false;

        }
        public void DatorDrag()
        {
            Random x = new();

            DatornsPoäng = x.Next(0, KortVärden.length);
        }

        private void button_Hit_Click(object sender, EventArgs e)
        {

        }

        private void button_Stand_Click(object sender, EventArgs e)
        {

        }

        private void button_Fortsätt_Click(object sender, EventArgs e)
        {

        }
    }
}
