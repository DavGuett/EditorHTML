using System.Text.RegularExpressions;

namespace EditorHTML;

public static class Viewer
{
    public static void Show(string text)
    {
        Console.Clear();
        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("Modo de visualização");
        Replace(text);
        Console.ReadKey();
        Menu.Show();
    }

    public static void Replace(string text)
    {
        var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
        Console.WriteLine(strong.IsMatch());
    }
}