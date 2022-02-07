// See https://aka.ms/new-console-template for more information
Console.WriteLine(GameCaptions.Welcome);
Console.WriteLine(GameCaptions.StartOrExit);

var loop = true;
while(loop) {
    var pressedKey = Console.ReadKey(true).KeyChar;
    switch(pressedKey) {
        case 's':
            Console.WriteLine(GameCaptions.StartingGame);
            IGameEngine engine = new ConsoleGameEngine();
            engine.Run();
            Console.WriteLine(GameCaptions.StartOrExit);
            break;
        case 'x':
            Console.WriteLine(GameCaptions.ExitingGame);
            loop = false;
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine(GameCaptions.InvalidKey);
            break;
    }
}
