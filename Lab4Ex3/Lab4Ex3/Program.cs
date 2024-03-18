// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Cititi de la tastatura continutul a doua matrici de intregi cu 2 dimensiuni avand lungimile n m,
//respectiv m, n. Lungimile celor doua dimensiuni ale matricilor, m si n, vor fi citite de la tastaura.
//Scrieti o functie care va calcula produsul celor doua matrici, apelati-o si afisati matricea rezultata
Console.WriteLine("introduceti n");
var n = int.Parse(Console.ReadLine());
Console.WriteLine("introduceti m");
var m = int.Parse(Console.ReadLine());
//am facut doua functii care citesc doua matrici
int[,] ReadMatrix()
{
    int[,] result = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m:j++)
        {
             result[i, j] = int * j;
        }
    }
    return result;
}
int[,] ReadMatrix2()
{
    int[,] result2 = new int[n, m];
    for (int k = 0; k < n; k++)
    {
        for (int l = 0; l < m; l++)
        {
            result2[k, l] = int * l;
        }
    }

}
//am facut o functie care calculeaza produsul celor doua matrici
void ProdMatrix(int[,] matrix && int[,] matrix2)
{
    var prod = 0;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for (int k = 0; k < m; k++)
            {
                for (int l = 0; l < m; l++)
                {
                    int prod = int[i, j]matrix * int[k, l];
                    return prod;
                }
            }

        }
    }
    Console.WriteLine(prod);
}
