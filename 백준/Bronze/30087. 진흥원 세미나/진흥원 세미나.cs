var room = (string name) =>
{
    return name switch
    {
        "Algorithm" => "204",
        "DataAnalysis" => "207",
        "ArtificialIntelligence" => "302",
        "CyberSecurity" => "B101",
        "Network" => "303",
        "Startup" => "501",
        "TestStrategy" => "105",
        _ => "",
    };
};

int n = int.Parse(Console.ReadLine()!);
while (n-- > 0)
{
    Console.WriteLine(room(Console.ReadLine()!));
}
