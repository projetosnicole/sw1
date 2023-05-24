namespace Exercício3;
class Program
{
    static void Main(string[] args)
    {
         ContratoPessoasFisica n1 = new ContratoPessoasFisica();
         ContratoPessoasJuridica n2 = new ContratoPessoasJuridica();

        n1.Email = "niihcarol25@gmail.com";
        n1.Nome = "Nicole";
        n1.Telefone = "(11) 93343-9880";
        n1.cpf = "539.256.268-08";
        n1.Idade = 16;
        n1.Prazo = 10;


        n2.Email = "Nicole.pontes2@etec.sp.gov.br";
        n2.Nome = "Nicole";
        n2.Telefone = "(11) 93343-9880";
        n2.cnpj = ",3213546";
        n2.ie = "35131202354";
        n2.NomeEmpresa = "Ni tec";
        n2.Prazo = 10;

        Console.WriteLine("Os dados Pessoa Física são: " + n1.MostraDados());
        Console.WriteLine("Os dados Pessoa Jurídica são: " + n2.MostraDados());
        Console.WriteLine("************************************");
        Console.WriteLine("O valor da prestação da Pessoa Física é de: " + n1.calcularPrestacao());
        Console.WriteLine("O valor da prestação da Pessoa Jurídica é de: " + n2.calcularPrestacao());
    }
}

