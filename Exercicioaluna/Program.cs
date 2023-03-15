namespace Exercicioaluna;
class Program
{
    static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno();
        aluno1.nome = "FULANO DA SILVA,";
        aluno1.nota1 = 8;
        aluno1.nota2 = 5;

        aluno1.mensagem();
    }
}
