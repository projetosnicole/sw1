namespace Exercicio1;
class Program
{
    static void Main(string[] args)
    {
       Cao Golden = new Cao(); 
       Gato Popa = new Gato(); 
       Homem Jeremy = new Homem();

       Console.WriteLine("Chamei o cão e ele " + Golden.fala());
       Console.WriteLine("Chamei o  e ele " + Popa.fala());
       Console.WriteLine("Chamei o homem e ele " + Jeremy.fala());
    }
}
