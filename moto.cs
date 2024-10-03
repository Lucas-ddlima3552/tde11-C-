public class Moto : Veiculo{
    private bool TemBagageiro;
    public void DarGrau()
    {
        Console.WriteLine("RANN DANNN DANN");
    }
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Marca: {Marca}, modelo da moto: {Modelo}, ano da moto: {Ano}, bagageiro:{TemBagageiro}");
    }
    public Moto(string Marca, string Modelo, int Ano, bool TemBagageiro) : base(Marca, Modelo, Ano)
    {
        TemBagageiro = TemBagageiro;
    }
}