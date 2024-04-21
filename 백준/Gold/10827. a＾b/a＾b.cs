using System.Numerics;

string[] inputs = Console.ReadLine()!.Split();
var a = BigDecimal.Parse(inputs[0]);
int b = int.Parse(inputs[1]);

var result = BigDecimal.Parse("1");
while (b-- > 0)
{
    result *= a;
}

Console.WriteLine(result);

public struct BigDecimal
{
    private BigInteger mantissa;
    private int exponent;

    public static BigDecimal Parse(string value)
    {
        int len = value.Length;
        int idx = -1;
        for (int i = 0; i < len; i++)
        {
            if (value[^(i + 1)] == '.')
            {
                idx = i;
                break;
            }
        }

        if (idx >= 0)
        {
            return new BigDecimal
            {
                mantissa = BigInteger.Parse(value[..^(idx + 1)] + value[^idx..]),
                exponent = -idx
            };
        }
        else
        {
            return new BigDecimal
            {
                mantissa = BigInteger.Parse(value),
                exponent = 0
            };
        }
    }

    public override readonly string ToString()
    {
        if (exponent >= 0)
        {
            return mantissa.ToString() + new string('0', exponent);
        }

        var man = mantissa.ToString();
        if (man.Length <= -exponent)
        {
            return "0." + new string('0', -(exponent + man.Length)) + man.TrimEnd('0');
        }

        return man[..^-exponent] + "." + man[^-exponent..];
    }

    public static BigDecimal operator *(BigDecimal a, BigDecimal b)
    {
        return new BigDecimal
        {
            mantissa = a.mantissa * b.mantissa,
            exponent = a.exponent + b.exponent
        };
    }
}