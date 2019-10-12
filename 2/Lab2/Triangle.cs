using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Triangle : Figure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public override double GetArea()
        {
            if ((SideA < SideB + SideC) && (SideA > SideB - SideC) && (SideB < SideA + SideC) && (SideB > SideA - SideC) && (SideC < SideA + SideB) && (SideC > SideA - SideB))
            {
                double P = 0.5 * (SideA + SideB + SideC);
                return (Math.Sqrt(P * (P - SideA) * (P - SideB) * (P - SideC)));
            }
            else
            {
                Console.WriteLine("Неправильные данные");
                return 0;
            }

        }

    }
}
