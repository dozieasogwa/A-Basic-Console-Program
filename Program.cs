namespace BasicConsoleProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program that collects a users input and determines if it's a number.

            Console.WriteLine("Please type a number:");

            do
            {
                var userInput = Console.ReadLine();
                int number;

                if (string.IsNullOrEmpty(userInput))
                {
                    Console.WriteLine(" You've not entered a number! \n Please enter a number: \n");
                }

                else if (!int.TryParse(userInput, out number))

                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n You've entered an invalid number!");
                    Console.ResetColor();
                    Console.WriteLine(" Please enter a number: \n");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n Bravo! Number recieved.");
                    Console.ResetColor();

                    Console.WriteLine("\n Please enter another one: \n");
                }

            } while (true);


        }
    }
}
