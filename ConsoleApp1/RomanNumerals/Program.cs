namespace RomanNumerals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IntegerToRoman(2351)); // MMCCCLI
            Console.WriteLine(IntegerToRoman(100)); // C
            Console.WriteLine(IntegerToRoman(15)); // XV
        }

        public static string IntegerToRoman(int value) 
        {
            string[] units = new string[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] tens = new string[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] hundreds = new string[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            // Didn't want to go over 3000 because had to set limit somewhere and 5000 is unwrittable - http://www.romannumerals.co/number-converter/5000-in-roman-numerals/
            string[] thousands = new string[] { "", "M", "MM", "MMM" }; 

            return thousands[value / 1000] + hundreds[(value % 1000) / 100] + tens[(value % 100) / 10] + units[value % 10];
        }

    }
}