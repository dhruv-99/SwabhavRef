using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ThreadSolution
{
    class ThreadForm1 : Form
    {
        public ThreadForm1()
        {
            Button hello = new Button();
            hello.Text = "hello";
            hello.Click += Hello_Click;
            hello.Location = new System.Drawing.Point(12,12);

            Button print = new Button();
            print.Text = "Print";
            print.Click += Print_Click;
            print.Location = new System.Drawing.Point(12,40);

            this.Controls.Add(hello);
            this.Controls.Add(print);
        }

        private void Print_Click(object sender, EventArgs e)
        {
            while(true)
                Console.WriteLine("hello");
        }

        private void Hello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello", "Title");
        }
    }
}
