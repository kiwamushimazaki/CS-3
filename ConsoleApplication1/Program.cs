using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class MainClass
    {

        static void Main()
        {
            for (int i =1; i <= 100; i++)
            {
                if (i%3==0 | i%7 ==0)
                {
                    continue;
                    
                }
                Console.Write(i + " ");
            }
        }

      
    }
}
