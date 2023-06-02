namespace WinFormsApp3
{
    public partial class Blackjack_Meny : Form
    {
        public Blackjack_Meny()
        {
            InitializeComponent();
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            Blackjack_Spel x = new();
            this.Hide();
        }

        private void button_Inst_Click(object sender, EventArgs e)
        {
            Blackjack_Inställningar x = new();

            this.Hide();
            x.Show();
        }

        private void button_Vinnare_Click(object sender, EventArgs e)
        {
            Blackjack_Vinnare x = new();

            this.Hide();
            x.Show();
        }

        private void button_Avslut_Click(object sender, EventArgs e)
        {

        }
    }
}