using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace InventoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertToString convert = new ConvertToString();
            Inventory inventory = new Inventory();
            InitializeInventory(inventory);
            GuitarSpec WhatErinLikes = new GuitarSpec(Builder.FENDER, "Stratocastor", Type.ELECTRIC, 6, Wood.ALDER, Wood.ALDER);
            List<Instrument> MatchingGuitars = inventory.Search(WhatErinLikes);
            if (MatchingGuitars.Count >= 0)
            {
                Console.WriteLine("Erin, you might like these guitars :");

                foreach (Guitar guit in MatchingGuitars)
                {
                   GuitarSpec spec = (GuitarSpec)guit.Spec;
                   Console.WriteLine("We have a " + convert.BuilderToString(spec.Builder) + " " + spec.Model + " " + convert.TypeToString(spec.Type) + " " + convert.WoodToString(spec.Backwood) + " Back and Sides " + convert.WoodToString(spec.Topwood));
                   Console.WriteLine("You can have it for just $" + guit.Price);

                }
            }
            else Console.WriteLine("Sorry, we nothing for you....");
            MandolinSpec WhatAkashLikes = new MandolinSpec(Builder.COLLINGS, "Stratocastor", Type.ACOUSTIC, Style.A, Wood.ADIRONDACK, Wood.ADIRONDACK);
            List<Instrument> MatchingMandolins = inventory.Search(WhatAkashLikes);
            if (MatchingMandolins.Count >= 0)
            {
                Console.WriteLine("Erin, you might like these mandolin :");


                foreach (Mandolin mandolin in MatchingMandolins)
                {
                    MandolinSpec spec = (MandolinSpec)mandolin.Spec;
                    Console.WriteLine("We have a " + convert.BuilderToString(spec.Builder) + " " + spec.Model + " " + convert.TypeToString(spec.Type) + " " + convert.WoodToString(spec.Backwood) + " Back and Sides " + convert.WoodToString(spec.Topwood));
                    Console.WriteLine("You can have it for just $" + mandolin.Price);

                }
            }
            else
                Console.WriteLine("Sorry, we nothing for you....");
        }




        static void InitializeInventory(Inventory inventory)
        {
            inventory.AddInstrument("V9563", 1499.95, new GuitarSpec(Builder.FENDER, "Stratocastor", Type.ELECTRIC, 6, Wood.ALDER, Wood.ALDER));
            inventory.AddInstrument("V9512", 1549.95, new GuitarSpec(Builder.FENDER, "Stratocastor", Type.ELECTRIC, 6, Wood.ALDER, Wood.ALDER));
           inventory.AddInstrument("M1024", 1600.65, new MandolinSpec(Builder.COLLINGS, "Stratocastor", Type.ACOUSTIC, Style.A, Wood.ADIRONDACK, Wood.ADIRONDACK));
        }
    }
}
