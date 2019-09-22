﻿namespace p02._01.ValidationAttributes
{
    using System;

    using Entities;
    using Utilities;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var person = new Person
             (
                 null,
                 -1
             );

            bool isValidEntity = Validator.IsValid(person);

            Console.WriteLine(isValidEntity);

           throw new MyCustomException();
        }
    }
}
