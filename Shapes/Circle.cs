using System;

namespace Shapes
{
    public class Circle
    {
        
        public double Radius { get; set; }
        public double Area
        {
            get
            {
                return Math.PI * (Radius * Radius);
            }
        }
    }
}
