using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySum
{
    class ArraySum
    {
        static void Main(string[] args)
        {

            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("Path"), true);

            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = simpleArraySum(ar);

            Console.WriteLine(result);
            Console.ReadLine();
           
        }


        static int simpleArraySum(int[] ar)
        {
            /*
             * Write your code here.
             */
            int result = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                result += ar[i];
            }

            return result;
        }
    }
}
