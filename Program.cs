using System;
using System.Collections.Generic;
namespace hospedagem;
class Program
{
    static void Main()
    {
        // Criando hóspedes
            Pessoa hospede1 = new Pessoa("Gabriel", "123456789");
            Pessoa hospede2 = new Pessoa("Ana", "987654321");

            // Criando uma suíte
            Suite suite = new Suite("Luxo", 2, 150.00);

            // Criando uma reserva
            Reserva reserva = new Reserva(12); // Reserva para 12 dias
            reserva.SuiteReservada = suite;

            // Adicionando os hóspedes à reserva
            reserva.AdicionarHospede(hospede1);
            reserva.AdicionarHospede(hospede2);

            // Exibindo informações da reserva
            Console.WriteLine($"Quantidade de Hóspedes: {reserva.ObterQuantidadeHospedes()}");
            Console.WriteLine($"Valor Total da Reserva: R${reserva.CalcularValorTotal():F2}");
    }
}


