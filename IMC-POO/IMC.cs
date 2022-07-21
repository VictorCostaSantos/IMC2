using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImcUsandoPOO
{
    internal class IMC
    {
        public string nome;
        public double Kg;
        public double Alt;
        public double MassaCorporal()
        {
            return Kg / (Alt * Alt);
        }
        public string Situacao(double imc)
        {
            string retorno;
            if (imc <= 18.5f)
            {
                retorno = "Abaixo do peso";
            }
            else if (imc >= 18.5 & imc <= 25)
            {
                retorno = "peso normal";

            }
            else if (imc > 30 & imc <=35)
            {
                retorno = "Acima do peso";
            }
            else if (imc > 35 & imc <= 40)
            {
                retorno = "Obesidade";
            }
            else if (imc > 30 & imc <= 35)
            {
                retorno = "Obesidade gravissima";
            }
            else { retorno = "Obesidade mórmida"; }
            return retorno;
        }

        public void mensagem()
        {
            double obtercalculo = MassaCorporal();
            string obterSituacao = Situacao(obtercalculo);

            Console.WriteLine("Seu IMC é de " + obtercalculo);
            Console.WriteLine("Sua situcao é "+ obterSituacao);


        }
    }
}
