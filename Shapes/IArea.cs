namespace Shapes
{
    /// <summary>
    /// interfaz que contiene los valores del área del un círculo
    /// </summary>
    public interface IArea
    {
        double Area { get; }

        public string toString()
        {
            return "El área es: " + Area;
        }
    }
}