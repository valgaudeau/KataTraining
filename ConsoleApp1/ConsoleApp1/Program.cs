using System.Globalization;

namespace MoneyProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List<decimal> result = MoneyProblem(75.35M); 
            // List<decimal> result = MoneyProblem(75.40M);
            // List<decimal> result = MoneyProblem(75);
            List<decimal> result = MoneyProblem(44);

            foreach (decimal i in result)
            {
                Console.Write(i + " ");
            }
        } 
        
        //  static Dictionary<double,int> MoneyProblem(double amount)
        static List<decimal> MoneyProblem(decimal amount)
        {
            if (amount < 0) throw new ArgumentException("You cannot pass a negative value to this method");

            decimal[] billsAndCoins = new decimal[] { 50, 20, 10, 5, 2, 1, 0.5M, 0.2M, 0.1M, 0.05M, 0.02M, 0.01M };
            //Dictionary<double,int> choices = new Dictionary<double,int>();
            List<decimal> choices = new List<decimal>();
            while (amount > 0)
            {
                for (int i = 0; i < billsAndCoins.Length; i++)
                {
                    while (billsAndCoins[i] <= amount)
                    {
                        amount = amount - billsAndCoins[i];
                        choices.Add(billsAndCoins[i]);
                        if (amount == 0) return choices;
                    }
                }
            }
            return choices;
        }
    }
}