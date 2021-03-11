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

    /// <summary>
    /// Clase que nos dará el ancho y la altura de un rectángulo
    /// </summary>
    public class rectangle : IAreaRect
    {
        public double Width
        {
            get
            {
                return Width;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("El valor debe ser mayor o igual que 0");
                }
            }
        }
        public double Height
        {
            get
            {
                return Height;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("El valor debe ser mayor o igual que 0");
                }
            }
        }
        public double area(double Height, double Width)
        {
            return Height * Width;
            
        }
    }
}
