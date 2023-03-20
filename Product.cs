using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Prodotto
{
    public int Codice { get; set; }
    public string? NomeProdotto { get; set; }
    public string? DescrizioneProdotto { get; set; }
    public double? PrezzoProdotto { get; set; }
    public int Iva { get; set; }

    public Prodotto(string nome, string descrizione, double prezzo, int iva)
    {
        Codice = new Random().Next(1, 99999999);
        NomeProdotto = nome;
        DescrizioneProdotto = descrizione;
        PrezzoProdotto = prezzo;
        Iva = iva;
    }
    public void Print()
    {
        double prezzoConIva(double PrezzoProdotto, int Iva)
        {
            double IvaPrezzo = PrezzoProdotto * Iva;

            double prezzoConIva = PrezzoProdotto + IvaPrezzo;


            return prezzoConIva;
        }

        Console.WriteLine(NomeProdotto);
        Console.Write("Descrizione: ");
        Console.WriteLine(DescrizioneProdotto);
        Console.Write("Prezzo compreso di iva: ");
        Console.WriteLine($"{prezzoConIva}");
        Console.Write("IVA: ");
        Console.WriteLine(Iva);

    }
   

}