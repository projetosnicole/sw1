namespace metodo_construtor;
class produto
{
    public produto(){
        this.nome = "XPTO";
        this.preco = 1;
    }
     public produto(string nome){
        this.nome = nome; 
    }
     public produto(string nome,int desconto){
        this.nome = nome; 
        this.preco = 10 - 10*desconto/100;
    }


    public string? nome{get;set;}
    public double preco{get;set;}

    public void MostraDados(){
        Console.WriteLine("nome: " + this.nome);
        Console.WriteLine("preço: " + this.preco);
    }
    public void AlteraNome(string nome){
        this.nome = nome;
    }
    public void AlteraPreco(double preco){
        this.preco = preco;
    }
}