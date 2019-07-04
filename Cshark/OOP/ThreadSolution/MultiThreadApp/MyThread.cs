using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace MultiThreadApp
{
    class MyThread : Form
    {
        public MyThread()
        {
            Button hello = new Button();
            hello.Text = "hello";
            hello.Click += Hello_Click;
            hello.Location = new System.Drawing.Point(12, 12);

            Button print = new Button();
            print.Text = "Print";
            print.Click += Print_Click;
            print.Location = new System.Drawing.Point(12, 40);

            this.Controls.Add(hello);
            this.Controls.Add(print);

            
        }

        
        private void Print_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(printData);
            t1.Start();
        }

        private void Hello_Click(object sender, EventArgs e)
        {
            Thread t2 = new Thread(DisplayHello);
            t2.Start();
          
        }
        public void printData()
        {
            while (true)
                Console.WriteLine("hello");
        }

        public void DisplayHello()
        {
            MessageBox.Show("Hello", "Title");
        }
    }
}
