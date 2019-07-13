namespace p04._01.Telephony
{
    using System.Linq;

    public class Smartphone : ICallable, IBrowsable
    {
        public string Browse(string url)
        {
            string result = string.Empty;

            if (!url.Any(u => char.IsDigit(u)))
            {
                result = string.Format(
                    $"Browsing: {url}!"); 
            }
            else
            {
                result = string.Format(
                    "Invalid URL!");
            }
            
            return result;
        }

        public string Call(string number)
        {
            string result = string.Empty;

            if (number.All(u => char.IsDigit(u)))
            {
                result = string.Format(
                    $"Calling... {number}");
            }
            else
            {
                result = string.Format(
                    "Invalid number!");
            }

            return result;
        }
    }
}
