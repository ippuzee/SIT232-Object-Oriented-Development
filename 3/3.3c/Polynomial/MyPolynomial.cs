using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynomial
{
    internal class MyPolynomial
    {
        private double[] _coeffs;
        private int _degree; //n

        public MyPolynomial(double[] coeffs)
        {
            _coeffs = coeffs;
            this._degree = coeffs.Length - 1;
        }

        public int GetDegree()
        {
            return _degree;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = _degree; i >= 0; i--)
            {
                if (_coeffs[i] != 0)
                {
                    if (result.Length > 0)
                    {
                        result.Append(" + ");
                    }

                    if (i == 0 || _coeffs[i] != 1)
                    {
                        result.Append(_coeffs[i]);
                    }

                    if (i > 0)
                    {
                        result.Append("x");
                        if (i > 1)
                        {
                            result.Append("^").Append(i);
                        }
                    }
                }
            }
            return result.ToString();
        }

        public double Evaluate(double x)
        {
            double result = 0;
            for (int i = _degree; i >= 0; i--)
            {
                result += _coeffs[i] * Math.Pow(x, i);
            }
            return result;
        }

        public MyPolynomial Add(MyPolynomial another)
        {
            int newDegree = Math.Max(_degree, another._degree);
            double[] newCoeffs = new double[newDegree + 1];

            for (int i = 0; i <= _degree; i++)
            {
                newCoeffs[i] += _coeffs[i];
            }

            for (int i = 0; i <= another._degree; i++)
            {
                newCoeffs[i] += another._coeffs[i];
            }
            return new MyPolynomial(newCoeffs);
        }

        public MyPolynomial Multiply(MyPolynomial another)
        {
            int newDegree = this.GetDegree() + another.GetDegree();
            double[] newCoeffs = new double[newDegree + 1];

            for (int i = 0; i <= this.GetDegree(); i++)
            {
                for (int j = 0; j <= another.GetDegree(); j++)
                {
                    newCoeffs[i + j] += this._coeffs[i] * another._coeffs[j];
                }
            }

            return new MyPolynomial(newCoeffs);
        }
    }
}
