public class Suite
{
    public string Tipo { get; set; }
    public int Capacidade { get; set; }
    public double ValorDiaria { get; set; }

    public Suite(string tipo, int capacidade, double valorDiaria)
    {
        Tipo = tipo;
        Capacidade = capacidade;
        ValorDiaria = valorDiaria;
    }
}