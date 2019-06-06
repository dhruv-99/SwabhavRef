using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryApp
{
    class Guitar
    {
        private string _serialNumber;
        private double _price;
        private GuitarSpec _spec;

        public Guitar(string serialNumber, double price, GuitarSpec spec)
        {
            _serialNumber = serialNumber;
            _price = price;
            _spec = spec;
        }

        public string SerialNumber
        {
            get {
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

        public GuitarSpec Spec
        {
            get
            {
                return _spec;
            }
        }
    }
}
