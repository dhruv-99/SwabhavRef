using System;

namespace RectangleApp
{
 
      
    class Program
    {
        static void Main(string[] args)
        {

            // initial
            /*  Rectangle big = new Rectangle();
              Rectangle small = new Rectangle();
              small.width = 10;
              small.height = 5;

              big.width = 100;
              big.height = 20;
              Console.WriteLine("Width = " + big.width + " and height = " + big.height);
              Console.WriteLine("Area of big rectangle = " + big.CalculateArea());
              Console.WriteLine("Width = " + small.width + " and height = " + small.height);
              Console.WriteLine("Area of small rectangle = " + small.CalculateArea());
      */

           // changed requirement #1

            Rectangle[] r = new Rectangle[3];
            for(int i=0; i<3; i++)
            {
                r[i] = new Rectangle();
            }
            r[0].width = 10;
            r[0].height = 20;

            r[1].width = 50;
            r[1].height = 30;

            r[2].width = 60;
            r[2].height = 50;

            /*  int[] area = new int[3]; 

              for (int i = 0; i < 3; i++) {
                  area[i] = r[i].CalculateArea();
              }
              for(int i=0;i<3;i++)
              {
                  Console.WriteLine("Area of "+ (i+1) +"th rectangle is :" + area[i]);
              }
              int total = 0;
              for (int i = 0; i < 3; i++)
                  total = total + area[i];
              Console.WriteLine("Sum of areas of rectangle is " + total);
      */

            // method #2

            Console.WriteLine("Sum of Area of Rectangles = " + (r[0].CalculateArea() + r[1].CalculateArea() + r[2].CalculateArea()) );
    }
        
    }
}
