// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Cititi de la tastatura continutul unei matrici de intregi cu 2 dimensiuni avand lungimile m, n.
//Lungimile celor doua dimensiuni ale matricii, m si n, vor fi citite de la tastaura.
Console.WriteLine("introduceti n");
var n = int.Parse(Console.ReadLine());
Console.WriteLine("introduceti m");
var m = int.Parse(Console.ReadLine());
//Scrieti o functie care va afisa continutul unei astfel de matrici si apelati-o.
int[,] ReadMatrix()
{
    int[,] result = new int[n, m];
    for(int i=0;i<n;i++)
    {
        for(int j=0;j<m:j++)
        {
             result[i, j] = i * j;
        }
    }
    return result;
}
void ShowMatrix(int[,]matrix)
{
    int n = matrix.GetLenght(0);
    int m = matrix.GetLenght(10);
    for (var i=0;i<n;i++)
    {
        for (var j=0;j<m;j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();

    }
}
//Scrieti o functie care va aduna doua matrici, apelati-o si afisati rezultatul.
int[,] ReadMatrix2()
{
    int[,] result2 = new int[n, m];
    for (int k=0;k<n;k++)
    {
        for (int l=0;l<m;l++)
        {
            result2[k, l] = int * l;
        }
    }

}
//am facut o fucntie de citire oentry a doua matrice
void SumMatrix(int[,]matrix && int[,]matrix2)
{
    int sum = 0;
    for (int i=0;i<n;i++)
    {
        for (int j=0;j<m;j++)
        {
            for(int k=0;k<m;k++)
            {
                for(int l=0;l<m;l++)
                {
                    int sum = int[i, j]matrix + int[k, l];
                }
            }

        }
    }
    return sum;
}