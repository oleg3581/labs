using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Lab2
{
    class Parallelogram : Figure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double HeightA { get; set; }
        public double HeightB { get; set; }
        public double AngleBetweenAB { get; set; }

        public override double GetArea()
        {
            if (SideA > 0 && HeightA > 0)
            {
                return SideA * HeightA;
            }
            else if (SideB > 0 && HeightB > 0)
            {
                return SideB * HeightB;
            }
            else if (SideA > 0 && SideB > 0 && AngleBetweenAB > 0)
            {
                return SideA * SideB * Math.Sin(AngleBetweenAB * (Math.PI/180));
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine();
                return 0;
            }

        }
    }
}
