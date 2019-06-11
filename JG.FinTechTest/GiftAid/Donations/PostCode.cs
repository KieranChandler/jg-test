using System;
using System.Text.RegularExpressions;
namespace JG.FinTechTest.GiftAid.Donations
{
    public class PostCode
    {
        public string Value { get; set; }

        public PostCode(string raw)
        {
            bool isMatch = Regex.IsMatch(
                raw,
                "^[A-z]{1,2}\\d{1,2}\\s*\\d{1,2}[A-z]{1,2}$");

            if (!isMatch)
                throw new FormatException($"The raw PostCode provided '{raw}' is not valid");

                Value = raw;
        }
    }
}