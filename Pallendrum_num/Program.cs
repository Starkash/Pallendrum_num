using System;

namespace Pallendrum_num
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any Number");
            int n1 = int.Parse(Console.ReadLine());
            int rev= 0; int m = n1;
            while (n1 != 0)
            {
                int rem = n1 % 10;
                rev = rev * 10 + rem;
                n1 /= 10;
            }
                if (rev == m)
                    Console.WriteLine("This is Pallendrum Number");
                else
                {
                    Console.WriteLine("This is not Pallendrum Number");
                }



            


        }
    }
}
