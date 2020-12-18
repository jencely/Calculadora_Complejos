using MatematicaNegocio;
using System;

namespace Matematicas.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var opciones = Console.ReadLine();
            var miCalculadora = new Calculadora();
            string resp = "";

            do
            {
                Console.WriteLine("Que operación desea realizar");
                Console.WriteLine("Para sumar numeros complejos [+]");
                Console.WriteLine("Para restar numeros complejos [-]");
                Console.WriteLine("Para multiplicar numeros complejos [*]");
                Console.WriteLine("Para dividir numeros complejos [/]");
                Console.WriteLine("Para el producto escalar [5]");
                Console.WriteLine("Para salir del programa [s]");


                //suma
                if (opciones == "+")
                {
                    Console.WriteLine("Ingresar el primer número real");
                    var  primerNumero_R = double.Parse (Console.ReadLine());

                    Console.WriteLine("Ingresar el primer número imaginario");
                    var primerNumero_I = double.Parse(Console.ReadLine());

                    Console.WriteLine("Ingresar el segundo número real");
                    var segundoNumero_R = double.Parse(Console.ReadLine());

                    Console.WriteLine("Ingresar el segundo número imaginario");
                    var segundoNumero_I = double.Parse(Console.ReadLine());


                    var complejo_1 = new Complejo(primerNumero_R, primerNumero_I);
                    var complejo_2 = new Complejo(segundoNumero_R, segundoNumero_I);
                    
                    var resultadoSuma = miCalculadora.SumarComplejo(complejo_1,complejo_2);

                    Console.WriteLine("La suma de los complejos es:   " + resultadoSuma  +  "i");

                    //Console.WriteLine("La respuesa de la suma de los complejos es: " + respuestaSumaComplejos.getX() + " , " + respuestaSumaComplejos.getY() + "i");
                }
                //resta
                if (opciones == "-")
                {
                    Console.WriteLine("Ingresar el primer número real");
                    var primerNumero_R = double.Parse(Console.ReadLine());

                    Console.WriteLine("Ingresar el primer número imaginario");
                    var primerNumero_I = double.Parse(Console.ReadLine());

                    Console.WriteLine("Ingresar el segundo número real");
                    var segundoNumero_R = double.Parse(Console.ReadLine());

                    Console.WriteLine("Ingresar el segundo número imaginario");
                    var segundoNumero_I = double.Parse(Console.ReadLine());


                    var complejo_1 = new Complejo(primerNumero_R, primerNumero_I);
                    var complejo_2 = new Complejo(segundoNumero_R, segundoNumero_I);

                    var resultadoResta = miCalculadora.SumarComplejo(complejo_1, complejo_2);

                    Console.WriteLine("La resta de los complejos es:   " + resultadoResta  + "i");

                   

                }
                //multiplicacion
                if (opciones == "*")
                {
                    Console.WriteLine("Ingresar el primer número real");
                    var primerNumero_R = double.Parse(Console.ReadLine());

                    Console.WriteLine("Ingresar el primer número imaginario");
                    var primerNumero_I = double.Parse(Console.ReadLine());

                    Console.WriteLine("Ingresar el segundo número real");
                    var segundoNumero_R = double.Parse(Console.ReadLine());

                    Console.WriteLine("Ingresar el segundo número imaginario");
                    var segundoNumero_I = double.Parse(Console.ReadLine());


                    var complejo_1 = new Complejo(primerNumero_R, primerNumero_I);
                    var complejo_2 = new Complejo(segundoNumero_R, segundoNumero_I);

                    var resultadoMultiplicacion = miCalculadora.SumarComplejo(complejo_1, complejo_2);

                    Console.WriteLine("La multiplicacion de los complejos es:   " + resultadoMultiplicacion  + "i");
                }
                //Division
                if (opciones == "/")
                {
                    Console.WriteLine("Ingresar el primer número real");
                    var primerNumero_R = double.Parse(Console.ReadLine());

                    Console.WriteLine("Ingresar el primer número imaginario");
                    var primerNumero_I = double.Parse(Console.ReadLine());

                    Console.WriteLine("Ingresar el segundo número real");
                    var segundoNumero_R = double.Parse(Console.ReadLine());

                    Console.WriteLine("Ingresar el segundo número imaginario");
                    var segundoNumero_I = double.Parse(Console.ReadLine());


                    var complejo_1 = new Complejo(primerNumero_R, primerNumero_I);
                    var complejo_2 = new Complejo(segundoNumero_R, segundoNumero_I);

                    var resultadoDivision = miCalculadora.SumarComplejo(complejo_1, complejo_2);

                    Console.WriteLine("La división de los complejos es:   " + resultadoDivision + "i");
                }
                Console.Write("¿Desea Continuar? S/N: ");
                resp = Console.ReadLine();
                if (opciones == "5")
                {
                    Console.WriteLine("Ingrese el primer numero real");
                    var Numero_R = double.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese numero imaginario");
                    var numero_I = double.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Ingrese el escalar");
                    var escalar = int.Parse(Console.ReadLine());


                    var complejo_E = new Complejo(Numero_R, numero_I);
                    var resultadoMultiplicacionEscalar = miCalculadora.MultiplicarComplejoEscalar(complejo_E, escalar);

                    Console.WriteLine("La multiplicacion por el escalar es de los complejos es: " + resultadoMultiplicacionEscalar + "i");
                }
                Console.Write("¿Desea Continuar? S/N: ");
                resp = Console.ReadLine();

            } while (resp == "s" || resp == "s");
            

           

        }
    }
}
