﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonHeight
{
    internal class Heights
    {
        public static void Main()
        {
            float height;
            Console.WriteLine("Enter  the Height (in centimeters) \n");
            height = int.Parse(Console.ReadLine());
            if (height < 150.0)
                Console.WriteLine("Dwarf \n");
            else if ((height >= 150.0) && (height <= 165.0))
                Console.WriteLine(" Average Height \n");
            else if ((height >= 165.0) && (height <= 195.0))
                Console.WriteLine("Taller \n");
            else
                Console.WriteLine("Abnormal height \n");
        }
    }
}
