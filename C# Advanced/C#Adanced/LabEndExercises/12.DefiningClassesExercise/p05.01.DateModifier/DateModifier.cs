namespace p05._01.DateModifier
{
    using System;

    public class DateModifier
    {
        public int CalculateDifferenceBetweenTwoDates(
            string firstDateStr, 
            string secondDateStr)
        {
            DateTime parsedFirstDate = DateTime.Parse(firstDateStr);
            DateTime parsedSecondDate = DateTime.Parse(secondDateStr);

            int difference = (int)Math.Abs((parsedFirstDate - parsedSecondDate).TotalDays);
            //int difference = (int)Math.Abs((parsedFirstDate - parsedSecondDate).Days);

            return difference;
        }
    }
}
