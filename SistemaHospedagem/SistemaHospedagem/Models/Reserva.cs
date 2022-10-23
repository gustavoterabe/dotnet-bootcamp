using System.Runtime.InteropServices;

namespace SistemaHospedagem.Models;

public class Reserva
{
    private List<Pessoa> Hospedes { get; set; }
    private Suite Suite { get; set; }
    private int DiasReservados { get; set; }

    public Reserva() { }
    
    public Reserva(int diasReservados)
    {
        DiasReservados = diasReservados;
    }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        if (!hospedes.Any())
            throw new ArgumentNullException("Lista de hospedes invalida ou vazia");

        if (Suite?.Capacidade < hospedes.Count())
            throw new ArgumentException("Numero de hospedes maior que a capacidade da suite");

        Hospedes = hospedes;
    }

    public void CadastrarSuite(Suite suite)
    {
        if (Hospedes?.Count() > suite.Capacidade)
            throw new InvalidComObjectException(
                "Nao eh possivel cadastrar essa suite pois o numero de hospedes para essa " +
                "reserva eh maior que a capacidade da suite"
            );

        Suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
        return Hospedes.Count();
    }

    public decimal CalcularValorDiaria()
    {
        decimal desconto = (DiasReservados >= 10
            ? 0.10M
            : 0.00M);

        return (Suite.ValorDiaria * DiasReservados * (1 - desconto));
    }
}