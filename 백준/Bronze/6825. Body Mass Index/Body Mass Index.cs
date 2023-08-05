float w = float.Parse(Console.ReadLine()!), h = float.Parse(Console.ReadLine()!);
float bmi = w / h / h;
Console.WriteLine(bmi > 25 ? "Overweight" : bmi < 18.5f ? "Underweight" : "Normal weight");