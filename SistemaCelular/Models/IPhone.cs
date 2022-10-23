namespace SistemaCelular.Models;

public class IPhone: Smartphone
{
    public IPhone (string numero, string modelo, string imei, int memoria) 
        : base(numero, modelo, imei, memoria) 
    {}

    public override void InstalarAplicativo(string nomeApp)
    {
        Console.WriteLine($"Instalando applicativo {nomeApp} Apple Store");
    }
}