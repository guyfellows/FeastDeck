namespace FeastDeck
{
    internal static class Program
    {
        public static int DeckSize = 154; //Number of Cards in Feast Deck
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Deck.SetDeckSize(DeckSize);
            Deck.RefreshDeck();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}