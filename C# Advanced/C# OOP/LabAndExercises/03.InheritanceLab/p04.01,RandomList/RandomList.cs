﻿namespace p04._01_RandomList
{
    using System;
    using System.Collections.Generic;

    public class RandomList : List<string>
    {
        public Random RandomGenerator { get; set; }

        public RandomList()
        {
            this.RandomGenerator = new Random();
        }

        public string RandomString()
        {
            string result = string.Empty;

            if (this.Count > 0)
            {
                int index = RandomGenerator
                    .Next(0, this.Count - 1);

                result = this[index];
                this.RemoveAt(index);
            }

            return result;
        }
    }
}
