namespace p06._01.StrategyPattern
{
    using System.Collections.Generic;

    public class NameComparer : IComparer<Person>
    {
        public int Compare(Person firstPerson, Person secondPerson)
        {
            int result = firstPerson.Name.Length.CompareTo(secondPerson.Name.Length);

            if (result == 0)
            {
                result = firstPerson.Name.ToLower()[0].CompareTo(secondPerson.Name.ToLower()[0]);
            }

            return result;
        }
    }
}
