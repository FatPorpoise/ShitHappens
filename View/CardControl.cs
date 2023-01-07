using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShitHappens.Logic;

namespace ShitHappens.View
{
    public partial class CardControl : UserControl
    {
        public CardControl()
        {
            InitializeComponent();
        }
        public CardControl(Card card)
        {
            InitializeComponent();
            Update(card);
        }
        public void HideValue()
        {
            valueLabel.Hide();
            distressLabel.Hide();
        }

        public void ShowValue()
        {
            valueLabel.Show();
            distressLabel.Show();
        }
        public void Update(Card card)
        {
            descriptionLabel.Text = card.description;
            valueLabel.Text = card.distressValue.ToString();
        }
    }
}
