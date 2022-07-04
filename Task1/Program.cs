void PrintNumber(int N)
{
    if (N != 0)
    {
        Console.WriteLine(N);
        PrintNumber(N - 1);
    }
}

void PrintNumberExtra(int Start, int N)
{
    if (Start <= N)
    {
        Console.WriteLine(Start);
        PrintNumberExtra(Start + 1,N);
    }

}
PrintNumber(10);
PrintNumberExtra(1,50);