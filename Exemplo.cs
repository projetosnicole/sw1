namespace exercicio;
class Exemplo
{
   public string nome="";
   public int idade=0;
   public bool vacinado=false; 

   public void mostramsg(){
        Console.WriteLine("Oioiiiii");
   }

   public void pegaNome(string texto){
        Console.WriteLine("Oioiiiiii: " + texto);
   }

   public string mensagem(){
        return "Devolvedo um texto";
   }

   public int somar(int a, int b){
        return a+b;
   }
}
