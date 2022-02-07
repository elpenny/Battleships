public class ConsoleGameEngine : IGameEngine
{
    public ConsoleGameEngine()
    {
        this._renderer = new ConsoleRenderer();
    }
    private IRenderer _renderer;
    public void Run()
    {
        Console.WriteLine(GameCaptions.InitializingGame);
        this._renderer.Render();
    }

    public void Render()
    {
        this._renderer.Render();
    }
}