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
                {
                    winner = "O";
                    oPuntos.Text = (Int32.Parse(oPuntos.Text) + 1).ToString();
                }
                else
                {
                    winner = "X";
                    xPuntos.Text = (Int32.Parse(xPuntos.Text) + 1).ToString();
                }

                MessageBox.Show(winner + " ang nanalo!", "Panalo");

            }
            else
            {
                if (turnCount == 9)
                {
                    tablaPuntos.Text = (Int32.Parse(tablaPuntos.Text) + 1).ToString();
                    MessageBox.Show("Tabla!", "Ay!");
                }
            }
        }

        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    if (c.GetType() == typeof(Button))

                    {
                        Button b = (Button)c;
                        b.Enabled = false;
                    }
                }
            }
            catch { }
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pointY_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pointX_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                if (turn)
                    b.Text = "X";
                else
                    b.Text = "O";
            }
        }

        private void buttonLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            { 
                b.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            oPuntos.Text = "0";
            xPuntos.Text = "0";
            tablaPuntos.Text="0";
        }

        private void isaPa_Click(object sender, EventArgs e)
        {
            turn = true;
            turnCount = 0;

            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Application.Exit ();
        }
    }
}