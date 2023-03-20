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
        this.Codice = new Random().Next(1, 99999999);
        this.NomeProdotto = nome;
        this.DescrizioneProdotto = descrizione;
        this.PrezzoProdotto = prezzo;
        this.Iva = iva;
    }
    public string CodiceConPad()
    {

        var stringCode = Convert.ToString(Codice);
        var zero = "0";
        var iterations = 8 - stringCode.Length;

        for (int i = 0; i < iterations; i++)
        {
            stringCode = zero + stringCode;
        }

        return stringCode;

    }
    public double? PrezzoConIva()
    {
        return PrezzoProdotto += (PrezzoProdotto * Iva) / 100;
    }

}