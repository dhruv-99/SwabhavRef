using System;
using System.Collections.Generic;
using System.Collections;

using System.Text;

namespace ModifiedInventoryApp
{
    class Inventory
    {
        private List<Instrument> _inventory;

        public Inventory()
        {
            _inventory = new List<Instrument>();
        }

        public void AddInstrument(string serialNumber, double price, InstrumentSpec spec)                                            //Builder builder, string model, Type type, Wood backwood, Wood topwood)
        {
            Instrument instrument = new Instrument(serialNumber, price, spec);
            _inventory.Add(instrument);
        }

        //public Instrument Get(string instrumentName)
        //{
        //    return0;
        //}

        public List<Instrument> Search(InstrumentSpec searchspec)
        {
            List<Instrument> MatchingInstrument = new List<Instrument>();
              foreach(Instrument instrument in _inventory)
            {
                if (instrument.Spec.Matches(searchspec))
                {
                    MatchingInstrument.Add(instrument);
                }
            }
                return MatchingInstrument;
        }
    }


}

