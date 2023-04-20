using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors_Omalley_Lauren
{
    class Game
    {
        // Creates two strings named title and genre
        public string title, genre;

        // A public constructor with two parameters with optional values of unknown title and casual
        public Game(string titleParam = "Unkown Title", string genreParam = "Casual")
        {
            // Assigns the parameters variables named title and genre
            title = titleParam;
            genre = genreParam;
        }

    }
}
