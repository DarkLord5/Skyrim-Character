using System;

namespace SkyrimPlayer
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a language: 1)English(eng). 2)Russian(ru)");
            string language = Console.ReadLine();
            MyCharacter Pidor = new MyCharacter(language);
            Pidor.CreateCaracter();

            Console.ReadKey();
        }
    }
}
