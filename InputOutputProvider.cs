using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyrimPlayer
{
    static class InputOutputProvider
    {
        public static void PrintText(string text = "", ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
        }
        public static string ReadText(ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            return Console.ReadLine();
        }
    }
}
