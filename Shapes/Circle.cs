using System;

namespace Shapes
{
    /// <summary>
    /// Clase que obtendrá el valor del radio de un círculo
    /// y nos devolverá su área
    /// </summary>
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
