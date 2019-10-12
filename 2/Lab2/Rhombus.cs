using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Rhombus : Figure
    {
        public double Side { get; set; }
        public double Diag1 { get; set; }
        public double Diag2 { get; set; }
        public double BigAngle { get; set; }
        public double SmallAngle { get; set; }
        public double HeightSide { get; set; }

        public override double GetArea()
        {
            if ((SmallAngle + BigAngle) != 180)
            {
                Console.WriteLine("Неверные углы.");
            }

            if (Side > 0 && HeightSide > 0)
            {
                return Side * HeightSide;
            }
            else if(Side > 0 && (SmallAngle > 0 || BigAngle > 0))
            {
                if (SmallAngle > 0)
                {
                    return Side* Side * Math.Sin(SmallAngle * (Math.PI / 180));
                }
                else if (BigAngle > 0)
                {
                    return Side * Side * Math.Sin(BigAngle * (Math.PI / 180));
                }
                return 0; 
            }
            else if(Diag1 > 0 && Diag2 > 0)
            {
                return 1 / 2 * Diag2 * Diag1;
            }
            else
            {
                Console.WriteLine("Недостаточно данных для вычисления площади ");
                Console.WriteLine();
                return 0;
            }
        }


    }
}
