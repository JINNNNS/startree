using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace startree
{
    class Program
    {
        static void Main(string[] args)
        {
            //8줄
            for(int i = 0; i < 8; i++)
            {
                
                for(int j = 8-i; j >0; j--)
                {
                    Console.Write(" "); //라인
                    
                }
                for(int j = 0; j < i * 2 + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
