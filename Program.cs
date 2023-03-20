

Console.WriteLine("Inserisci nome prodotto");
string nome = Console.ReadLine() ?? "";
Console.WriteLine("Inserisci descrizione prodotto");
string descrizione = Console.ReadLine() ?? "";
Console.WriteLine("Inserisci prezzo prodotto");
double prezzo = double.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Inserisci l'iva relativa al prodotto");
int iva = int.Parse(Console.ReadLine() ?? "");




Prodotto prodotto = new(nome, descrizione, prezzo, iva);

    Console.WriteLine("Il prodotto da te aggiunto èç ");

    Console.WriteLine(prodotto.NomeProdotto);
    Console.WriteLine($"Codice prodotto: { prodotto.CodiceConPad()}");
    Console.WriteLine($"Descrizione: {prodotto.DescrizioneProdotto}");
    Console.WriteLine($"Prezzo con iva: {prodotto.PrezzoConIva()}$");
    Console.WriteLine($"IVA: {iva}%");
