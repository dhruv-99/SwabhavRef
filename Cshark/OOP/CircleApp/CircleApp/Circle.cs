using System;
using System.Collections.Generic;
using System.Text;

namespace CircleApp
{
    class Circle
    {
        private const float PI = 3.14f;
        private float _radius;

        public float Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value;
            }
        }

        public float CalculateArea()
        {
            return (PI * _radius * _radius);
        }

    }
}
