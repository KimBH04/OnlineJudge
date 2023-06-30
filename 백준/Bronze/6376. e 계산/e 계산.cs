static int Factorial(int n)
{
    if (n < 3)
        return n;
    return n-- * Factorial(n);
}

double[] dp = new double[10];
dp[2] = 2.5;

Console.WriteLine("n e\n- -----------\n0 1\n1 2\n2 2.5");
    
for (int i = 3; i < 10; i++)
{
    dp[i] = dp[i - 1] + 1d / Factorial(i);
    Console.WriteLine($"{i} {dp[i]:0.000000000}");
}
