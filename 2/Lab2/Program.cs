using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа №2 - Наследование");
            Console.WriteLine("Выполнил - Тищенко Олег");

                                                        //Создадим промоугольники А и В и зададим их параметры
            Rectangle a = new Rectangle()
            { Name = "Прямоугольник А", Width = 15.4, Height = 13.7 };

            Rectangle b = new Rectangle()
            { Name = "Прямоугольник В", Width = 5.1, Height = 6.8 };

                                                        //Выведем информацию о прямоугольнике
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", a.Name);
            Console.WriteLine("Прощадь фигуры: {0}", a.GetArea());
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", b.Name);
            Console.WriteLine("Прощадь фигуры: {0}", b.GetArea());

                                                        //Круг
            Circle c = new Circle()
            { Name = "Круг", Radius = 7 };
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", c.Name);
            Console.WriteLine("Прощадь фигуры: {0}", c.GetArea());

                                                        //Квадрат
            Square d = new Square()
            { Name = "Квадрат", Side = 3 };
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", d.Name);
            Console.WriteLine("Прощадь фигуры: {0}", d.GetArea());

                                                       //Параллелограм
            Parallelogram p = new Parallelogram()
            { Name = "Параллелограм 1", SideA = 4, SideB = 7, AngleBetweenAB = 75 };
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", p.Name);
            Console.WriteLine("Прощадь фигуры: {0}", p.GetArea());

            Parallelogram p1 = new Parallelogram()
            { Name = "Параллелограм 2", SideA = 4, SideB = 7, AngleBetweenAB = 75, HeightA = 4, HeightB = 0 };
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", p1.Name);
            Console.WriteLine("Прощадь фигуры: {0}", p1.GetArea());

            //Правильный десятиугольник
            RegularDecagon q = new RegularDecagon()
            { Name = "Правильный десятиугольник", SideA = 4 };
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", q.Name);
            Console.WriteLine("Прощадь фигуры: {0}", q.GetArea());

            //Правильный пятиугольник
            RegularPentagon k = new RegularPentagon()
            { Name = "Правильный пятиугольник", SideA = 7 };
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", k.Name);
            Console.WriteLine("Прощадь фигуры: {0}", k.GetArea());

            //Ромб
            Rhombus m = new Rhombus()
            { Name = "Ромб 1", BigAngle = 94, SmallAngle = 86, Diag1 = 0, Diag2 = 0, Side = 5, HeightSide = 4 };
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", m.Name);
            Console.WriteLine("Прощадь фигуры: {0}", m.GetArea());

            Rhombus m1 = new Rhombus()
            { Name = "Ромб 2", BigAngle = 94, SmallAngle = 80, Diag1 = 4, Diag2 = 2, Side = 5, HeightSide = 4 };
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", m1.Name);
            Console.WriteLine("Прощадь фигуры: {0}", m1.GetArea());


            //Трапеция
            Trapezoid j = new Trapezoid()
            { Name = "Трапеция", SideA = 10, SideB = 7, HeightOf_AB = 3 };
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", j.Name);
            Console.WriteLine("Прощадь фигуры: {0}", j.GetArea());

            //Треугольник
            Triangle g = new Triangle()
            { Name = "Треугольник 1", SideA = 2, SideB = 3, SideC = 4 };
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", g.Name);
            Console.WriteLine("Прощадь фигуры: {0}", g.GetArea());

            Triangle g1 = new Triangle()
            { Name = "Треугольник 2", SideA = 20, SideB = 3, SideC = 4 };
            Console.WriteLine();
            Console.WriteLine("Название фигуры: {0}", g1.Name);
            Console.WriteLine("Прощадь фигуры: {0}", g1.GetArea());
            Console.ReadKey();
            
         
        }
        
    }
}

