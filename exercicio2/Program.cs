namespace exercicio2;
class Program
{
    static void Main(string[] args)
    {
       ContratoPessoaFisica n1 = new ContratoPessoaFisica();
       ContratoPessoaJuridica n2 = new ContratoPessoaJuridica(); 
    
       n1.Nome = "Nicole";
       n1.Email = "niihcarol25@gmail.com";
       n1.Telefone = "11 93343-9880";
       n1.Cpf = "539.256.268-08";
       n1.Idade = 16;

       n2.Nome = "Nicole";
       n2.Email = "nicole.pontes2@etec.sp.gov.br";
       n2.Telefone = "11 93343-9880";
       n2.Cnpj = "56982430";
       n2.IE = "2962578320";
       n2.NomeEmpresa = "Nini acessórios";
    

        Console.WriteLine("Os dados Pessoa Física são: " + n1.MostraDados());
        Console.WriteLine("Os dados Pessoa Jurídica são: " + n2.MostraDados());
    }
}
