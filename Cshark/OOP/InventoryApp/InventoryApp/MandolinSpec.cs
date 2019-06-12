using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryApp
{
    class MandolinSpec : InstrumentSpec
    {
        private Style _style;

        public  MandolinSpec(Builder builder, string model, Type type, Style style, Wood backwood, Wood topwood) : 
            base (builder, model, type, backwood, topwood)
        {
            _style = style;
        }

        public Style MandolinStyle
        {
            get
            {
                return _style;
            }
        }
        public override bool Matches(InstrumentSpec otherspec)
        {
            if (!(base.Matches(otherspec)))
                return false;
            if (!(otherspec.GetType() == typeof( MandolinSpec)))
                return false;

            MandolinSpec spec = (MandolinSpec)otherspec;
            if (!_style.Equals(spec._style))
                return false;
            return true;
        }
    }
}
