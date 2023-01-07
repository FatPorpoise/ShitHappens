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
    public partial class HoverButton : UserControl
    {
        //public bool isWidend { get; set; }
        private int origWidth;
        public HoverButton()
        {
            InitializeComponent();
            origWidth = Width;
            //isWidend = false;
        }

        private void HoverButton_MouseEnter(object sender, EventArgs e)
        {

            Width *= 4;
            //isWidend= true;
        }

        private void HoverButton_MouseLeave(object sender, EventArgs e)
        {
            Width = origWidth;
            //isWidend= false;
        }
        public void ResetSize()
        {
            Width = origWidth;
        }
    }
}
