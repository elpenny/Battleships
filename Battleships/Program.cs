// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to BATTLESHIPS!");
Console.WriteLine("Press 's' to start the game or 'x' to exit.");

var loop = true;
while(loop) {
    var pressedKey = Console.ReadKey(true).KeyChar;
    switch(pressedKey) {
        case 's':
            Console.WriteLine("Starting game...");
            loop = false;
            break;
        case 'x':
            Console.WriteLine("Exiting...");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid key pressed. Please try again...");
            break;
    }
}
