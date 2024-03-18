// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Cititi de la tastatura continutul unei matrici de intregi cu 3 dimensiuni avand lungimile n, m k.
//Lungimile celor trei dimensiuni ale matricii, n, m si k, vor fi citite de la tastaura. 
Console.WriteLine("insert n");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("insert m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("insert k");
int k = int.Parse(Console.ReadLine());
//Scrieti o functie care va calcula suma elementelor unei astfel de matrici , apelati-o si afisati-i rezultatul
void SumElem(int[,,]matrix)
{
    int sum = 0;
    for (int i=0;i<n;i++)
    {
        for (int j=0;j<m;j++)
        {
            for(int l=0;l<k;l++)
            {
                sum = sum + matrix[i, j, l];
                return sum;
            }
        }
    }
    Console.WriteLine(sum);
    
}
//Scrieti o functie care va determina elementul cu valoare maxima, apelati-o si afisati-i rezultatul. 
int GetMax(int[,,]matrix)
{
    int max = matrix[0, 0, 0];
    for (int i = 0; i < n; i++)
    { 
        for(int j=0;j<m;j++)
        {
            for (int l=0;l<k;l++)
            {
                if (matrix[i,j,l]>max)
                {
                    max = matrix[i, j, l];
                    return max;
                }
            }
        }
    }
    Console.WriteLine(max);
}