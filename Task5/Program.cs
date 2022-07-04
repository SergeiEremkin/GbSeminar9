int Exponentiation(int A, int B)
{
    if (B != 1)
    {
        A *= Exponentiation(A, B - 1);
    }
    return A;
}
System.Console.WriteLine(Exponentiation(2, 3));