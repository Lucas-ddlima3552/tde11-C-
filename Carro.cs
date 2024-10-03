public class Carro : Veiculo{
    private int numeroDePortas;
    public void abrirPortaMalas()
    {
        Console.WriteLine("O porta malas está aberto");
    }
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Marca do Carro: {Marca}, Modelo: {Modelo}, ano do carro: {Ano}");
    }
    public Carro(string Marca, string Modelo, int Ano, int numeroDePortas) : base(Marca, Modelo,  Ano)
    {   
        this.numeroDePortas = numeroDePortas;
    }
}