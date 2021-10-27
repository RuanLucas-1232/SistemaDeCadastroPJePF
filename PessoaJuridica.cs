using System;

namespace SistemaCadastro
{
    public class PessoaJuridica : Pessoa
    {
        public string cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public override double PagarImposto(float Salario)
        {
            if (Salario == 1903.99)
            {
                double imposto = (double)(Salario * 0.075);
                return imposto;
            }
            else if (Salario == 2826.65)
            {
                double imposto = (double)(Salario * 0.075);
                return imposto;
            }
            else
            {
                Console.WriteLine("SUA RENDA É BAIXA");
                return 0;
            }
            
        }

        public bool validarCnpj(string cnpj)
        {
            if (cnpj.Substring(8, 4) == "0001")
            {
                return true;
            }
            else if (cnpj.Substring(8, 4) == "0002")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}