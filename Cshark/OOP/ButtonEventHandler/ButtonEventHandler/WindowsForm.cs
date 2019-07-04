using System;
using System.Windows.Forms;


namespace WelcomeFormApplication
{
    class WindowsForm : Form
    {
        public WindowsForm()
        {
            this.Text = "Dhruv";
            this.Width = 1024;
            this.Height = 700;
            this.BackColor = System.Drawing.Color.CadetBlue;

            Button button = new Button();
            button.Text= "Addition";
            button.Location = new System.Drawing.Point(40, 50);
            button.BackColor = System.Drawing.Color.White;
            button.Click += HelloHandler;
            button.Click += GoodByeHandler;
            
            this.Controls.Add(button);

        }

        private void HelloHandler(object sender, EventArgs e)
        {
            Console.WriteLine("Hello");
        }
        private void GoodByeHandler(object sender, EventArgs e)
        {
            Console.WriteLine("GoodBye");
        }
    }
}
