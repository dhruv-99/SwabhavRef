using System;
using System.Collections.Generic;
using System.Collections;

using System.Text;

namespace InventoryApp
{
    class Inventory
    {
        private ArrayList guitars;

        public Inventory()
        {
            guitars = new ArrayList();

        }

        public void AddGuitar(string serialNumber, double price, GuitarSpec spec)                                            //Builder builder, string model, Type type, Wood backwood, Wood topwood)
        {
            
           Guitar guitar = new Guitar(serialNumber, price, spec);                                                            //builder, model, type, backwood, topwood);
            guitars.Add(guitar);
        }

        
      public ArrayList Search(GuitarSpec searchspec)
        {
            ArrayList MatchingGuitar = new ArrayList();
            foreach(Guitar g in guitars)
            {
                if (g.Spec.Matches(searchspec))
                {
                    MatchingGuitar.Add(g);
                }
                
            }
            return MatchingGuitar;
        }
       

        }
            
            
    }

