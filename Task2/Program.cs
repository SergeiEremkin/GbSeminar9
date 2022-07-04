void PrintNumber(int M, int N)
{
    if (M <= N)
    {
        Console.WriteLine(M);
        PrintNumber(M + 1,N);
    }

}
PrintNumber(10,20);

