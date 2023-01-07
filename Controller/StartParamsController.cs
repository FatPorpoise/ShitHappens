using ShitHappens.FileManagement;
using ShitHappens.Logic;
using ShitHappens.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ShitHappens.Controller
{
    public class StartParamsController
    {
        private Model model;
        private StartParamsForm view;
        public StartParamsController(Model model,StartParamsForm view)
        {
            this.model = model;
            this.view = view;
            this.view.SetController(this);
            this.view.Show();
        }
        public void SetMaxCards()
        {
            model.maxCards = view.GetMaxCards();
        }
        private void NewGame(TableLayoutPanel table)
        {
            var players = new List<Player>();
            var names = new List<string>();
            var colors = new List<int>();
            for (int i = 0; i <= table.RowCount; i++)
            {
                Control? textBox = table.GetControlFromPosition(1, i);
                if (textBox is TextBox && textBox.Text != "")
                {
                    names.Add(textBox.Text);
                    Control? colorPanel = table.GetControlFromPosition(0, i);
                    if (colorPanel is Panel)
                        colors.Add(colorPanel.BackColor.ToArgb());
                }
            }
            if (names.Count >= 2)
            {
                try
                {
                    for (int i = 0; i < names.Count; i++)
                    {
                        List<Card> cards = new List<Card>();
                        //Startowa ilość kart na gracza
                        for (int j = 0; j < 3; j++)
                            cards.Add(model.Draw());
                        players.Add(new Player(names[i], colors[i], cards));
                    }
                    Random rng= new Random();
                    int n = players.Count;
                    while (n > 1)
                    {
                        n--;
                        int k = rng.Next(n + 1);
                        Player value = players[k];
                        players[k] = players[n];
                        players[n] = value;
                    }
                    model.players = players;
                    model.NextCard();
                    var controller = new GameController(model, (GameForm)this.view.PassSizeToNewForm(FormManager.Current.CreateForm<GameForm>()));
                    this.view.Close();
                }
                catch(ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Not enough cards loaded to start the game.", "Error");
                    var controller = new MainMenuController((MainMenuForm)this.view.PassSizeToNewForm(FormManager.Current.CreateForm<MainMenuForm>())); 
                    this.view.Close();
                }
            }
            else { MessageBox.Show("Not enough players.\nMust be at least two.", "Info"); }
        }
        public void LoadColors()
        {
            view.LoadColors(model.Colors());
        }
        public void Play()
        {
            SetMaxCards();
            NewGame(view.GetPlayers());
        }
    }
}
