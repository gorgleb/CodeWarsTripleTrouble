using System;
using System.Linq;
using System.Text;

namespace CodeWars
{
    class Program
    {

        static void Main(string[] args)
        {
            long num1 = 451999277;
            long num2 = 41177722899;
            
            Console.WriteLine(Kata.TripleDouble(num1,num2));

        }


    }

    public class Kata
    {
        public static int TripleDouble(long num1, long num2)
        {
            int[] num1array = num1.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();
            int[] num2array = num2.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();
            int duplicate = 0;
            int flag = 0;
            for (int i = 0; i+4 <= num1array.Length; i++)
            {
                if (num1array[i] == num1array[i + 1] & num1array[i+1] == num1array[i + 2]& num1array[i + 2] != num1array[i + 3])
                {
                    duplicate = num1array[i];
                }
            }
            for (int i = 0; i+2 <= num2array.Length; i++)
            {
                if (num2array[i] == duplicate & num2array[i + 1] == num2array[i]& num2array[i + 1] != num2array[i+2])
                {
                    flag=1;
                }
                
            }
            return flag;
        }
    }
    
}
    