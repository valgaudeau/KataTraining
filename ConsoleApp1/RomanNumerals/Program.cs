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
            if(value < 0) throw new ArgumentException("You cannot pass a negative value to this method");

            string[] OneToNine = new string[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] TenToNinety = new string[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] HundredToNineHundred = new string[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            // Didn't want to go over 3000 because had to set limit somewhere and 5000 is unwrittable - http://www.romannumerals.co/number-converter/5000-in-roman-numerals/
            string[] OneThousandToThreeThousand = new string[] { "", "M", "MM", "MMM" }; 
            // Map to string arrays
            return OneThousandToThreeThousand[value / 1000] + HundredToNineHundred[(value % 1000) / 100] + TenToNinety[(value % 100) / 10] + OneToNine[value % 10];
        }

    }
}