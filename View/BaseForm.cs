using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShitHappens.Controller;

namespace ShitHappens.View
{
    public partial class BaseForm : Form
    {
        protected MainMenuController controller;
        public BaseForm()
        {
            Text = "ShitHappens";
            InitializeComponent();
        }
        public BaseForm PassSizeToNewForm(BaseForm form)
        {
            this.Hide();
            if (this.WindowState != FormWindowState.Maximized)
            {
                form.Size = this.Size;
                form.StartPosition = FormStartPosition.Manual;
                form.Location = this.Location;
            }
            else
            {
                form.WindowState = FormWindowState.Maximized;
            }
            return form;
        }
        public void SetController(MainMenuController controller)
        {
            this.controller = controller;
        }
    }
}
