using CA230323;
using System.Text;

List<Versenyzo> versenyzok = new();
using StreamReader sr = new("..\\..\\..\\src\\Eredmenyek.txt", Encoding.Latin1);
while(!sr.EndOfStream) versenyzok.Add(new Versenyzo(sr.ReadLine()!));

Console.WriteLine($"a versenyt {versenyzok.Count} versenyző fejezte be");

int noej = 0;
foreach (var v in versenyzok)
    if (v.KorKategoria == "elit junior") noej++;
Console.WriteLine($"a versenyzők száma \"elit junior\" kategóriában: {noej} fő");

int esum = 0;
foreach (var v in versenyzok)
    esum += (2014 - v.SzulEv);
Console.WriteLine($"a versenyzők átlagéletkora: {esum/(float)versenyzok.Count:0.0} év");

Console.Write("írd be egy kategória nevét: ");
string kk = Console.ReadLine()!;
string rszok = string.Empty;
foreach (var v in versenyzok)
    if (v.KorKategoria == kk) rszok += $"{v.RajtSzam} ";
if (rszok == string.Empty)
    Console.WriteLine("\tnincs ilyen kategória!");
else Console.WriteLine($"\trajtszám(ok): {rszok}");

List<Versenyzo> nok = new();
foreach (var v in versenyzok) if (!v.Nem) nok.Add(v);

int mini = 0;
for (int i = 1; i < nok.Count; i++)
    if (nok[i].Osszido < nok[mini].Osszido) mini = i;
Console.WriteLine($"a nők között a nyőztes: {nok[mini].Nev}");