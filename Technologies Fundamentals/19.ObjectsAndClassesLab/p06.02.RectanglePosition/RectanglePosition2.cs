using System;
using System.Linq;

class RectanglePosition2
{
    static void Main(string[] args)
    {
        Rectangle firstRect = ReadRectangle();
        Rectangle secondRect = ReadRectangle();

        if (firstRect.IsInside(secondRect))
        {
            Console.WriteLine("Inside");
        }
        else
        {
            Console.WriteLine("Not inside");
        }
    }

    static Rectangle ReadRectangle()
    {
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        Rectangle points = new Rectangle
        {
            Left = numbers[0],
            Top = numbers[1],
            Width = numbers[2],
            Height = numbers[3]
        };

        return points;
    }
}

class Rectangle
{
    public int Left { get; set; }
    public int Top { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }

    public int Bottom
    {
        get
        {
            return Top + Height;
        }
    }

    public int Right
    {
        get
        {
            return Left + Width;
        }
    }

    public bool IsInside(Rectangle secondRect)
    {
        bool isInside =
            Left >= secondRect.Left &&
            Top >= secondRect.Top &&
            Bottom <= secondRect.Bottom &&
            Right <= secondRect.Right;

        return isInside;
    }
}