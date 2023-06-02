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
        private List<int> DatornsKort = new List<int>();
        private int DinaPoäng = 0;
        private List<int> DinaKort = new List<int>();

        private int Tur = 0;

        private static int Ess = 11;

        private int[] KortID = 
            { Ess, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10,
            Ess, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10,
            Ess, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10,
            Ess, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };

        public Blackjack_Spel()
        {
            InitializeComponent();
            this.Show();

            Datorns_Poäng.Text = $"Datorns Poäng: {DatornsPoäng}";
            Din_Poäng.Text = $"Dina Poäng: {DinaPoäng}";

            button_Hit.Enabled = false;
            button_Stand.Enabled = false;
            button_Fortsätt.Enabled = false;

            Spel();
        }
        public void Spel()
        {

            DatorDrag();
            Thread.Sleep(1000);
            DittDrag();
            Thread.Sleep(1000);
            DatorDrag();
            Thread.Sleep(1000);
            DittDrag();
            Thread.Sleep(1000);
        }
        public void DatorDrag()
        {

            Random x = new();

            int DragetID = x.Next(0, KortID.Count());
            while (DatornsKort.Contains(DragetID))
                DragetID = x.Next(0, KortID.Count());

            DatornsPoäng += KortID[DragetID];
            DatornsKort.Add(DragetID);

            if (Tur == 0)
            {
                Datorns_Poäng.Text = $"Datorns Poäng: ?";
                Händelse.Text = "Datorn drar ett kort";
            }
            else
                Datorns_Poäng.Text = $"Datorns Poäng: ? + {DatornsPoäng - KortID[DatornsKort[0]]}";
        }
        public void DittDrag()
        {
            Random x = new();

            int DragetID = x.Next(0, KortID.Count());
            while (DinaKort.Contains(DragetID))
                DragetID = x.Next(0, KortID.Count());

            DinaPoäng += KortID[DragetID];
            DinaKort.Add(DragetID);

            if (Tur == 0)
            {
                Din_Poäng.Text = $"Datorns Poäng: ?";
                Händelse.Text = $"Du drar ett kort värt {KortID[DragetID]}";
            }
            else
                Din_Poäng.Text = $"Dina Poäng: {DinaPoäng}";

            Tur++;
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
