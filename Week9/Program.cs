string kaustaAsukoht = @"C:\Users\rists\Desktop\TKTK KMT2023\1-K Programmeerimise algkursus - kevad 2024 - J. Voronetskaja\Week9";
string failiNimi = "ostunimekiri.txt";
string failiAsukoht = Path.Combine(kaustaAsukoht, failiNimi);
List<string> ostunimekiri = new List<string>();

if (File.Exists(failiAsukoht))
{
    ostunimekiri = kasutajaInput();
    File.WriteAllLines(failiAsukoht, ostunimekiri);
}
else
{
    File.Create(failiAsukoht).Close();
    Console.WriteLine($"Fail {failiNimi} on loodud.");
    ostunimekiri = kasutajaInput();
    File.WriteAllLines(failiAsukoht, ostunimekiri);
}


//List<string> ostunimekiri = kasutajaInput();
//näitaNimekirja(ostunimekiri);

static List<string> kasutajaInput()
{
    List<string> kasutajaList = new List<string>();

    while (true)
    {
        Console.WriteLine("Lisa ese (lisa)/ Sulge (sulge):");
        string kasutajaValik = Console.ReadLine();

        if (kasutajaValik == "lisa")
        {
            Console.WriteLine("Sisesta ese:");
            string kasutajaEse = Console.ReadLine();
            kasutajaList.Add(kasutajaEse);
        }
        else
        {
            Console.WriteLine("tsaukipläuki!");
            break;
        }
    }
    return kasutajaList;
}

static void näitaNimekirja(List<string> l)
{
    Console.Clear();

    int listiPikkus = l.Count;
    Console.WriteLine($"Sa oled lisanud {listiPikkus} eset oma nimekirja.");

    int i = 1;
    foreach (string ese in l)
    {
        Console.WriteLine($"{i}. {ese}");
        i++;
    }
}