namespace exemplo;
class Program
{
    static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno();

        Console.WriteLine("Digite seu nome: ");
        string? nome = Console.ReadLine();
        //Console.WriteLine(" Seu nome é: " + nome);

        Console.WriteLine("Digite sua primeira nota: ");
        double nota1 = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("O número digitado foi: " + nota1);

        Console.WriteLine("Digite sua segunda nota: ");
        double nota2 = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("O número digitado foi: " + nota2);

        aluno1.nome = nome="";
        aluno1.nota1 = nota1;
        aluno1.nota2 = nota2;

        aluno1.mensagem();


    }
}
