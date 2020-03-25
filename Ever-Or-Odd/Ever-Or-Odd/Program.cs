using System;

namespace Ever_Or_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            bool status = false;
            string endApp = " ";
            int num = 0;
            while (!status) { 
                Console.WriteLine("Type your number");
                num = Convert.ToInt32(Console.ReadLine());
                if ((~num & 1) == 1)
                {
                    Console.WriteLine("Even number " + num);
                }
                if ((~num & 1) == 0)
                {
                    Console.WriteLine("Odd number " + num);
                }
                Console.WriteLine("Type your something");
                if (endApp == "Y")
                {
                    status = true;
                }else if (endApp == "N")
                {
                    status = false;
                }

            }
        }
    }
}
