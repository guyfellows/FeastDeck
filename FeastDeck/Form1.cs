namespace FeastDeck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            var drawnCards = Deck.DrawCards(Convert.ToInt32(drawBox.Text));
            //Lookup cards and display them
            lblCardsRemaining.Text = $"Cards Remaining: {Deck.GetRemainingCards()}";
        }

        private void shuffleButton_Click(object sender, EventArgs e)
        {
            Deck.RefreshDeck();
            lblCardsRemaining.Text = $"Cards Remaining: {Deck.GetRemainingCards()}";
        }

        private void drawBox_TextChanged(object sender, EventArgs e)
        {
            int value = 1;
            if (!int.TryParse(drawBox.Text, out value))
            {
                drawBox.Text = "1";
            }
            else if (value < 1)
                drawBox.Text = "1";
            else if (value > 6)
                drawBox.Text = "6";
        }
    }
}