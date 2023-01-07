using ShitHappens.Controller;
using ShitHappens.Logic;
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
    public partial class GameForm : BaseForm
    {
        private List<HoverButton> hovers;
        private List<CardControl> cards;
        private CardControl currentPlayerCard;
        private new GameController controller;
        public GameForm()
        {
            InitializeComponent();
            CreateCardControl();
        }
        public void SetController(GameController controller)
        {
            this.controller = controller;
        }

        private void playerCardsLayout_Resize(object sender, EventArgs e)
        {
            playerCardsLayout.Location = new Point(Size.Width / 2 - playerCardsLayout.Size.Width / 2, Size.Height / 2);
            currentPlayerCard.Location = new Point(Size.Width / 2 - currentPlayerCard.Size.Width / 2, Size.Height / 2 - playerCardsLayout.Size.Height - 15);
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            hovers = new List<HoverButton>()
                {
        new HoverButton(),
        new HoverButton(),
        new HoverButton(),
        new HoverButton(),
        new HoverButton(),
        new HoverButton(),
        new HoverButton(),
        new HoverButton(),
        new HoverButton(),
        new HoverButton(),
        new HoverButton(),
                };
            for (int i = 0; i < hovers.Count; i++)
            {
                var captured_i = i;
                hovers[i].Click += (sender, e) =>
                {
                    hovers[captured_i].ResetSize();
                    controller.HoverClicked(captured_i);
                };
            }
            controller.FirstRound();
        }
        public void UpdatePlayerCards(Player player)
        {
            playerNameLabel.Text = player.name;
            playerNameLabel.ForeColor = Color.FromArgb(player.color);
            cards = new List<CardControl>();
            int i = 0;
            playerCardsLayout.Controls.Clear();
            hovers[i].ResetSize();
            playerCardsLayout.Controls.Add(hovers[i++]);
            foreach (var card in player.cards)
            {
                var newCardControl = new CardControl(card);
                cards.Add(newCardControl);
                playerCardsLayout.Controls.Add(newCardControl);
                hovers[i].ResetSize();
                playerCardsLayout.Controls.Add(hovers[i++]);
            }
        }
        private void CreateCardControl()
        {
            currentPlayerCard = new CardControl();
            currentPlayerCard.HideValue();
            currentPlayerCard.Location = new Point(Size.Width / 2 - currentPlayerCard.Size.Width / 2, Size.Height / 2 - playerCardsLayout.Size.Height - 15);
            currentPlayerCard.Anchor = AnchorStyles.None;
            currentPlayerCard.Visible = true;
            Controls.Add(currentPlayerCard);
        }
        public void UpdateCard(Card card)
        {
            currentPlayerCard.Update(card);
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            controller.MainMenu();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            controller.Save();
        }
    }
}
