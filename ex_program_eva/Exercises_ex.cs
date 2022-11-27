using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ex_program_eva
{
    public enum playType
    {
        ROCK,
        PAPER,
        SCISSORS,
        LIZARD,
        SPOCK,
    }

    public enum triangleSIdes
    {
        EQUILATERAL,
        ISOSCELES,
        SCALENE,
        INVALID,
    }

    public class Exercises_ex
    {
        //Escribir una función que calcule el área de un círculo y otra que calcule el volumen de un cilindro usando la primera función.

        public static double GetAreaCirc(double radius)
        {
            return Math.PI * (radius * radius);
        }

        public static double GetCylindreVolume(double radius, double height)
        {
            return GetAreaCirc(radius) * height;
        }

        //(obligatorio) Realiza una función que se le pase dos jugadas de “Piedra, papel, tijera, lagarto o Spock” y devuelva quién gana de los dos.Si gana el primer jugador, devuelve un -1, si gana el segundo devuelve un 1, si quedan empates, un 0. Se tiene que usar un enum.


        public static int GetResultGame(playType play1, playType play2)
        {
            
            if (play1 == playType.PAPER)
            {
                if (play2 == playType.ROCK || play2 == playType.SPOCK)
                    return 1;
                if (play2 == playType.SCISSORS || play2 == playType.LIZARD)
                    return -1;
                else if (play2 == playType.PAPER)
                    return 0;
            }
            if (play1 == playType.ROCK)
            {
                if (play2 == playType.LIZARD || play2 == playType.SCISSORS)
                    return 1;
                if (play2 == playType.SPOCK || play2 == playType.PAPER)
                    return -1;
                else if (play2 == playType.ROCK)
                    return 0;
            }
            if (play1 == playType.LIZARD)
            {
                if (play2 == playType.ROCK || play2 == playType.SCISSORS)
                    return -1;
                if (play2 == playType.SPOCK || play2 == playType.PAPER)
                    return 1;
                else if (play2 == playType.LIZARD)
                    return 0;
            }
            if (play1 == playType.SPOCK)
            {
                if (play2 == playType.LIZARD || play2 == playType.PAPER)
                    return -1;
                if (play2 == playType.ROCK || play2 == playType.SCISSORS)
                    return 1;
                else if (play2 == playType.SPOCK)
                    return 0;
            }
            if (play1 == playType.SCISSORS)
            {
                if (play2 == playType.SPOCK || play2 == playType.ROCK)
                    return -1;
                if (play2 == playType.LIZARD || play2 == playType.PAPER)
                    return 1;
                else if (play2 == playType.SCISSORS)
                    return 0;
            }
            return 1;
        }

        //Desarrolla una función que devuelva el resultado de una ecuación de primer grado.

        public static double EcuationSolution(double a, double b)
        //ax + b = 0
        //ax = 0 - b
        //x = - b / a
        {
            double ecuation1 = (- b / a);
            return ecuation1;
        }


        //(obligatorio) Desarrolla una función que devuelva el resultado de una ecuación de segundo grado.

        /*(-b +- (Square (b * b) - 4(a * c)/(2 * a)
         */

        public static (double, double) EcuationSolution2Grade(double a, double b, double c)
        {
            double ecuation2 = (b * b) - (4 * (a * c) / (2 * a));
            if (ecuation2 == 0)
                return (double.NaN, double.NaN);

            double square = Math.Sqrt(ecuation2);

            double positivEcuation = -b + (ecuation2);

            double negativEcuation = -b - (ecuation2);

            return (positivEcuation, negativEcuation);
        }

        //Los tres lados a, b y c de un triángulo deben satisfacer la desigualdad triangular: cada uno de los lados no puede ser más largo que la suma de los otros dos.Escribe un programa que reciba como entrada los tres lados de un triángulo(son reales), e indique: si acaso el triángulo es inválido; y si no lo es, qué tipo de triángulo es(un enum).

        /* public static double TriangleType(double a, double b, double c)
         {
        ((a * a) = (b * b) + (c * c)) equilatero = (a = b = c), isosceles = (a = b) || (a = c) || (b = c), escaleno = ( a != b) || (b != c) || (a != c)
         }
        */


        public static triangleSIdes TriangleType(double a, double b, double c)
        {
            while (a + b > c && b + c > a && c + a > b)
            {  
             if ((a == b) && (c == a))
                 return triangleSIdes.EQUILATERAL;

             else if ((a != b) && (b != c) && (c != a))
                 return triangleSIdes.SCALENE;
                
                else 
                    return triangleSIdes.ISOSCELES;
            }
               
            return triangleSIdes.INVALID;
        }

        //Escribir una función que calcule el máximo común divisor de dos números.

        public static int GetMCD(int a, int b)
        {
            int n = 0;

            for (int i = 1; i <= a; i++)
            {
                if ((a % i == 0) && (b % i == 0))
                    n = i;
            }
            return n;
        }

        //Escribir una función que calcule el mínimo común múltiplo de dos números.
        
            public static int GetMCM(int a, int b)
            {
                int max;
                int result;

                if (a > b)
                {
                    max = a;
                }
                else
                {
                    max = b;
                }

                for (int i = 2; i <= max; i++)
                {
                    if (i % a == 0 && i % b == 0)
                        return i;
                }
                return 1;
            }



                //Escriba un programa que devuelva un string con los números naturales menores o iguales que un número n determinado y que no sean múltiplos ni de 3 ni de 7.

       /* public static int GetString( int a, int b)
        {

        }*/




                //(obligatorio) Escriba un programa que devuelva un string con todas las combinaciones posibles al momento de lanzar tres dados de 6 caras. (1, 1, 1) (1, 1, 2) (1, 1, 3), …

        //for for for


                //Escribe una función que se le pase un número y devuelve un string con ese mismo número separado por guiones.Por ejemplo 234 → “2-3-4”




                //(obligatorio) Es posible expresar 100 como la suma de tres cubos, cada uno de los cuales puede ser negativo o positivo.Sólo se conocen tres maneras de hacerlo. Una de ellas es la siguiente: . Desarrolla un programa que busque las 1870 otras combinaciones 3 − 1797 3 − 903 3 = 100 para llegar al 100.




                //(obligatorio) Multiplicación rusa. El método de multiplicación rusa consiste en multiplicar sucesivamente por 2 el multiplicando y dividir por 2 el multiplicador hasta que el multiplicador tome el valor 1. Luego, se suman todos los multiplicandos correspondientes a los multiplicadores impares.
                //Dicha suma es el producto de los dos números.La siguiente tabla muestra el cálculo realizado para multiplicar 37 por 12, cuyo resultado final es 12 + 48 + 384 = 444.




                //Crea una función, que reciba como parámetro un texto y lo escriba centrado en pantalla (suponiendo una anchura de 80 columnas; pista: deberás escribir 40 - longitud/2 espacios antes del texto). Además subraya el mensaje utilizando el carácter =.



                //(obligatorio) Crea una función que quite los espacios por delante y por detrás de un string. Se considera un espacio: un espacio, un tabulador, un salto de línea y retorno de carro.La función recibe un string y dos booleanos.



                //(obligatorio) Crea un programa que calcula una aproximación de PI mediante la expresión: pi/4 = 1/1 - 1/3 + 1/5 - 1/7 + 1/9 - 1/11 + 1/13 (...) A esta función se le pasará un entero con el número de iteraciones a realizar.Por ejemplo, si se le pasa un 4, el programa calculará: p = 4 * (1/1 - 1/3 + 1/5 - 1/7)



                //Escribir una función que reciba un número entero positivo y devuelva su factorial. Hay que hacer esta función de 2 formas, una iterativa y otra recursiva.




                //Escribir una función que reciba un número entero positivo y devuelva su sumatorio. Hay que hacer esta función de 2 formas, una iterativa y otra recursiva.




                /*(obligatorio) Según Sheldon, el mejor número es el 73.
                73 es el 21er número primo.Su espejo, 37, es el 12mo número primo. 21 es el producto de multiplicar 7 por 3. En binario, 73 es un palíndromo: 1001001.
                Escriba programas que le permitan responder las siguientes preguntas:
                ¿Existen otros valores p que sean el n-ésimo primo, tales que espejo(p) es el espejo(n)-ésimo primo?
                ¿Existen otros valores p que sean el n-ésimo primo, tales que n es el producto de los dígitos de p?
                ¿Cuáles son los primeros diez números primos cuya representación binaria es un palíndromo?*/
        


        
    }
}
