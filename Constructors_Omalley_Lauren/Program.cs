using System;

namespace Constructors_Omalley_Lauren
{
    class Program
    {
        static void Main(string[] args)
        {
            // References the game class and creates 2 new objects
            Game myGame = new Game("CS:GO", "FPS");

            // Prints what my favorite game is and tells us what the genre is
            Console.WriteLine($"My favorite game is {myGame.title} and it is a {myGame.genre} game!");

            // References the game class and uses the opional choices
            Game myOtherGame = new Game();

            // Prints that my favorite game is unknown and that its a casual game
            Console.WriteLine($"My other favorite game is {myOtherGame.title} and it is a {myOtherGame.genre}!");
        }
    }
}
