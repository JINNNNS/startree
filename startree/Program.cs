﻿using System;
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
            for(int i = 0; i < 15; i++)
            {
                for(int j = 0; j < 15 - i; j++)
                {
                    Console.Write(" ");
                    
                }
            }
        }
    }
}
