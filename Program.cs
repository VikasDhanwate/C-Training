using System;

namespace ConditionalStatement
{
    class IfStatement
    {
        static void Main(string[] args)
        {
            int number = 12;
            if (number < 7)
            {
                Console.WriteLine("{0} is less than 7", number);
            }
            else
            {
                Console.WriteLine("{0} is not negative", number);
            }
            Console.WriteLine("This Statment is always executed!");
        }
    }
}   
