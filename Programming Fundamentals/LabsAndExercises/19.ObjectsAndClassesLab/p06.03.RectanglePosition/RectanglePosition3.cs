using System;
using System.Linq;

class RectanglePosition3
{
    static void Main(string[] args)
    {
        int[] firstRect = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        int[] secondRect = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        Rectangle firstRectangle = new Rectangle
        {
            Left = firstRect[0],
            Top = firstRect[1],
            Width = firstRect[2],
            Height = firstRect[3]
        };

        Rectangle secRectangle = new Rectangle
        {
            Left = secondRect[0],
            Top = secondRect[1],
            Width = secondRect[2],
            Height = secondRect[3]
        };

        bool isInside = firstRectangle.IsInside(secRectangle);

        string printIsInside = isInside ?
            "Inside" :
            "Not inside";

        Console.WriteLine(printIsInside);
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

    public bool IsInside(Rectangle secRectangle)
    {
        bool isInside =
            Left >= secRectangle.Left &&
            Top >= secRectangle.Top &&
            Bottom <= secRectangle.Bottom &&
            Right <= secRectangle.Right;

        return isInside;
    }
}