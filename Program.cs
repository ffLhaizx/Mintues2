// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


(int,int) Convert(int nbMin)
{
    int H,M;
    M = nbMin%60;
    H = nbMin/60;
    return (H,M);
}

int nbMin = 100;
Console.WriteLine(Convert(nbMin));
