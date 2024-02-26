using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = int.Parse(Console.ReadLine());
            if(a%4 == 0) 
            {
                Console.WriteLine("é divisivel por 4");
            }
            else
            {
                Console.WriteLine("não é divisivel por 4");
            }
            Console.ReadKey();  

        }
    }
}
