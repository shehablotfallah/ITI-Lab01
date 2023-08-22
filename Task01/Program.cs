namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("Enter the range of numbers (two integers separated by this : ):");
                string? input = Console.ReadLine();

                string[] numbers = input!.Split(':');
                bool isNumberStart = int.TryParse(numbers[0], out int start);
                bool isNumberEnd = int.TryParse(numbers[1], out int end);

                if (!(isNumberStart && isNumberEnd))
                {
                    Console.WriteLine(" Please enter a valid number");
                    return;
                }

                Console.WriteLine("Enter E for even or O for odd:");
                char choice = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();
                if (choice == 'E')
                {
                    Console.Write("The even numbers between {0} and {1} are: ", start, end);
                    for (int i = start; i <= end; i++)
                    {
                        if (i % 2 == 0)
                            Console.Write(i + " ");
                    }
                    Console.WriteLine();
                }
                else if (choice == 'O')
                {
                    Console.Write($"The odd numbers between {start} and {end} are: ");
                    for (int i = start; i <= end; i++)
                    {
                        if (i % 2 != 0)
                            Console.Write($"{i} ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }

                Console.WriteLine("Do you want to try again? (Y/N)");
                char answer = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();
                if (answer == 'N')
                {
                    repeat = false;
                    Console.WriteLine("Thank you for using Program. Goodbye!");
                }
            }
        } 
    }
}