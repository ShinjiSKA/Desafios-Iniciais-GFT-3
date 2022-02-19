using System;

namespace DigitalInnovationOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            //Digite o seu código aqui
            
            do
            {
                if (x % 2 == 1)
                {
                    x++;
                }
                int x2 = x + 2;
                int x3 = x2 + 2;
                int x4 = x3 + 2;
                int x5 = x4 + 2;
                Console.WriteLine(x + x2 + x3 + x4 + x5);
                x = Convert.ToInt32(Console.ReadLine());
            }
            while (x != 0);
            
        }
    }
}
