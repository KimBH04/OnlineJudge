var s = (char c) =>
{
    return c switch
    {
        'M' => "MatKor",
        'W' => "WiCys",
        'C' => "CyKor",
        'A' => "AlKor",
        '$' => "$clear",
        _ => "",
    };
};
Console.Write(s((char)Console.Read()));