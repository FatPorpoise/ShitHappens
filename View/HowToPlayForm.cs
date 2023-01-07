using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShitHappens.View
{
    public partial class HowToPlayForm : BaseForm
    {
        private string[] texts;
        private int i;
        public HowToPlayForm()
        {
            InitializeComponent();
            texts = new string[]
            {
                "Game objective\r\nBe first to get set number of event cards by ranking them correctly.",
                "Misery index\r\nEach card could depict a bad event that has happened or could happen.\r\nAs you'll see, some of the situations on the cards are pretty minor (like a bee sting),\r\nand some of them are more problematic (like getting fired).\r\nEach card has been ranked on our Misery Index. \r\nThe Misery Index is ranking system that runs from 1 to 100.",
                "Setup\r\nEach player starts with 3 cards.\r\nThe remaining cards form a draw pile.\r\nAll cards are face up, so everyone can see others choices.",
                "Game Play\r\nRandom player starts.\r\nEvery round there's a card with hidden Misery Index.\r\nCurrent player decides where this card fits on his scale.\r\nIf they are wrong, next player tries, and so on until someone's right.\r\nThen the card joins rest of their cards.\r\nChoose where you'd put the card by clicking between cards or on the edges."
            };
            textLabel.Text= texts[i=0];
        }

        private void nextButton_Click(object sender, EventArgs e)
        { 
            i = (i + 1) % texts.Length;
            textLabel.Text = texts[i];
        }

        private void previousButton_Click(object sender, EventArgs e)
        { 
            if(--i<0)
            {
                i = texts.Length-1;
            }
            textLabel.Text = texts[i];
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            controller.MainMenu();
        }
    }
}
