using SingleResponsibilityPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.Models
{
    public class Square : IShape
    {
        public double Length { get; set; }

        public Square(double length)
        {
            this.Length = length;
        }

        public double CalculateArea()
        {
            return Length * Length;
        }

        public double CalculatePerimeter()
        {
            return Length * 4;
        }
    }
}
