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
            if (spec.GetType() == typeof(GuitarSpec))
            {
                instrument = new Guitar(serialNumber, price, (GuitarSpec)spec);
            }
            else if (spec.GetType() == typeof(MandolinSpec))
            {
                instrument = new Mandolin(serialNumber, price, (MandolinSpec)spec);
            }
            instruments.Add(instrument);
        }
        public List<Instrument> Search(GuitarSpec searchspec)
        {
            List<Instrument> MatchingGuitar = new List<Instrument>();
            for(int i = 0;i < instruments.Count; i++)
            {
                if(instruments[i] is Guitar)
                {
                    if (instruments[i].Spec.Matches(searchspec))
                    {
                        MatchingGuitar.Add(instruments[i]);
                    }
                }
            }
                return MatchingGuitar;
        }
        public List<Instrument> Search(MandolinSpec searchspec)
        {
            List<Instrument> MatchingMandolin = new List<Instrument>();
            if(searchspec.GetType() == typeof(MandolinSpec))
                for (int i = 0; i < instruments.Count; i++)
                {
                    if (instruments[i] is Mandolin)
                    {
                        if (instruments[i].Spec.Matches(searchspec))
                        {
                            MatchingMandolin.Add(instruments[i]);
                        }
                    }
                }
            return MatchingMandolin;
        }


    }


}

