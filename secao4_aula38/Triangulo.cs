using System;

namespace secao4_aula38
{
    class Triangulo
    {
        public double LadoA;
        public double LadoB;
        public double LadoC;

        public double CalcularAreaTriangulo()
        {
            double p = (LadoA + LadoB + LadoC) / 2.0;

            return Math.Sqrt(p * (p - LadoA) * (p - LadoB) * (p - LadoC));
        }
    }
}
