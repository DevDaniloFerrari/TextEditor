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

void Edit(){

}

Menu();