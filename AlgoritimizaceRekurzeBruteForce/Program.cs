namespace Maturita
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 6, 5, 4, 7, 8, 9, 3, 56, 1 };

            Console.WriteLine(BruteForce(numbers));
            Console.WriteLine(Heuristika(numbers));

            Console.WriteLine(RecursionFactorial(10));
            Console.WriteLine(BruteForceFactorial(10));

        }

        /// <summary>
        /// prochazime vsechny moznosti a hledame to nejmensi
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int BruteForce(List<int> numbers)
        {
            int min = int.MaxValue;

            foreach (int i in numbers)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            return min;
        }

        /// <summary>
        /// my vime z dat ze minimalni cislo je vzdycky posledni
        /// takze return posledni cislo
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int Heuristika(List<int> numbers)
        {
            return numbers[numbers.Count - 1];
        }

        /// <summary>
        /// Recurzivni factorial
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static int RecursionFactorial(int a)
        {
            if (a < 0)
            {
                throw new ArgumentException("Number can't be less than zero");
            }

            if (a == 0 || a == 1) { return 1; }

            return a * RecursionFactorial(a - 1);
        }

        /// <summary>
        /// Brute force factorial
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static int BruteForceFactorial(int a)
        {
            if (a < 0)
            {
                throw new ArgumentException("Number can't be less than zero");
            }

            int result = 1;

            for (int i = 1; i <= a; i++)
            {
                result *= i;
            }

            return result;
        }

        /// <summary>
        /// every time returns different output
        /// </summary>
        /// <returns></returns>
        public static int Nondeterministic(int min, int max)
        {
            if(min > max)
            {
                throw new ArgumentException("Min can't be more than max");
            }
            Random rnd = new Random();
            return rnd.Next(min, max);
        }

    }
}