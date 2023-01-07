using ShitHappens.Controller;
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
    public partial class StartParamsForm : BaseForm
    {
        private new StartParamsController controller;
        public StartParamsForm()
        {
            InitializeComponent();
        }
        public void SetController(StartParamsController controller)
        {
            this.controller = controller;
        }
        private void PlayButton_Click(object sender, EventArgs e)
        {
            this.controller.Play();
        }

        private void StartParamsForm_Load(object sender, EventArgs e)
        {
            this.controller.LoadColors();
        }
        public void LoadColors(List<int[]> colors)
        {
            var controls = this.playersPanel.Controls;
            int j = 0;
            for (int i = 0; i < controls.Count; i++)
            {
                if (controls[i] is Panel)
                {
                    controls[i].BackColor = Color.FromArgb(colors[j][0], colors[j][1], colors[j][2]);
                    j++;
                }
            }
        }
        public int GetMaxCards()
        {
            return ((int)this.cardNum.Value);
        }
        public TableLayoutPanel GetPlayers()
        {
            return this.playersPanel;
        }
    }
}
