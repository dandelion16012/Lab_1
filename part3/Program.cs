using System;
using System.Drawing;
using System.Reflection.Metadata;

public class Point
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
        
        Console.WriteLine("Enter X:");
        this.x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Y:");
        this.y = int.Parse(Console.ReadLine());
    }
    public Point(int x, int y)
    {
        this.x = x; this.y = y; 
    }
}


public class Figure
    {
    private int number;
    private Point?[] points;
    string name;
    public string Name
    {
        get{return name;}
        set{ name = value;}
    }
    public void InitializeFigure()
    {
        Console.WriteLine("введите количество вершин вашей фигуры");
        number = int.Parse(Console.ReadLine());
        Console.WriteLine("введите название вашей фигуры");
        name = Console.ReadLine();
        points = new Point[number];

        for (int i = 0; i < number; i++)
        {
            points[i] = new Point();
        }

    }
    public double LengthSide(Point a, Point b)
    {
        return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
    }
    public double PerimeterCalculate(params Point[] points)
    {
        double perimeter = 0;
        for (int i = 0; i < points.Length - 1; i++)
        {
            perimeter += this.LengthSide(points[i], points[i+1]);
        }
        perimeter += this.LengthSide(points[0], points[points.Length-1]);
        return perimeter;
       
    }
    public double PerimeterCalculate()
    {
        double perimeter = 0;
        for (int i = 0; i < points.Length - 1; i++)
        {
            perimeter += this.LengthSide(points[i], points[i + 1]);
        }
        perimeter += this.LengthSide(points[0], points[points.Length - 1]);
        return perimeter;

    }
    public Figure()
    {
        InitializeFigure();
    }
    public Figure(string name,  int number, params Point[] points)
    {
        this.name = name;
        this.number = number;
        this.points = new Point[number];

        for (int i = 0; i < number; i++)
        {
            this.points[i] = points[i];
        }

    }
}



namespace part3
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure a = new Figure();
            Console.WriteLine($"Name: {a.Name}, Perimeter: {a.PerimeterCalculate()}");
            Console.ReadKey();
        }
    }
}