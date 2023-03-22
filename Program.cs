void Menu()
{
    Console.Clear();
    Console.WriteLine("What do you wanna do?");
    Console.WriteLine("1 - Open file");
    Console.WriteLine("2 - Create a new file");
    Console.WriteLine("0 - Exit");
    short option = short.Parse(Console.ReadLine());

    switch (option)
    {
        case 0: System.Environment.Exit(0); break;
        case 1: Open(); break;
        case 2: Edit(); break;
        default: Menu(); break;
    }

}

void Open()
{

}

void Edit()
{
    Console.Clear();
    Console.WriteLine("Write your text below (ESC to exit)");
    Console.WriteLine("---------------------");
    string text = "";

    do
        text += Console.ReadLine() + Environment.NewLine;
    while (Console.ReadKey().Key != ConsoleKey.Escape);

    Save(text);
}

void Save(string text)
{
    Console.Clear();
    Console.WriteLine("What path to save the file?");
    var path = Console.ReadLine();

    using (var file = new StreamWriter(path))
        file.Write(text);

    Console.WriteLine($"File {path} successfuly saved!");
    Console.ReadLine();
    Menu();
}

Menu();