using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Trapezoid : Figure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double HeightOf_AB { get; set; } 

        public override double GetArea()
        {
            return 0.5 * (SideA + SideB) * HeightOf_AB;
        }
    }
}
