using L4UkolPocetZnaku;

List <ZnakPocet> vyskyty = new List <ZnakPocet> ();

string text = Console.ReadLine ();

foreach (char a in text)
{
    foreach (ZnakPocet b in vyskyty) {
        if (char.ToLower(b.znak) == char.ToLower(a))
        {
            b.vyskyt++;
        }
        else
            vyskyty.Add(new ZnakPocet { znak = a, vyskyt = 1 });
            }
}

foreach (ZnakPocet c in vyskyty)
{
    Console.WriteLine($"Znak: {c.znak}, Výskyt: {c.vyskyt}");
}