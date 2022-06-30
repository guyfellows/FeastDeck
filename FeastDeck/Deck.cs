using System;
using System.Collections.Generic;
using System.Linq;

namespace FeastDeck
{
    public static class Deck
    {
        private static List<int> Cards { get; set; }
        private static Random rng = new Random();
        private static int DeckSize;

        public static void SetDeckSize(int deckSize)
        {
            DeckSize = deckSize;
        }
        public static void RefreshDeck()
        {
            var setupDeck = new List<int>(Enumerable.Range(1, DeckSize));
            Shuffle(setupDeck);
            Cards = setupDeck;
            foreach (var thing in Cards)
            {
                Console.WriteLine(thing);
            }
        }

        public static void Shuffle<T>(IList<T> list)
        {
            var n = list.Count;
            while (n > 1)
            {
                n--;
                var k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static List<int> DrawCards(int drawNum)
        {
            var cardsDrawn = new List<int>();
            for (int i = drawNum; i > 0; i--)
            {
                cardsDrawn.Add(Cards[0]);
                Cards.RemoveAt(0);
            }
            return cardsDrawn;
        }

        public static int GetRemainingCards()
        {
            return Cards.Count();
        }
    }
}