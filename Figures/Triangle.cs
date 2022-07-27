namespace Figures
{
    public class Triangle : IHasArea
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double Area
        {
            get
            {
                // Формула Герона
                var p = (A + B + C) / 2;
                return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
        }

        public bool IsRight()
        {
            var a = A * A;
            var b = B * B;
            var c = C * C;
            return a + b == c || a + c == b || b + c == a;

        }
    }
}