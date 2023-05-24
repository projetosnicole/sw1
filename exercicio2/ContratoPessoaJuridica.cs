namespace exercicio2;
class ContratoPessoaJuridica:Contrato
{
    public string? Cnpj;
    public string? IE;
    public string? NomeEmpresa;

     public override string MostraDados(){
        return base.MostraDados() + " - CNPJ:" + this.Cnpj + " - IE:" + this.IE + " - NomeEmpresa:" + this.NomeEmpresa;
    }
}