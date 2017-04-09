using SingleResponsibilityPrinciple.Models;
using SingleResponsibilityPrinciple.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(3.2);
            Square square = new Square(2.8);

            ShapeOutputService outputService = new ShapeOutputService();

            Console.WriteLine(outputService.OutputAsHTML(circle));
            Console.WriteLine(outputService.OutputAsHTML(square));
            Console.WriteLine(outputService.OutputAsJSON(circle));
            Console.WriteLine(outputService.OutputAsJSON(square));

            Console.ReadKey();
        }
    }
}
