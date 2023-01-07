using ShitHappens.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ShitHappens
{
    public class Model
    {
        public int maxCards { get; set; }
        public int currentPlayer { get; set; }
        public Card currentCard { get; set; }
        public List<Player> players { get; set; }
        public List<Card> deck { get; set; }
        public Model() {
            currentPlayer= 0;
        }
        public List<int[]> Colors()
        {
            return new List<int[]>
            {
                new int[] {192,   0,   0},
                new int[] {  0,   0, 200},
                new int[] { 243, 205, 72 },
                new int[] { 0, 180, 0 },
                new int[] { 255, 128, 0 },
                new int[] { 100, 0, 100 },
                new int[] { 192, 255, 255 },
                new int[] { 255, 192, 255 },
                new int[] { 128, 64, 0 },
                new int[] { 200, 200, 200 },
            };
        }
        public void NextPlayer()
        {
            currentPlayer = (currentPlayer + 1) % players.Count;
        }
        public void NextCard()
        {
            currentCard = Draw();
        }
        public Player GetPlayer()
        {
            return players[currentPlayer];
        }
        public void AddCard(Card card)
        {
            players[currentPlayer].AddCard(card);
        }
        public void AddCardToPlayer()
        {
            players[currentPlayer].AddCard(currentCard);
        }

        public Card Draw()
        {
            Random rng = new Random();
            int index = rng.Next(deck.Count);
            var card = deck[index];
            deck.RemoveAt(index);
            return card;
        }
        public bool HasNullField()
        {
            if(maxCards==0 || currentCard== null || players== null || deck== null) return true;
            return false;
        }
    }
}
