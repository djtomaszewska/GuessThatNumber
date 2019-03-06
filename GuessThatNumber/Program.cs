using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThatNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int _numberToGuess = 5428;
            int[] arrayOfFour = new int[4];
            arrayOfFour = ConvertToSeparate(_numberToGuess);

            foreach(int a in arrayOfFour)
            {
                Console.WriteLine(a);
            }
            Console.ReadKey();
        }
        static int[] ConvertToSeparate(int number)
        {
            int[] arrayOfFour = new int[4];
            int a=0, b=0, c=0, d=0;
            while(number>1000)
            {
                number -= 1000;
                arrayOfFour[0]++;
            }
            
            while (number > 100)
            {
                number -= 100;
                arrayOfFour[1]++;
            }
            while (number > 10)
            {
                number -= 10;
                arrayOfFour[2]++;
            }
            arrayOfFour[3] = number;
            
            return arrayOfFour;
        }
    }
}
