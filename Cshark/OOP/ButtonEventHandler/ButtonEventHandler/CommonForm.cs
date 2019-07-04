using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ButtonEventHandler
{
    class CommonForm : Form
    {
        Button red = new Button();
        Button blue = new Button();
        public CommonForm()
        {
            red.Text = "Red";
            red.Width = 40;
            red.Height = 20;
            red.Location = new System.Drawing.Point(20,50);
            red.BackColor = System.Drawing.Color.AntiqueWhite;
            red.Click += CommonHandler;
            this.Controls.Add(red);

            blue.Text = "Blue";
            blue.Width = 40;
            blue.Height = 20;
            blue.Location = new System.Drawing.Point(60, 50);
            blue.BackColor = System.Drawing.Color.AntiqueWhite;
            blue.Click += CommonHandler;
            this.Controls.Add(blue);
        }

        private void CommonHandler(object sender, EventArgs e)
        {
            if (sender.Equals(red))
                this.BackColor = System.Drawing.Color.Red;
            if (sender.Equals(blue))
                this.BackColor = System.Drawing.Color.Blue;
        }
    }
}
