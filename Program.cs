using System;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num,i;

            for(num=2;num<=10;num++)
                for(i=1;i<=10;i++)
                {
                    Console.WriteLine(num + " * " +i + " = " +(num * i));
                }
            
            if (num % 2 ==0)
            {
                Console.WriteLine(num + " Even");
            }
            else
            {
                Console.WriteLine(num + " Odd");
            }
        }
    }
}
