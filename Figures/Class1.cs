namespace Figures
{
    public class Class1
    {

    }

    public class Circle : HasArea
    {
        public double Raduis { get; set; }
        public double Area => throw new NotImplementedException();
    }

    interface HasArea
    {
        double Area { get; }
    }
}