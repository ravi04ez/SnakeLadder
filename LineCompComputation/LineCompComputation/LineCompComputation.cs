﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineCompComputation
{
    public class LineCompComputation
    {
        double Linelength;
        public void CalLineLength()
        {
            Console.Write(" Please Enter The Point 1 Coordinate X1:- ");
            int X1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Please Enter The Point 1 Coordinate X2:- ");
            int X2 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Please Enter The Point 2 Coordinate Y1:- ");
            int Y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Please Enter The Point 2 Coordinate Y2:- ");
            int Y2 = Convert.ToInt32(Console.ReadLine());

            double Length = Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2);
            Linelength = Math.Sqrt(Length);
            Console.WriteLine(Linelength);
            Console.ReadKey();
         }
    }
}
