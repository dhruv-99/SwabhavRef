﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryApp
{
    public class GuitarSpec : InstrumentSpec
    {
        private int _numStrings;

        public  GuitarSpec(Builder builder, string model, Type type, int numStrings, Wood backwood, Wood topwood) : 
            base (builder, model, type, backwood, topwood)
        {
            _numStrings = numStrings;
        }
        public int NumStrings
        {
            get
            {
                return _numStrings;
            }
        }
        public override bool Matches(InstrumentSpec otherspec)
        {
            if (!(base.Matches(otherspec)))
                return false;
            if(!(otherspec.GetType() == typeof (GuitarSpec)))
                return false;

            GuitarSpec spec = (GuitarSpec)otherspec;
            if (_numStrings != spec._numStrings)
                return false;
            return true;
        }




    }
}
