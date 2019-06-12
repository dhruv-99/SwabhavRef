using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryApp
{
    class Mandolin : Instrument
    {
        public Mandolin(string serialNumber, double price, MandolinSpec guitarspec) : base(serialNumber,price,guitarspec)
        {

        }
    }
}
