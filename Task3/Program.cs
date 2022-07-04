void PrintNumber(int M, int N, int Step)
{
    if (M <= N)
    {
        Console.WriteLine(M);
        PrintNumber(M + Step,N, Step);
    }

}
PrintNumber(10,20,2);
