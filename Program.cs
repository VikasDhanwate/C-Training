using System;

namespace AccessSpecifierExample
{
    class ParamsEx
    {
        public void Show(params int[] val)
        {
            for(int i=0;i<val.Length;i++)
            {
                Console.WriteLine(val[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Wel Come To Params Program !!!");
            ParamsEx pe = new ParamsEx();
            pe.Show(2, 3, 4, 5);
            
        }
    }
}
