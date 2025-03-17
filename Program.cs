Console.WriteLine("Hello, World!");

(int, int) ConvertMinutes(int nbMin)
{
    int H = nbMin / 60;
    int M = nbMin % 60;
    return (H, M);
}

Console.WriteLine("Entrez un nombre :");
int nbMin = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ConvertMinutes(nbMin));