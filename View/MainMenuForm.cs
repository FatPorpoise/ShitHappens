using ShitHappens.FileManagement;
using ShitHappens.Logic;
using ShitHappens.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Media;

namespace ShitHappens.View
{
    public partial class MainMenuForm : BaseForm
    {
        //private MainMenuController controller;
        public MainMenuForm()
        {
            InitializeComponent();
        }
        //public void SetController(MainMenuController controller)
        //{
        //    this.controller = controller;
        //}

        private void newGameButton_Click(object sender, EventArgs e)
        {
            controller.NewGame();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            controller.LoadGame();
        }

        private void optionsButton_Click(object sender, EventArgs e)
        {
            //this.controller.NewView<OptionsForm>();
        }

        private void howToPlayButton_Click(object sender, EventArgs e)
        {
            controller.HowToPlay();
        }
    }
}
