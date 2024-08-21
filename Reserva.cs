namespace hospedagem;

public class Reserva
{
    public List<Pessoa> Hospedes { get; set; }
    public Suite SuiteReservada { get; set; }
    public int DiasReservados { get; set; }

    public Reserva(int diasReservados)
    {
        Hospedes = new List<Pessoa>();
        DiasReservados = diasReservados;
    }
    public void AdicionarHospede(Pessoa hospede)
    {
        if (Hospedes.Count < SuiteReservada.Capacidade)
        {
            Hospedes.Add(hospede);
        }
        else
        {
            Console.WriteLine("Não é possível adicionar mais hóspedes, capacidade máxima atingida.");
        }
    }
    public int ObterQuantidadeHospedes()
    {
        return Hospedes.Count;
    }
    public double CalcularValorTotal()
    {
        double valorTotal = DiasReservados * SuiteReservada.ValorDiaria;
        if (DiasReservados > 10)
        {
            valorTotal *= 0.90; // Aplicando desconto de 10%
        }
        return valorTotal;
    }
}