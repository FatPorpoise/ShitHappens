using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShitHappens.Logic
{


    public class Card
    {
        public string description { get; set; }
        public float distressValue { get; set; }
        public Card(string description, float distressValue)
        {
            this.description = description;
            this.distressValue = distressValue;
        }
    }
}
