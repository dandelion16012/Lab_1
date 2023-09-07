using System;

class Point
{
    int x, y;
    public int X
    {
        get{return x;}
    }
    public int Y
    {
        get{return y;}
    }

    public Point()
    {
        x = 0;
        y = 0;

    }
    public Point(string name, int x, int y)
    {
        Console.WriteLine("Enter a letter of Point:");
        this.name = Console.ReadLine();
        Console.WriteLine("Enter X:");
        this.x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Y:");
        this.y = int.Parse(Console.ReadLine());
    }
}


class Figure
    {
    int number;
    Point[] points;
    string name;
    public string Name
    {
        get{return name;}
        set{ name = value;}
    }
    public void InitializeFigure()
        {
            Console.WriteLine("enter number of verticles of your figure");
            number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                points[i] = new Point();
            }

        }
        public double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }
        public double CalculatePerimeter(params Point[] points)
        {
            double perimeter = 0;
            for (int i = 1; i < points.Length; i++)
            {
                perimeter += this.LengthSide(points[i - 1], points[i]);
            }
            perimeter += this.LengthSide(points[0], points[points.Length]);
            return perimeter;
        }
        public Figure(string name)
        {
            InitializeFigure();
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

            Rectangle a = new Rectangle(side1, side2);
            Console.WriteLine($"Area: {a.Area}, Perimeter: {a.Perimeter}");
            Console.ReadLine();
        }
    }
}