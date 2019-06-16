using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ModifiedInventoryApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Inventory inventory = new Inventory();
            InitializeInventory(inventory);


            Dictionary<string, object> properties = new Dictionary<string, object>();
          // properties.Add("instrumentType", InstrumentType.GUITAR);
            properties.Add("builder", Builder.FENDER);
            properties.Add("model", "CJ");
            //properties.Add("numString", 6);
            //properties.Add("topWood", Wood.INDIAN_ROSEWOOD);
            //properties.Add("backWood", Wood.SITKA);
            InstrumentSpec clientSpec = new InstrumentSpec(properties);
            List<Instrument> matchingInstrument = inventory.Search(clientSpec);

            if (matchingInstrument.Count >= 0)
            {
                Console.WriteLine("you might like these Instrument:");
                
                foreach (Instrument instrument in matchingInstrument)
                {
                    InstrumentSpec spec = instrument.Spec;

                   // Console.WriteLine("We have a " + spec.GetProperty("instrumentType") + "  with follwing Properties ");
                    foreach(var j in spec.Properties.Keys)
                    {
                        string propertyName = Convert.ToString(j);
                        //if (propertyName.Equals("instrumentType") || propertyName.Equals("instrumentType1"))
                        //{
                        //    continue;
                        //}
                       Console.WriteLine(" " + propertyName + " :" + spec.GetProperty(propertyName));
                    }
                    
                    Console.WriteLine("You can have this " + spec.GetProperty("instrumentType") + " $" + instrument.Price  + "\n----");

                }
            }
            else
            {
                Console.WriteLine("Sorry,we have nothing fo you");
            }
        }

        static void InitializeInventory(Inventory inventory)
        {
            Dictionary<string, object> properties = new Dictionary<string, object>();
            properties.Add("instrumentType1", InstrumentType.MANDOLIN);
            properties.Add("builder1", Builder.FENDER);
            properties.Add("model1", "CJ");
            properties.Add("numString1", 4);
            properties.Add("topWood1", Wood.BRAZILIAN_ROSEWOOD);
            properties.Add("backWood1", Wood.ALDER);
            inventory.AddInstrument("12554", 650, new InstrumentSpec(properties));

            properties.Add("instrumentType", InstrumentType.BASS);
            properties.Add("builder", Builder.FENDER);
            properties.Add("model", "CJ");
            properties.Add("numString", 6);
            properties.Add("topWood", Wood.INDIAN_ROSEWOOD);
            properties.Add("backWood", Wood.SITKA);
            inventory.AddInstrument("1234", 250, new InstrumentSpec(properties));

     
        }
    }
}
