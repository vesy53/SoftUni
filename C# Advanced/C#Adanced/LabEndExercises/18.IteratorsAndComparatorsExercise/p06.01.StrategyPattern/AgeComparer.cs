namespace p06._01.StrategyPattern
{
    using System.Collections.Generic;

    public class AgeComparer : IComparer<Person>
    {
        public int Compare(Person firstPerson, Person secondPerson)
        {
            return firstPerson.Age.CompareTo(secondPerson.Age);
        }
    }
}
