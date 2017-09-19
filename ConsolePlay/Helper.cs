using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePlay
{
    static class Helper
    {
        public static ConsoleColor getConsoleColorFromString(string color)
        {
            switch (color.ToLower())
            {
                case "black":
                    return ConsoleColor.Black;
                case "blue":
                    return ConsoleColor.Blue;
                case "cyan":
                    return ConsoleColor.Cyan;
                case "darkblue":
                    return ConsoleColor.DarkBlue;
                case "darkcyan":
                    return ConsoleColor.DarkCyan;
                case "darkgreen":
                    return ConsoleColor.DarkGreen;
                case "darkmagenta":
                    return ConsoleColor.DarkMagenta;
                case "darkred":
                    return ConsoleColor.DarkRed;
                case "darkyellow":
                    return ConsoleColor.DarkYellow;
                case "gray":
                    return ConsoleColor.Gray;
                case "green":
                    return ConsoleColor.Green;
                case "magenta":
                    return ConsoleColor.Magenta;
                case "red":
                    return ConsoleColor.Red;
                case "white":
                    return ConsoleColor.White;
                case "yellow":
                    return ConsoleColor.Yellow;

            }
            return ConsoleColor.White;
        }
    }
}
