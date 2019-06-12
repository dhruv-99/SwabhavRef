using System;
using System.Collections.Generic;
using System.Collections;

using System.Text;

namespace InventoryApp
{
    class Inventory
    {
        private List<Instrument> instruments;

        public Inventory()
        {
            instruments = new List<Instrument>();
        }

        public void AddInstrument(string serialNumber, double price, InstrumentSpec spec)                                            //Builder builder, string model, Type type, Wood backwood, Wood topwood)
        {

            Instrument instrument = null;
            if(spec.GetType() == typeof (GuitarSpec)){
                instrument = new Guitar(serialNumber,price, (GuitarSpec)spec);
            }
            else if(spec.GetType() == typeof(MandolinSpec)){
                instrument = new Mandolin(serialNumber, price, (MandolinSpec)spec);
            }
            instruments.Add(instrument);
        }

        
      public List<Guitar> Search(GuitarSpec searchspec)
        {
            List<Guitar> MatchingGuitar = new List<Guitar>();
            foreach(Guitar g in instruments)
            {
                if (g.Spec.Matches(searchspec))
                {
                    MatchingGuitar.Add(g);
                }
                
            }
            return MatchingGuitar;
        }
        public List<Mandolin> Search(MandolinSpec searchspec)
        {
            List<Mandolin> MatchingMandolin = new List<Mandolin>();
            foreach (Mandolin m in instruments)
            {
                if (m.Spec.Matches(searchspec))
                {
                    MatchingMandolin.Add(m);
                }

            }
            return MatchingMandolin;
        }


    }


}

