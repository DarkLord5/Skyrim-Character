using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace SkyrimPlayer
{
    static class Program
    {
        const int paramCount = 5;
        static void Main(string[] args)
        {
            MyCharacter Charact = new();

            string filepath;
            string language;
            do
            {
                Console.WriteLine("Choose a language: 1)English(eng). 2)Russian(ru)");
                language = Console.ReadLine();
                if ((language == "2") || (language == "ru"))
                {
                    language = TextLocalization.russian;
                    filepath = @"public\translations\RuText.json";
                    break;
                }
                if ((language == "1") || (language == "eng"))
                {
                    language = TextLocalization.english;
                    filepath = @"public\translations\EngText.json";
                    break;
                }
            } while (true);
            TextLocalization localizer = new(language);
            using StreamReader sr = new(filepath);
            string json = sr.ReadToEnd();
            sr.Close();
            Dictionary<string, Dictionary<int, string>> LangDict = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<int, string>>>(json);
            Dictionary<int, string> RaceDict = LangDict["race"];
            Dictionary<int, string> TownDict = LangDict["homeland"];
            Dictionary<int, string> ProfDict = LangDict["profesion"];
            Dictionary<int, string> WorldVisDict = LangDict["world wision"];
            Dictionary<int, string> BadHabDict = LangDict["bad habbit"];
            Dictionary<int, string> PersonalDict = LangDict["phrases"];
            Dictionary<int, Dictionary<int, string>> BaseDict = new() { { 1, RaceDict }, { 2, TownDict }, { 3, ProfDict }, { 4, WorldVisDict }, { 5, BadHabDict } };
            
            var propertyArr = new int[paramCount, 2];
            for (int i = 1; i <= paramCount; i++)
            {
                propertyArr[i - 1, 1] = BaseDict[i].Count;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(localizer.JustText(1));

            Console.ForegroundColor = ConsoleColor.Yellow;

            for (int i = 0; i < paramCount; i++)
            {
                propertyArr[i, 0] = Charact.ParamRandomizer(0, propertyArr[i,1]+1);
                if (propertyArr[i, 0] == 0)
                {
                    Console.WriteLine(localizer.TextWithParamCount(PersonalDict[i], propertyArr[i, 1], 2));
                    for(int j=1; j<= propertyArr[i, 1]; j++)
                    {
                        var Elem = BaseDict[i + 1];
                        Console.Write($"{j}. {Elem[j]}  ");
                    }
                    Console.WriteLine();
                    string answer = Console.ReadLine();
                    if ((int.TryParse(answer, out int num)) && (num > 0) && (num < propertyArr[i, 1] + 1))
                    {
                        Console.WriteLine(localizer.JustText(3));
                        propertyArr[i, 0] = num;
                    }
                    else
                    {
                        Console.WriteLine(localizer.TextWithParam(PersonalDict[i], 4));
                        propertyArr[i, 0] = Charact.ParamRandomizer(1, propertyArr[i, 1] + 1);
                    }
                }
            }
            int[] resultArray = new int[paramCount];
            for (int i = 0; i < paramCount; i++)
                resultArray[i] = propertyArr[i, 0];
            var result = Charact.CreateCharacter(resultArray);
            Console.WriteLine(localizer.Ending(LangDict,result));
            Console.ReadKey();
        }
    }
}