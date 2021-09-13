using System;

namespace ConditionalStatement
{
    class IfStatement
    {
        static void Main(string[] args)
        {
            int number = 12;
            if (number < 5)
            {
                Console.WriteLine("{0} is less than 5", number);
            }
            else
            {
                Console.WriteLine("{0} is not negative", number);
            }
            Console.WriteLine("This Statment is always executed!");
        }
    }
}   
