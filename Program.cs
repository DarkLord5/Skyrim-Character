using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace SkyrimPlayer
{
    static class Program
    {
        static void Main(string[] args)
        {
            MyCharacter Charact = new();
            string filepath;
            string language;
            do
            {
                InputOutputProvider.PrintText("Choose a language: 1)English(eng). 2)Russian(ru)");
                language = InputOutputProvider.ReadText();
                if ((language == "2") || (language == "ru"))
                {
                    language = TextLocalization.russian;
                    filepath = TextLocalization.ruFilePath;
                    break;
                }
                if ((language == "1") || (language == "eng"))
                {
                    language = TextLocalization.english;
                    filepath = TextLocalization.engFilePath;
                    break;
                }
            } while (true);
            TextLocalization localizer = new(language, filepath);
            Dictionary<string, Dictionary<int, string>> LangDict = localizer.LangDict;
            Dictionary<int, string> RaceDict = LangDict["race"];
            Dictionary<int, string> TownDict = LangDict["homeland"];
            Dictionary<int, string> ProfDict = LangDict["profesion"];
            Dictionary<int, string> WorldVisDict = LangDict["world wision"];
            Dictionary<int, string> BadHabDict = LangDict["bad habbit"];
            Dictionary<int, string> PersonalDict = LangDict["phrases"];
            Dictionary<int, Dictionary<int, string>> BaseDict = new() { { 1, RaceDict }, { 2, TownDict }, { 3, ProfDict }, { 4, WorldVisDict }, { 5, BadHabDict } };
            int paramCount = BaseDict.Count;
            var propertyArr = new int[paramCount, 2];
            InputOutputProvider.PrintText(localizer.TextOut(1), ConsoleColor.Green);

            for (int i = 0; i < paramCount; i++)
            {
                propertyArr[i, 1] = BaseDict[i + 1].Count;
                propertyArr[i, 0] = Charact.ParamRandomizer(0, propertyArr[i,1]+1);
                if (propertyArr[i, 0] == 0)
                {
                    InputOutputProvider.PrintText(localizer.TextOut(PersonalDict[i], propertyArr[i, 1], 2), ConsoleColor.Yellow);
                    string paramList ="";
                    for(int j=1; j<= propertyArr[i, 1]; j++)
                    {
                        var Elem = BaseDict[i + 1];
                        paramList = $"{paramList}{j}. {Elem[j]}  ";
                    }
                    InputOutputProvider.PrintText(paramList, ConsoleColor.Blue);
                    string answer = InputOutputProvider.ReadText(ConsoleColor.Red);
                    if ((int.TryParse(answer, out int num)) && (num > 0) && (num < propertyArr[i, 1] + 1))
                    {
                        InputOutputProvider.PrintText(localizer.TextOut(3), ConsoleColor.Yellow);
                        propertyArr[i, 0] = num;
                    }
                    else
                    {
                        InputOutputProvider.PrintText(localizer.TextOut(PersonalDict[i], 4), ConsoleColor.Yellow);
                        propertyArr[i, 0] = Charact.ParamRandomizer(1, propertyArr[i, 1] + 1);
                    }
                }
            }
            int[] resultArray = new int[paramCount];
            for (int i = 0; i < paramCount; i++)
                resultArray[i] = propertyArr[i, 0];
            var res = Charact.CreateCharacter(resultArray);
            string ending = localizer.TextOut(LangDict["race"][res[1]], 5) + localizer.TextOut(LangDict["homeland"][res[2]], 6) + 
                localizer.TextOut(LangDict["profesion"][res[3]], 7) + localizer.TextOut(LangDict["world wision"][res[4]], 8) +
                localizer.TextOut(LangDict["bad habbit"][res[5]], 9) + localizer.TextOut(LangDict["habbit discription"][res[5]], 10)+
                localizer.TextOut(11);
            InputOutputProvider.PrintText(ending, ConsoleColor.Yellow);
            InputOutputProvider.ReadText();
        }
       
    }
}