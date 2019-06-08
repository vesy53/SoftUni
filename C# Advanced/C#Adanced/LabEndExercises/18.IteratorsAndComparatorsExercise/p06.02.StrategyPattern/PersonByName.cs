﻿namespace p06._02.StrategyPattern
{
    using System;
    using System.Collections.Generic;

    public class PersonByName : IComparer<Person>
    {
        public int Compare(Person first, Person second)
        {
            int result = first.Name.Length.CompareTo(second.Name.Length);

            if (result == 0)
            {
                char firstPersonLetter = Char.ToLower(first.Name[0]);
                char secondPersonLetter = Char.ToLower(second.Name[0]);

                result = firstPersonLetter.CompareTo(secondPersonLetter);
            }

            return result;
        }
    }
}
