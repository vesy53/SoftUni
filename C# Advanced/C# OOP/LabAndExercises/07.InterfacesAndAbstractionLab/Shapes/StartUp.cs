﻿namespace Shapes
{
    using Core;
    using Core.IO;
    using Core.IO.Contracts;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            IReader reader = new Reader();

            Engine engine = new Engine(reader);
            engine.Run();
        }
    }
}
