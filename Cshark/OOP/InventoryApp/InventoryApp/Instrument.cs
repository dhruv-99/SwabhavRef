using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryApp
{
    public abstract class Instrument
    {
        private string _serialNumber;
        private double _price;
        private InstrumentSpec _spec;

        public Instrument(string serialNumber,double price, InstrumentSpec spec)
        {
            _serialNumber = serialNumber;
            _price = price;
            _spec = spec;
        }
        public string SerialNumber
        {
            get
            {
                return _serialNumber;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public InstrumentSpec Spec
        {
            get
            {
                return _spec;
            }
        }
    }
}
