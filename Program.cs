/* Name: Vanny Ho
 * Date: 02/09/2023
 * ISM 4300
 */


namespace Deliverable_4____Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] fibonacciNumbers = new int[25];
            fibonacciNumbers[0] = 0;
            fibonacciNumbers[1] = 1;

            for (int i = 2; i < fibonacciNumbers.Length; i++)
            {
                fibonacciNumbers[i] = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];
            }

            Console.WriteLine("The first 25 numbers of the Fibonacci sequence are: ");
            for (int i = 0; i < fibonacciNumbers.Length; i++)
            {
                Console.WriteLine("Fibonacci number (" + i + ") = " + fibonacciNumbers[i]);
            }

            Console.ReadLine();
        }
    }
}