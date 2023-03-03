namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
            string output = Console.ReadLine();
            while (output != "stop")
            {
                Console.WriteLine("What's Your Name?");
                string name = Console.ReadLine();
            }

        }
        public static void Greeting(string name)
        {

            DateTime now = new DateTime();
            int hour = now.Hour;
            if (hour < 20 && hour > 6)
            {
                Console.WriteLine($" ¡Buenas noches {name}");
            }
            else if (hour < 6 && hour > 12)
            {
                Console.WriteLine($" ¡Buenas dias {name}");
            }
            else if (hour < 12 && hour > 20)
            {
                Console.WriteLine($" ¡Buenas target {name}");
            }
        }

    }
}