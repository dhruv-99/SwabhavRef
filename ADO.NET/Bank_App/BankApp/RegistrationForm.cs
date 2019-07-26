using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BankApp
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            Label name = new Label();
            name.Text = "Name";
            name.Location = new Point(10, 20);

            this.Controls.Add(name);
          //  InitializeComponent();
        }
    }
}
