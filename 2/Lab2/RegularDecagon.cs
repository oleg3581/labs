using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class RegularDecagon : Figure
    {
        public double SideA { get; set; }

        public override double GetArea()
        {
           return ((10 * Math.Pow(SideA, 2)) / (4 * Math.Tan(360 / 20 * (Math.PI / 180))));
        }
    }
}
