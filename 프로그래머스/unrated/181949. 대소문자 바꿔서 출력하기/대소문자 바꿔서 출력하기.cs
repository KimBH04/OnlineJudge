using System;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();
        
        foreach (char c in s) {
            Console.Write((char)(c + (c > 90 ? -32 : 32)));
        }
    }
}