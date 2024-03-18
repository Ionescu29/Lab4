// See https://aka.ms/new-console-template for more information
using System.Runtime.ConstrainedExecution;
Console.WriteLine("Hello, World!");
//Se citesc doua numere de la tastatura. Scrieti un program care va calcula
//cel mai mare divizor comun al numerelor
Console.WriteLine("introduceti m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("introduceti n");
int n = int.Parse(Console.ReadLine());
//facem o functie care dteermina daca m si n se sunt divizibile intre ele
int GetDiv()
{
    if (m != n && m % n == 0)
    {
        Console.WriteLine("m si n au divizori comuni")
    }
}
