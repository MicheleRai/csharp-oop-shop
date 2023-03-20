

Console.WriteLine("Inserisci nome prodotto");
string? nome = Console.ReadLine() ?? "";
Console.WriteLine("Inserisci descrizione prodotto");
string descrizione = Console.ReadLine() ?? "";
Console.WriteLine("Inserisci prezzo prodotto");
double prezzo = double.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Inserisci l'iva relativa al prodotto");
int iva = int.Parse(Console.ReadLine() ?? "");




Prodotto prodotto = new(nome, descrizione, prezzo, iva);

    Console.WriteLine(prodotto.NomeProdotto);
    Console.Write("Codice prodotto: ");
    Console.WriteLine(prodotto.CodiceConPad());
    Console.Write("Descrizione: ");
    Console.WriteLine(prodotto.DescrizioneProdotto);
    Console.Write("Prezzo con iva: ");
    Console.WriteLine(prodotto.PrezzoConIva());
    Console.Write("IVA: ");
    Console.WriteLine(iva);
