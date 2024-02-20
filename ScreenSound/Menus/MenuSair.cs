using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuSair: Menu
{
    public override void ExecutarAsync(Dictionary<string, Banda> bandasRegistradas)
    {
        base.ExecutarAsync(bandasRegistradas);
        Console.WriteLine("Tchau tchau!");
    }
}
