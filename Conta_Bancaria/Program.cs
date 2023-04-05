namespace Conta_Bancaria;
class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Exercícios conta bancária - Etec MCM");
       Conta conta = new Conta();

       conta.nomeCliente = "Nicole Caroline";
       conta.limite = 1000;
       
       conta.depositar(200);

       conta.sacar(400);

       double saldo = conta.ConsultaSaldo();

       //para vizualizar:
       Console.WriteLine( "  seu saldo é de: " + saldo);
      
    }
}
