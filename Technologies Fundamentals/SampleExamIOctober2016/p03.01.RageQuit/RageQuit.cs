namespace p03._01.RageQuit
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    class RageQuit
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex pattern = new Regex(@"(?<symbols>\D+)(?<nums>[0-9]{0,20})");
            //Regex pattern = new Regex(@"(?<symbols>[^0-9]+)(?<nums>[0-9]+)");

            MatchCollection matches = pattern.Matches(input);

            StringBuilder builder = new StringBuilder();

            foreach (Match match in matches)
            {
                string symbols = match.Groups["symbols"].Value.ToUpper();
                int num = int.Parse(match.Groups["nums"].Value);

                for (int i = 0; i < num; i++)
                {
                    builder.Append(symbols);
                }
            }
            
            Console.WriteLine(
                $"Unique symbols used: {builder.ToString().Distinct().Count()}");
            Console.WriteLine(builder);

            //при този вход: 
            //e -!btI17z=E:DMJ19U1Tvg VQ>11P"qCmo.-0YHYu~o%/%b.}a[=d15fz^"{0^/pg.Ft{W12`aD<l&$W&)*yF1WLV9_GmTf(d0($!$`e/{D'xi]-~17 *%p"%|N>zq@ %xBD18<Y(fHh`@gu#Z#p"Z<v13fI]':\Iz.17*W:\mwV`z-15g@hUYE{_$~}+X%*nytkW15
            //ако използваме List<char> дава грешен Count (54 вместо 53)
        }
    }
}
