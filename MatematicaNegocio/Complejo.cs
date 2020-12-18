using System;
using System.Diagnostics.CodeAnalysis;

namespace MatematicaNegocio
{
    public class Complejo : IEquatable<Complejo>
    {
        public double x;
        public double y;
        public Complejo(double real, double imaginaria)
        {
            Real = real;
            Imaginaria = imaginaria;
        }

        public double Real { get; set; }
        public double Imaginaria { get; set; }
        public object X { get; set; }
        public object Y { get; set; }

        public bool Equals([AllowNull] Complejo other) //objeto de tipo complejo es igual a otro
        {
            return Real == other.Real && Imaginaria == other.Imaginaria;//forma abreviada

            /*if (Real == other.Real && Imaginaria == other.Imaginaria)
            
                return true;          
                return false;*/
        }
    }
}