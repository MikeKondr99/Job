namespace Figures
{
    public class Circle : IHasArea
    {
        public double Radius { get; set; }
        public double Area => Math.PI * Radius * Radius;
    }
}