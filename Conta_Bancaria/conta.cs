namespace Conta_Bancaria;
class Conta
{
    public string? nomeCliente {get;set;}
    public int numeroConta {get;set;}

    private double saldo {get;set;}

    public double limite {get;set;}

    //metodo para realizar um deposito
    public void depositar (double valor){
        this.saldo += valor;
    }

    //metodo para realizar um saque
    public void sacar (double valor){
         if (valor <= this.saldo + this.limite) {
            Console.WriteLine("O valor sacado é de: " + saldo);
            this.saldo -= valor;
        }else {
            Console.WriteLine("Você não possui saldo+limite suficiente para esse saque!");
            Console.WriteLine("Saque não realizado");
        }
    }

    //metodo ConsultaSaldo - retorna saldo disponivel + limite
    public double ConsultaSaldo(){
        return this.saldo + this.limite;
    }
}
