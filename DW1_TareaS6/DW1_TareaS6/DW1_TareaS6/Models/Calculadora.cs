using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DW1_TareaS6.Models
{
    public class Calculadora
    {

        public int numero1 { get; set; }
        public int numero2 { get; set; }


        public int calcularSuma() {

            int total = numero1 + numero2;

            return total;
        }
        public int calcularResta()
        {


            int total = numero1 - numero2;

            return total;
        }
        public int calcularMultiplicacion()
        {


            int total = numero1 * numero2;

            return total;
        }
        public int calcularDivision()
        {


            int total = numero1 / numero2;

            return total;
        }
        public override string ToString()
        {
            return $"Hola la suma de: {numero1} + : {numero2} es igual a  {calcularSuma()}   ";
        }


    }
}
