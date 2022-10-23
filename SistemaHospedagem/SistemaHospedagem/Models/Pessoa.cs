namespace SistemaHospedagem.Models;

public class Pessoa
{
    private string Nome { get; set; }
    public string Sobrenome { get; set; }

    public Pessoa(string nome, string sobrenome = null)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }
    
    
}