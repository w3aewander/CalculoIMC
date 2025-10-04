using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalculoIMC
{
    public class IMC
    {
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double ResultadoIMC{ get; set; }

        /// <summary>
        /// Método construtor que recebe o peso e a altura
        /// </summary>
        /// <param name="peso"></param>
        /// <param name="altura"></param>
        public IMC(double peso, double altura)
        {
            Peso = peso;
            Altura = altura;
            ResultadoIMC = CalcularIMC();
        }

        /// <summary>
        /// Método sobrecarregado que recebe o peso, altura e o resultado do IMC
        /// </summary>
        /// <param name="peso"></param>
        /// <param name="altura"></param>
        /// <param name="resultadoIMC"></param>
        public IMC(double peso, double altura, double resultadoIMC) : this(peso, altura)
        {
            ResultadoIMC = resultadoIMC;
        }

        /// <summary>
        /// Método construtor padrão
        /// </summary>
        public IMC()
        {
            Peso = 0;
            Altura = 0;
            ResultadoIMC = 0;
        }

        public double CalcularIMC()
        {
            ResultadoIMC = Peso / (Math.Pow(Altura, 2) );
            return ResultadoIMC;
        }

        public string Mensagem()
        {
            if (ResultadoIMC < 18.5)
            {
                return "Abaixo do peso";
            }
            else if (ResultadoIMC >= 18.5 && ResultadoIMC < 24.9)
            {
                return "Peso normal";
            }
            else if (ResultadoIMC >= 25 && ResultadoIMC < 29.9)
            {
                return "Sobrepeso";
            }
            else if (ResultadoIMC >= 30 && ResultadoIMC < 34.9)
            {
                return "Obesidade grau I";
            }
            else if (ResultadoIMC >= 35 && ResultadoIMC < 39.9)
            {
                return "Obesidade grau II";
            }
            else
            {
                return "Obesidade grau III";
            }
        }
    }
}
