using ShitHappens.FileManagement;
using ShitHappens.Logic;
using ShitHappens.View;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ShitHappens.Controller
{
    public class GameController
    {
        private Model model;
        private GameForm view;
        public GameController(Model model, GameForm view)
        {
            this.model = model;
            this.view = view;
            this.view.SetController(this);
            this.view.Show();
        }
        public void AddCardToPlayer()
        {
            model.AddCardToPlayer();
            model.NextCard();
        }
        public void HoverClicked(int i)
        {
            try
            {
                if (CheckAnswer(i))
                {
                    AddCardToPlayer();
                    var player = model.GetPlayer();
                    view.UpdatePlayerCards(player);
                    if (CheckWin())
                    {
                        MessageBox.Show(player.name+" wins!","Game over");
                        MainMenu();
                    }
                    else
                    {
                        NextRound();
                    }
                }
                else
                {
                    NextRound();
                }
            }catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("End of the deck, can't continue game.", "Error");
                MainMenu();
            }

        }
        public void NextRound()
        {
            model.NextPlayer();
            view.UpdatePlayerCards(model.GetPlayer());
            view.UpdateCard(model.currentCard);
        }
        private bool CheckAnswer(int i)
        {
            var cards = model.GetPlayer().cards;
            var currentCard = model.currentCard;
            if (i == 0)
            {
                if (currentCard.distressValue < cards[0].distressValue)
                    return true;
                return false;
            }
            if (i == cards.Count)
            {
                if (currentCard.distressValue > cards[cards.Count - 1].distressValue)
                    return true;
                return false;
            }
            if (currentCard.distressValue > cards[i - 1].distressValue && currentCard.distressValue < cards[i].distressValue)
                return true;
            return false;
        }
        private bool CheckWin()
        {
            if(model.GetPlayer().cards.Count==model.maxCards) return true;
            return false;
        }
        public void MainMenu()
        {
            var controller = new MainMenuController((MainMenuForm)this.view.PassSizeToNewForm(FormManager.Current.CreateForm<MainMenuForm>()));
            this.view.Close();
        }
        public void Save()
        {
            GameSaver.Save(model);
        }
        public void FirstRound()
        {
            view.UpdatePlayerCards(model.GetPlayer());
            view.UpdateCard(model.currentCard);
        }
    }
}
