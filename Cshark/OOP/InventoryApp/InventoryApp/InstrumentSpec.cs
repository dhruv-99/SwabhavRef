using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryApp
{
   public abstract class InstrumentSpec
    {
        private Builder _builder;
        private string _model;
        private Type _type;
        private Wood _backwood;
        private Wood _topwood;

        public  InstrumentSpec(Builder builder, string model, Type type, Wood backwood, Wood topwood)
        {
            _builder = builder;
            _model = model;
            _type = type;
            _backwood = backwood;
            _topwood = topwood;
        }
        public Builder Builder
        {
            get
            {
                return _builder;
            }
        }

        public string Model
        {
            get
            {
                return _model;
            }
        }

        public Type Type
        {
            get
            {
                return _type;
            }
        }

        public Wood Backwood
        {
            get
            {
                return _backwood;
            }
        }

        public Wood Topwood
        {
            get
            {
                return _topwood;
            }
        }

        public virtual bool Matches(InstrumentSpec otherspec)
        {

            if (_builder != otherspec._builder)
                return false;
            if (((_model) != null) && (!_model.Equals("")) && (!_model.Equals(otherspec._model)))
                return false;
            if (_type != otherspec._type)
                return false;
            if (_backwood != otherspec._backwood)
                return false;
            if (_topwood != otherspec._topwood)
                return false;

            return true;
        }
    }
}
