try
{
    throw new Exception("Hello World!");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}