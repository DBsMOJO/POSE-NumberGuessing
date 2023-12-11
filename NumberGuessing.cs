/*--------------------------------------------------------------
 *				HTBLA-Leonding / Class: 3.ACIF
 *--------------------------------------------------------------
 *              Daniel Binder, 27.11.2023
 *--------------------------------------------------------------
 * Description:
 * Guess a random number between 1 and 100
 *--------------------------------------------------------------
*/

using System;

namespace NumberGuessing
{
    class Program
    {
        public static void Main()
        {
            string input;
            int guessNumber,
                inputNumber,
                counter = 0;
            Random random;

            // Entry

            Console.Clear();
            Console.WriteLine("Versuche meine Zahl zu erraten <1-100>!");

            // Processing

            random = new Random();
            guessNumber = random.Next(1, 101);

            do
            {
                counter += 1;
                Console.Write("{0}. Versuch: ", counter);
                input = Console.ReadLine();
                inputNumber = Convert.ToInt32(input);

                if (inputNumber < guessNumber)
                {
                    Console.WriteLine("                << Gesuchte Zahl ist GRÖSSER!"); //twice as many lines, twice as much clearer
                }
                else if (inputNumber > guessNumber)
                {
                    Console.WriteLine("                << Gesuchte Zahl ist KLEINER!");
                }
            } while (guessNumber != inputNumber);

            // Output

            Console.WriteLine("                << RICHTIG !");
            Console.WriteLine();

            if (counter <= 5)
            {
                Console.WriteLine("Tolle Leistung!");
            }
            else if (counter > 5 && counter < 10)
            {
                Console.WriteLine("Schon ganz gut!");
            }
            else
                Console.WriteLine("Endlich geschafft!");
            Console.WriteLine();
        }
    }
}
