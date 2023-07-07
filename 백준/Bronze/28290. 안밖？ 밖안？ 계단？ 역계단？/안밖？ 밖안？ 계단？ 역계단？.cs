var _ = (string a) =>
{
    return a switch
    {
        "fdsajkl;" or "jkl;fdsa" => "in-out",
        "asdf;lkj" or ";lkjasdf" => "out-in",
        "asdfjkl;" => "stairs",
        ";lkjfdsa" => "reverse",
        _ => "molu",
    };
};

Console.WriteLine(_(Console.ReadLine()!));