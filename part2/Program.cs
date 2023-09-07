using System;

class Rectangle
{
    double _side1;
    double _side2;
    public Rectangle(double _side1, double _side2)
    {
        this._side1 = _side1;
        this._side2 = _side2;
    }

    private double CalculateArea()
    {
        return _side1 * _side2;

    }
    private double CalculatePerimeter()
    {
        return (_side1 + _side2) * 2;

    }
    public double Area
    {
        get { return CalculateArea(); }
    }

    public double Perimeter
    {
        get { return CalculatePerimeter(); }
    }

}


namespace part2
{
    class Program
    {
        static void Main(string[] args)
        {
            double side1, side2;
            Console.Write("Side1: ");
            side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Side2: ");
            side2 = Convert.ToDouble(Console.ReadLine());
            
            Rectangle a = new Rectangle(side1,side2);
            Console.WriteLine($"Area: {a.Area}, Perimeter: {a.Perimeter}" );
            Console.ReadLine();
        }
    }
}