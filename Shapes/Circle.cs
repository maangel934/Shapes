using System;

namespace Shapes
{
    public class Circle
    {
        
        public double Circus { get; set; }
        public double Area
        {
            get
            {
                return Math.PI * (Circus * Circus);
            }
        }
    }
}
