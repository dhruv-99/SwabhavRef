using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DogDoorApp
{
    class Program
    {
        static void Main(string[] args)
        {

            DogDoor door = new DogDoor();
            door.AddAllowedBarks(new Bark("rowlf"));
            door.AddAllowedBarks(new Bark("roooowlf"));
            door.AddAllowedBarks(new Bark("rawlf"));
            door.AddAllowedBarks(new Bark("woof"));
            Console.WriteLine(door.AllowedBarks.Count);
            // Remote remote = new Remote(door);
            BarkRecognizer recognizer = new BarkRecognizer(door);
            Console.WriteLine("Bruce starts barking... ");
            recognizer.Recognize(new Bark("rowlf"));

            Console.WriteLine("Bruce has gone outside..");
            
            // recognizer.Recognize("woof");
            // remote.PressButton();
            Thread.Sleep(5000);

            Console.WriteLine("Bruce is all done ");
            Console.WriteLine("But he's stuck outside");
            Bark smallDogBark = new Bark("Yip");
            Console.WriteLine("A small dog starts barking..");
            recognizer.Recognize(smallDogBark);
            Thread.Sleep(5000); 

            Console.WriteLine("Bruce starts barking.. ");
            recognizer.Recognize(new Bark("rooowlf"));
            // remote.PressButton();
            Console.WriteLine("Bruce's back inside..");
        }
    }
}
