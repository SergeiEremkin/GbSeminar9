int SumOfNumbers(int Number)
{   
    int sum = 0;
    if(Number!=0)
    {
        sum += SumOfNumbers(Number/10)+Number%10;
    }
    return sum;
}
Console.WriteLine(SumOfNumbers(2243));
