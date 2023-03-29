namespace exemplo_acessor;
class Program
{
    static void Main(string[] args)
    {
        Produto p1 = new Produto();
        //p1.Preco = 20
        p1.AlterePreco(15);
        p1.AlteraNome("Parafuso");
        p1.MostraDados();
    }
}
