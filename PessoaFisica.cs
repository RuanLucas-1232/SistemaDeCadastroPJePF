using System;

namespace SistemaCadastro
{
    public class PessoaFisica : Pessoa
    {

        public string cpf { get; set; }
        public DateTime dataNascimento { get; set; }
        public bool ValidarDataNascimento(DateTime DataNascimento)
        {
            DateTime DataAtual = DateTime.Today;
            double idade = (DataAtual - DataNascimento).TotalDays / 365;
            if (idade >= 18)
            {
                return true;
            }
            return false;
        }
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
    }
}