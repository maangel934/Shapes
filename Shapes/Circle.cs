using System;

namespace Shapes
{
    public class Circle : IArea
    {

        public double Radius
        {
            get
            {
                return Radius;
            }
            set
            {
                if (Radius < 0)
                {
                    throw new ArgumentException("el radio debe ser mayor o igual que 0");
                }
            }
        }
        public double Area
        {
            get
            {
                return Math.PI * (Radius * Radius);
            }
        }
    }
}
