using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynomial
{
    internal class TestMyPolynomial
    {
        static void Main(string[] args)
        {
            double[] coeffs1 = { 1, 0, -2, 3 ,4};
            double[] coeffs2 = { 2, -1, 3, 1};

            MyPolynomial poly1 = new MyPolynomial(coeffs1);
            MyPolynomial poly2 = new MyPolynomial(coeffs2);

            Console.WriteLine("Poly1: "+ poly1.ToString());
            Console.WriteLine("Poly2: "+ poly2.ToString());
            Console.WriteLine("Degree of Poly1: "+ poly1.GetDegree());
            Console.WriteLine("Degree of poly2: "+ poly2.GetDegree());

            Console.WriteLine("Evaluation of Poly1 at x=2: "+ poly1.Evaluate(2));
            Console.WriteLine("Evaluation of Poly2 at x=3: " + poly2.Evaluate(3));

            MyPolynomial sum = poly1.Add(poly2);
            Console.WriteLine("Sum: "+ sum.ToString());

            MyPolynomial product = poly1.Multiply(poly2);
            Console.WriteLine("Product: "+product.ToString());
            Console.ReadLine();
        }
    }
}
