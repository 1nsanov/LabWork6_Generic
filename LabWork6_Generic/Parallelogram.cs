using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork6_Generic
{
    public class Parallelogram<T>
        where T : struct
    {
        public T SideA { get; set; }
        public T SideB { get; set; }
        public T Angle { get; set; }

        public Parallelogram(T sideA, T sideB, T angle)
        {
            if (Convert.ToDouble((dynamic)sideA) < 0 || Convert.ToDouble((dynamic)sideB) < 0)
            {
                throw new Exception("Сторона не может быть меньше нуля");
            }
            if (Convert.ToDouble((dynamic)angle) < 0)
            {
                throw new Exception("Угол не может быть меньше нуля");
            }
            SideA = sideA;
            SideB = sideB;
            Angle = angle;
        }

        public double CalcSquare()
        {
            var square = (dynamic)SideA * (dynamic)SideB;
            return Math.Round(Convert.ToDouble(square), 2);
        }

        public override string ToString()
        {
            return $"A: {SideA} | B:{SideB} | Угол: {Angle} | {CalcSquare()}";
        }
    }
}
