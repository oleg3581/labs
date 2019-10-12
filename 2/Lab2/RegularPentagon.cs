using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class RegularPentagon : Figure
    {
        public double SideA { get; set; }

        public override double GetArea()
        {
            return (5 * Math.Pow(SideA, 2)) / (4 * Math.Tan(360 / 10 * Math.PI / 180));
        }
    }
}
