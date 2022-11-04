public static class Menu
{
    static void DrawColumn(int numberOfColumns)
    {
        Console.Write("+");
        for (int i = 0; i <= numberOfColumns; i++)
        {
            Console.Write("-");
        }
        Console.Write("+");
        Console.Write("\n");
    }
    public static void Show()
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Black;
        DrawScreen();
        ShowOptions();
        int option = int.Parse(Console.ReadLine());
    }
    public static void DrawScreen()
    {
        DrawColumn(30);
        for (int lines = 0; lines <= 10; lines++)
        {
            Console.Write("|");
            for (int i = 0; i <= 30; i++)
            {
                Console.Write(" ");
            }
            Console.Write("|");
            Console.Write("\n");
        }
        DrawColumn(30);
    }

    public static void ShowOptions()
    {
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("Editor HTML");
        Console.SetCursorPosition(3, 4);
        Console.WriteLine("Selecione uma opção abaixo");
        Console.SetCursorPosition(3, 6);
        Console.WriteLine("1 - Novo Arquivo");
        Console.SetCursorPosition(3, 7);
        Console.WriteLine("2 - Abrir Arquivo");
        Console.SetCursorPosition(3, 8);
        Console.WriteLine("3 - Sair");
        Console.SetCursorPosition(3, 10);

    }
}