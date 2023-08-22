namespace Task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i,k;

            for (i = 1; i <= 6; i++)
            {
                for (k = 1; k <= 6 - i; k++)
                {
                    Console.Write(" ");
                }
                DrawStars(i);
            }
            BreakLine(2);

            for (i = 1; i <= 6; ++i)
            {
                DrawStars(i);
            }
            BreakLine(2);


            for (i = 5; i >= 1; --i)
            {
                DrawStars(i);
            }
            
        }

        #region Methods
        private static void DrawStars(int i)
        {
            for (int j = 1; j <= i; ++j)
            {
                Console.Write("*");
            }
            BreakLine(1);
        }

        private static void BreakLine(int numberOfLine)
        {
            for (int i = 1; i <= numberOfLine; ++i)
            {
                Console.WriteLine();
            }
        } 
        #endregion
    }
}