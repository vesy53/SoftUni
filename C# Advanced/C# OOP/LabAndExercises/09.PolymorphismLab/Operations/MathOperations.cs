namespace Operations
{
    public class MathOperations : IMathOperations
    {
        public int Add(
            int firstElement,
            int secondElement)
        {
            int sum = firstElement + secondElement;

            return sum;
        }

        public double Add(
            double firstElement, 
            double secondElement, 
            double thirdElement)
        {
            double sum = firstElement + 
                         secondElement + 
                         thirdElement;

            return sum;
        }

        public decimal Add(
            decimal firstElement, 
            decimal secondElement, 
            decimal thirdElement)
        {
            decimal sum = firstElement +
                          secondElement +
                          thirdElement;

            return sum;
        }
    }
}
