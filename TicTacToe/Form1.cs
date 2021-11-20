namespace TicTacToe
{
    public partial class Form1 : Form
    {

        bool turn = true;
        int turnCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";

            turn = !turn;
            b.Enabled = false;

            turnCount++;
            checkingWinner();
        }

        private void checkingWinner()
        {
            bool theWinner = false;

            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                theWinner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                theWinner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                theWinner = true;


            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                theWinner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                theWinner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                theWinner = true;


            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                theWinner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                theWinner = true;
            




            if (theWinner)
            {
                disableButtons();

                String winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";

                MessageBox.Show(winner + " wins!", "Good job!");

            }
            else
            {
                if (turnCount == 9)
                    MessageBox.Show("Draw!");
            }
        }

        private void disableButtons()
        {
            try
            {
                foreach (IBindableComponent c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
            

        }
    }
}