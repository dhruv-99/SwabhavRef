using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryApp
{
    class Guitar : Instrument
    {
        
       // private GuitarSpec _spec;

        public Guitar(string serialNumber, double price, GuitarSpec guitarspec) : base(serialNumber,price,guitarspec)
        {
           
        }

        
    }
}
