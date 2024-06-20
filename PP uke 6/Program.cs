namespace PP_uke_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the insect finder");
            Console.WriteLine("1) See a list of available bugs");
            Console.WriteLine("2) Add more bugs");

            var userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    Bug.Menu();
                    break;
            }
        }
    }
}
