using System;
using System.Linq;

class RectanglePosition
{
    static void Main(string[] args)
    {
        Rectangle firstRec = ReadRectangle();
        Rectangle secondRec = ReadRectangle();

        bool isInside = IsInside(firstRec, secondRec);

        if (isInside)
        {
            Console.WriteLine("Inside");
        }
        else
        {
            Console.WriteLine("Not inside");
        }
    }

    static bool IsInside(Rectangle firstRec, Rectangle secondRec)
    {
        bool isInside =
            firstRec.Left >= secondRec.Left &&
            firstRec.Right <= secondRec.Right &&
            firstRec.Top <= secondRec.Top &&
            firstRec.Bottom <= secondRec.Bottom;

        return isInside;
    }

    static Rectangle ReadRectangle()
    {
        int[] arr = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        Rectangle sides = new Rectangle
        {
            Left = arr[0],
            Top = arr[1],
            Width = arr[2],
            Height = arr[3]
        };

        return sides;
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
}