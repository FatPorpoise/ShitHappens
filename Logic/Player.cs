using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShitHappens.Logic
{
    public class Player
    {
        public List<Card> cards { get; set; }
        public string name { get; set; }
        public int color { get; set; }
        public Player(string name, int color, List<Card> cards)
        {
            this.cards= cards;
            SortCards();
            this.name = name;
            this.color = color;
        }
        private void SortCards()
        {
            cards.Sort((p, q) => p.distressValue.CompareTo(q.distressValue));
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
            SortCards();
        }
    }
}
