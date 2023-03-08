namespace exercicio;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
       // Console.ReadKey();

        Exemplo nini = new Exemplo();

        nini.mostramsg();

        nini.pegaNome("NICOLE");

        Console.WriteLine(nini.mensagem());
        
        Console.WriteLine("O resultado é: " + nini.somar(10,20));

    }
}
