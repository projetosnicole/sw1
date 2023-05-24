namespace exercicio2;
class ContratoPessoaFisica:Contrato
{
    public string? Cpf;
    public int Idade;

    public override string MostraDados(){
        return base.MostraDados() + " - CPF:" + this.Cpf + " - Idade:" + this.Idade;
    }
}