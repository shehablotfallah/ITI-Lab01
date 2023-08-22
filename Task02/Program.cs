namespace Task02
{
    internal class Program
    {
        private const string Value = "Please Enter a list of space separated words";

        static void Main(string[] args)
        {
            Console.Write($"{Value}: ");
            /*
             Enter a list of space separated words
                
                Input:→ this is a test		
                Input:→ all your base		
                Input:→ Word

             */

            var input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                string[] words = input.Split(' ');
                Array.Reverse(words);
                string output = string.Join(' ', words);

                Console.Write($"The reversed list is: {output}");
            }
            else
            {
                Console.WriteLine($"{Value}!");
            }
            
        }
    }
}