namespace DnDDiceRollTwo
{
    public partial class DnDDiceRoll : Form
    {
        public DnDDiceRoll()
        {
            InitializeComponent();
        }

        public void dFourDiceRoll_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int dFourDice = random.Next(1, 5);
            diceRollResult.Text = dFourDice.ToString();
            diceRollResult.ForeColor = Color.Bisque;

        }

        public void dSixDiceRoll_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int dSixDice = random.Next(1, 7);
            diceRollResult.Text = dSixDice.ToString();
            diceRollResult.ForeColor = Color.Crimson;

        }

        public void dEightDiceRoll_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int dEightDice = random.Next(1, 9);
            diceRollResult.Text = dEightDice.ToString();
            diceRollResult.ForeColor = Color.DarkGreen;

        }

        public void dTenDiceRoll_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int dTenDice = random.Next(1, 11);
            diceRollResult.Text = dTenDice.ToString();
            diceRollResult.ForeColor= Color.Magenta;

        }

        public void dTwelveDiceRoll_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int dTwelveDice = random.Next(1, 13);
            diceRollResult.Text = dTwelveDice.ToString();
            diceRollResult.ForeColor = Color.DarkViolet;

        }

        public void dTwentyDiceRoll_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int dTwentyDice = random.Next(1, 21);
            diceRollResult.Text = dTwentyDice.ToString();
            diceRollResult.ForeColor = Color.DeepPink;
        }
    }
}
