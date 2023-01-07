using ShitHappens.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShitHappens.FileManagement
{
    public static class FileReader
    {
        public static List<Card> Read(string fileName)
        {
            List<Card> cards = new List<Card>();
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                var values = line.Split(';');
                cards.Add(new Card(values[0], float.Parse(values[1])));
            }
            return cards;
        }
    }
}
