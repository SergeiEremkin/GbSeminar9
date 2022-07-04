int SumElements(int M, int N)
{
    int result=N;
    if (M<N)
    {
         result += SumElements(M+1, N);
    }
    return result;
}
System.Console.WriteLine(SumElements(1,10));
