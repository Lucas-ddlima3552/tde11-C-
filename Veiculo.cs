public class Veiculo{
    protected string Marca;
    protected string Modelo;
    protected int Ano;
    public void Ligar()
    {
        Console.WriteLine($"O veículo está ligando");
    }
    public void Desligar()
    {
        Console.WriteLine("O veiculo está desligado");
    }
    public Veiculo(string Marca, String Modelo, int Ano)
    {
        this.Marca = Marca;
        this.Modelo = Modelo;
        this.Ano = Ano;
    }
}