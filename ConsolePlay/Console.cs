using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePlay
{
    class ConsoleInterface
    {
        const int BORDER = 3;
        const int HELPSTART = 16;

        public static void WriteBorder()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(0, 0);
            Console.Write(new String('=', Console.BufferWidth));

            Console.SetCursorPosition(0, 6);
            Console.Write(new String('=', Console.BufferWidth));

            Console.SetCursorPosition(0, HELPSTART);
            Console.Write(new String('=', Console.BufferWidth));
            
            Console.SetCursorPosition(0, 20);
            Console.Write(new String('=', Console.BufferWidth));

            for (int i = 0; i < 20; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("#");
                Console.SetCursorPosition(Console.BufferWidth-1, i);
                Console.Write("#");
            }
        }

        public static void WriteHelp()
        {
            Console.SetCursorPosition(BORDER, HELPSTART + 2);
            WriteColored("{Black,White}P{White,Black}=Play  {Black,White}S{White,Black}=Stop  {Black,White}N{White,Black}=Next  {Black,White}P{White,Black}=Previous");
        }

        public static void WriteColored(String message)
        {
            List<colormessage> lmessage = new List<colormessage>();

            foreach (var str in message.Split('{'))
            {
                if (str.Length > 0)
                {
                    string[] colors = str.Substring(0, str.IndexOf('}')).Split(',');
                    message = str.Substring(str.IndexOf('}')+1, str.Length - str.IndexOf('}')-1);

                    
                    lmessage.Add(new colormessage(colors[0], colors[1], message));
                }
            }
            foreach (colormessage cm in lmessage)
            {
                Console.ForegroundColor = cm._forecolor;
                Console.BackgroundColor = cm._backcolor;
                Console.Write(cm._message);
            }
            Console.ResetColor();
        }


    }

    class colormessage
    {
        public ConsoleColor _forecolor;
        public ConsoleColor _backcolor;
        public String _message;

        public colormessage(string fc, string bc, string message)
        {
            _forecolor = Helper.getConsoleColorFromString(fc);
            _backcolor = Helper.getConsoleColorFromString(bc);
            _message = message;
        }


    }
}
