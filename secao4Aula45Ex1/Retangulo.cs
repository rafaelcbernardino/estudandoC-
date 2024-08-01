using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace secao4Aula45Ex1
{
    public class Retangulo
    {
        public double largura;
        public double altura;

        public double Area()
        {
            return largura * altura;
        }

        public double Perimetro()
        {
            return largura * altura;
        }

        public double Diagonal()
        {
            return largura * altura;
        }

        public override string ToString()
        {
            return "Area = "
                + Area().ToString("F2",CultureInfo.InvariantCulture)
                + "\nPerímetro = "
                + Perimetro().ToString("F2",CultureInfo.InvariantCulture)
                + "\nDiagonal = "
                + Diagonal().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
