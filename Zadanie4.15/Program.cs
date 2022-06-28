Console.WriteLine("Podaj tekst do zaszyfrowania: ");
string tekst = Console.ReadLine();
string szyfr = "GADERYPOLUKI";
string tekstSzyfr = String.Empty;
tekst = tekst.ToUpper();
for (int a = 0; a < tekst.Length; a++)
{
    for (int b = 0; b < szyfr.Length; b++)
    {
        if (tekst[a] == szyfr[b])
        {
            if (b % 2 == 0)
            {
                tekstSzyfr += szyfr[b + 1];
            }
            else
            {
                tekstSzyfr += szyfr[b - 1];
            }
        }
    }
    if (tekstSzyfr.Length - a == 0)
    {
        tekstSzyfr += tekst[a];
    }
}
Console.WriteLine(tekstSzyfr);
Console.ReadKey();
