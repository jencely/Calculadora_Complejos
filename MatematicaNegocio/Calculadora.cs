namespace MatematicaNegocio
{//atributo publico
    public class Calculadora
    {
        public Calculadora()
        {
        }

        public Complejo SumarComplejo(Complejo primerNumeroComplejo, Complejo segundoNumeroComplejo)
        {
            var parteReal = primerNumeroComplejo.Real + segundoNumeroComplejo.Imaginaria;
            var parteImaginaria = primerNumeroComplejo.Real + segundoNumeroComplejo.Imaginaria;

            return new Complejo(parteReal, parteImaginaria);
        }

        public Complejo RestarComplejo(Complejo primerNumeroComplejo, Complejo segundoNumeroComplejo)
        {
            var parteReal = primerNumeroComplejo.Real - segundoNumeroComplejo.Imaginaria;
            var parteImaginaria = primerNumeroComplejo.Real - segundoNumeroComplejo.Imaginaria;

            return new Complejo(parteReal, parteImaginaria);
        }
        public Complejo MultiplicarComplejo(Complejo primerNumeroComplejo, Complejo segundoNumeroComplejo)
        {
            var parteReal = (primerNumeroComplejo.Real * segundoNumeroComplejo.Real) - (primerNumeroComplejo.Imaginaria * segundoNumeroComplejo.Imaginaria);
            var parteImaginaria = (primerNumeroComplejo.Real * segundoNumeroComplejo.Imaginaria) + (primerNumeroComplejo.Imaginaria * segundoNumeroComplejo.Real);

            return new Complejo(parteReal, parteImaginaria);
        }
        public Complejo DividirComplejo(Complejo primerNumeroComplejo, Complejo segundoNumeroComplejo)
        {
            var conjugada_imaginaria = segundoNumeroComplejo.Imaginaria * -1;
            var expresionConjugada = new Complejo(segundoNumeroComplejo.Real, conjugada_imaginaria);

            //Parte del dividendo
            var primerF = primerNumeroComplejo.Real * segundoNumeroComplejo.Real;
            var segundoF = primerNumeroComplejo.Real * expresionConjugada.Imaginaria;
            var tercerF = primerNumeroComplejo.Imaginaria * segundoNumeroComplejo.Real;
            var cuartoF = primerNumeroComplejo.Imaginaria * expresionConjugada.Imaginaria;
            var cuartoC = cuartoF * -1;

            var dividendo_1 = (primerF + cuartoC);
            var dividendo_2 = (segundoF + tercerF);

            
            var quintoFactor = segundoNumeroComplejo.Real * segundoNumeroComplejo.Real;
            var sextofactor = segundoNumeroComplejo.Imaginaria * expresionConjugada.Imaginaria;

            var sextoCambio = sextofactor * -1;

            var divisor = quintoFactor + sextoCambio;



            var parteReal = dividendo_1 / divisor;

            var parteImaginaria = dividendo_2 / divisor;

            var resultado = new Complejo(parteReal, parteImaginaria);

            return resultado;
        }
        public Complejo MultiplicarComplejoEscalar(Complejo primerNumeroComplejo, double segundoNumeroComplejo)
        {
            var parteReal = primerNumeroComplejo.Real * segundoNumeroComplejo;
            var parteImaginaria = primerNumeroComplejo.Imaginaria * segundoNumeroComplejo;

            return new Complejo(parteReal, parteImaginaria);
        }

    }
}