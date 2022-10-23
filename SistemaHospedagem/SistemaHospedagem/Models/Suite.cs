namespace SistemaHospedagem.Models;

public class Suite
{
    private string Tipo { get;  set; }
    public int Capacidade { get;  set; }
    public decimal ValorDiaria { get; private set; }

    public Suite(string tipo, int capacidade, decimal valorDiaria)
    {
        Tipo = tipo;
        Capacidade = capacidade;
        ValorDiaria = valorDiaria;
    }
}