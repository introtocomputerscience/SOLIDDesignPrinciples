using SingleResponsibilityPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.Services
{
    public class ShapeOutputService
    {
        public string OutputAsHTML(IShape shape)
        {
            return $"<p>Area : {shape.CalculateArea()}</p><br /><p>Perimeter : {shape.CalculatePerimeter()}</p>";
        }

        public string OutputAsJSON(IShape shape)
        {
            return $"{{ \"Area\" : {shape.CalculateArea()}, \"Perimeter\" : {shape.CalculatePerimeter()} }}";
        }
    }
}
