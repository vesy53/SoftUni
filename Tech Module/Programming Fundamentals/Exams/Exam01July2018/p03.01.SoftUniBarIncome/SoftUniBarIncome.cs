namespace p03._01.SoftUniBarIncome
{
    using System;
    using System.Text.RegularExpressions;

    class SoftUniBarIncome
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            //Regex pattern = new Regex
            //(
            //    @"%(?<name>[A-Z][a-z]+)%[^\.\|\$%]*<(?<product>\w+)>[^\.\|\$%]*\|(?<count>\d+)\|[^\.\|\$%]*(?<price>[1-9]+\d*\.?\d+?)\$"
            //);
            string pattern = @"%(?<name>[A-Z][a-z]*)%[^\.\|\$%]*<(?<product>\w+)>[^\.\|\$%]*\|(?<count>\d+)\|[^\.\|\$%]*(?<price>[1-9]+\d*\.?\d+?)\$";

            double totalSum = 0.0;

            while (input.Equals("end of shift") == false)
            {
                //Match matchIncome = pattern.Match(input);

                if (Regex.IsMatch(input, pattern))
                //if (matchIncome.Success)
                {
                    Match matchIncome = Regex.Match(input, pattern);

                    string name = matchIncome.Groups["name"].Value;
                    string product = matchIncome.Groups["product"].Value;
                    int count = int.Parse(matchIncome.Groups["count"].Value);
                    double price = double.Parse(matchIncome.Groups["price"].Value);
       
                    double sum = count * price;
                    totalSum += sum;
                    
                    Console.WriteLine(
                        $"{name}: {product} - {sum:F2}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalSum:F2}");
        }
    }
}
