using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace SkyrimPlayer
{
    class Program
    {
        static TextLocalization localizer = new(TextLocalization.english, TextLocalization.engFilePath);
        static Dictionary<string, Dictionary<int, string>> LangDict = localizer.LangDict;
        static MyCharacter Charact = new();

        static void Main(string[] args)
        {
            do
            {
                InputOutputProvider.PrintText(localizer.TextOut(13));
                string choice = InputOutputProvider.ReadText(ConsoleColor.Red);
                if (choice == "1"){
                    GenerateCharacter();
                } else if (choice == "2") {
                    if (Charact.MyBadHabbit == "Schizophrenic")
                    {
                        ChangeHabbit();
                    }else{
                        InputOutputProvider.PrintText(localizer.TextOut(15));
                    }
                } else if (choice == "3") {
                    SelectLanguage();
                } else if (choice == "4") { 
                    break;
                } else {
                    InputOutputProvider.PrintText(localizer.TextOut(14));
                }
            } while (true);
            
        }

        static public void GenerateCharacter()
        {
            InputOutputProvider.PrintText(localizer.TextOut(1), ConsoleColor.Green);
            
            Dictionary<int, Dictionary<int, string>> BaseDict = new() { { 1, LangDict["race"] }, { 2, LangDict["homeland"] }, { 3, LangDict["profesion"] }, { 4, LangDict["world wision"] }, { 5, LangDict["bad habbit"] } };
            int paramCount = BaseDict.Count;
            var propertyArr = new int[paramCount];
            for (int i = 0; i < paramCount; i++)
            {
                propertyArr[i] = ParamGeneration(LangDict["phrases"][i], BaseDict[i + 1]);
            }
            var res = Charact.CreateCharacter(propertyArr);
            string ending = localizer.TextOut(LangDict["race"][res[1]], 5) + localizer.TextOut(LangDict["homeland"][res[2]], 6) +
                localizer.TextOut(LangDict["profesion"][res[3]], 7) + localizer.TextOut(LangDict["world wision"][res[4]], 8) +
                localizer.TextOut(LangDict["bad habbit"][res[5]], 9) + localizer.TextOut(LangDict["habbit discription"][res[5]], 10) +
                localizer.TextOut(11);
            InputOutputProvider.PrintText(ending, ConsoleColor.Yellow);
        }

        static public void ChangeHabbit()
        {
            Dictionary<int, string> BadHabDict = LangDict["bad habbit"];
            Dictionary<int, string> PersonalDict = LangDict["phrases"];
            int result = ParamGeneration(PersonalDict[4], BadHabDict);
            Charact.TempBadHabbit = BadHabDict[result];
            string newHabbit = localizer.TextOut(LangDict["bad habbit"][result], 9) + localizer.TextOut(LangDict["habbit discription"][result], 10);
            InputOutputProvider.PrintText(newHabbit, ConsoleColor.Yellow);
        }

        static public int ParamGeneration(string paramName, Dictionary<int, string> allParams)
        {
            int result = Charact.ParamRandomizer(0, allParams.Count + 1);
            if (result == 0)
            {
                InputOutputProvider.PrintText(localizer.TextOut(paramName, allParams.Count, 2), ConsoleColor.Yellow);
                string paramList = "";
                for (int j = 1; j <= allParams.Count; j++)
                {
                    paramList = $"{paramList}{j}. {allParams[j]}  ";
                }
                InputOutputProvider.PrintText(paramList, ConsoleColor.Blue);
                string answer = InputOutputProvider.ReadText(ConsoleColor.Red);
                if ((int.TryParse(answer, out int num)) && (num > 0) && (num < allParams.Count + 1))
                {
                    InputOutputProvider.PrintText(localizer.TextOut(3), ConsoleColor.Yellow);
                    result = num;
                }
                else
                {
                    InputOutputProvider.PrintText(localizer.TextOut(paramName, 4), ConsoleColor.Yellow);
                    result = Charact.ParamRandomizer(1, allParams.Count + 1);
                }
            }
            return result;
        }

        static public void SelectLanguage()
        {
            string filepath;
            string language;
            do
            {
                InputOutputProvider.PrintText(localizer.TextOut(12));
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
            localizer = new(language, filepath);
            LangDict = localizer.LangDict;
        }
    }
}