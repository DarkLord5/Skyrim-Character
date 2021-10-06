using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace SkyrimPlayer
{
    class Program
    {
        const string english = "english";
        const string russian = "russian";
        //static Dictionary<int, string> EngHabbitDisc = new()
        //{
        //    { 1, "You are a addict, so, you must take 1 dose of skooma every two days." },
        //    { 2, "As you can see, brother, you are another drunk from the street. Now you have to drink two extra bottles after eating." },
        //    { 3, "You are thief! You cannot control yourself and every night you steal 3 things from the someone house." },
        //    { 4, "Your body is so weak... Now you cannot heal diseases." },
        //    { 5, "Guards are looking for you, now you cannot live in your hometown, but if you are from the forest then don't care. Roam like Genghis Khan every three days to another city." },
        //    { 6, "You are a schizo, so every two days you are obliged to change your bad habit, if the schiz falls, roll again." },
        //    { 7, "Become a vampire before starting the game. Do not heal, suck calmly, but do not let anyone know about it." },
        //    { 8, "Your face is boring, no one will give you money. You can't carry more than 500 gold." },
        //    { 9, "Apparently you are not a liar, but a schizo. Since you have already chosen a victim and you rearrange objects there every night." }
        //};

        //static Dictionary<int, string> RuHabbitDisc = new()
        //{
        //    { 1, "Так как ты наркоман, ты обязан принимать 1 дозу скумы раз в два дня." },
        //    { 2, "Как видишь, друг, ты алкоголик. Теперь ты обязан пить две доп бутылки после принятия пищи." },
        //    { 3, "Ты не можешь себя контролировать и каждую ночь воруешь по 3 вещи с домов жителей." },
        //    { 4, "М-да, у тебя очень слабая имунная система. Теперь ты не можешь излечивать болезни." },
        //    { 5, "Тебя ищут стражники, в родной город соваться нельзя, но если ты из лесу то плевать. Кочуй как Чингисхан каждые три дня в другой город." },
        //    { 6, "Ты шизик, поэтому каждые два дня ты обязан менять свою вредную привычку, коль упадёт шиза, роляй снова." },
        //    { 7, "Стань вампирчиком перед началом игры. Не лечись, соси себе спокойно, но не дай никому узнать об этом." },
        //    { 8, "У тебя лицо скучное, тебе никто денег не даст. Больше 500 золота носить не можешь." },
        //    { 9, "Видимо ты не лжец, а шизик. Так как уже выбрал жертву и переставляешь каждую ночь там предметы." }
        //};

        //static Dictionary<int, string> EngRaceDict = new()
        //{
        //        {1, "Argonian" }, {2, "Khajiit" }, {3, "Orc" }, {4, "Altmer" }, {5, "Dunmer" }, {6, "Bosmer" },
        //        {7, "Nord" }, {8, "Redguard" }, {9, "Breton" }, {10, "Imperial" }
        //};

        //static Dictionary<int, string> EngTownDict = new()
        //{
        //        {1, "Whiterun" }, {2, "Riften" }, {3, "Windhelm" }, {4, "Winterhold" }, {5, "Dawnstar" }, {6, "Solitude" },
        //        {7, "Morthal" }, {8, "Falkreath" }, {9, "Forest" }
        //};
        //static Dictionary<int, string> EngProfDict = new()
        //{
        //        {1, "Dealer" }, {2, "Blacksmith" }, {3, "Alchemist" }, {4, "Enchanter" }, {5, "Fisherman" }, {6, "Hunter" },
        //        {7, "Miner" }, {8, "Chef" }, {9, "Murderer" }
        //};
        //static Dictionary<int, string> EngWorldVisDict = new()
        //{
        //        {1, "Kind" }, {2, "Neutral" }, {3, "Rightfull" }, {4, "Lawful" }, {5, "Hero" }, {6, "Idiot" },
        //        {7, "CriminalInLaw" }, {8, "Selfish" }, {9, "Evil" }
        //};
        //static Dictionary<int, string> EngBadHabDict = new()
        //{
        //        {1, "Addict" }, {2, "Alcoholic" }, {3, "Kleptomaniac" }, {4, "Weakened" }, {5, "Criminal" }, {6, "Schizophrenic" },
        //        {7, "Vampire" }, {8, "Ugly" }, {9, "Liar" }
        //};

        //static Dictionary<int, string> RuRaceDict = new()  
        // {
        //        {1, "Аргонианен" }, {2, "Каджит" }, {3, "Орк" }, {4, "Альтмер" }, {5, "Данмер" }, {6, "Босмер" },
        //        {7, "Норд" }, {8, "Редгард" }, {9, "Бретонец" }, {10, "Имперец" }
        // };

        //static Dictionary<int, string> RuTownDict = new()  
        //{
        //        {1, "Вайтран" }, {2, "Рифтен" }, {3, "Виндхельм" }, {4, "Винтерхолд" }, {5, "Данстар" }, {6, "Солитьюд" },
        //        {7, "Морфал" }, {8, "Фолкрит" }, {9, "Дикая природа" }
        //};
        //static Dictionary<int, string> RuProfDict = new()  
        //{
        //        {1, "Торговец" }, {2, "Кузнец" }, {3, "Алхимик" }, {4, "Зачарователь" }, {5, "Рыбак" }, {6, "Охотник" },
        //        {7, "Шахтер" }, {8, "Повар" }, {9, "Головорез" }
        //};
        //static Dictionary<int, string> RuWorldVisDict = new()  
        //{
        //        {1, "Добрый" }, {2, "Нейтральный" }, {3, "Праведный" }, {4, "Законопослушный" }, {5, "Герой" }, {6, "Раздолбай" },
        //        {7, "Авторитетный бандюган" }, {8, "Эгоистичный" }, {9, "Злой" }
        //};
        //static Dictionary<int, string> RuBadHabDict = new()  
        //{
        //        {1, "Наркоман" }, {2, "Алкоголик" }, {3, "Клептоматик" }, {4, "Ослабленный" }, {5, "Вор" }, {6, "Шизофренник" },
        //        {7, "Вампир" }, {8, "Урод" }, {9, "Лжец" }
        //};
        static void Main(string[] args)
        {
            //Dictionary<string, Dictionary<int, string>> RuDict = new Dictionary<string, Dictionary<int, string>>() {
            //    {"race", RuRaceDict }, {"homeland", RuTownDict}, {"profesion", RuProfDict}, {"world wision", RuWorldVisDict}, {"bad habbit", RuBadHabDict}, {"phrases", RuPersonalDict },{"habbit discription", RuHabbitDisc }
            //};
            //Dictionary<string, Dictionary<int, string>> EngDict = new Dictionary<string, Dictionary<int, string>>() {
            //    {"race", EngRaceDict }, {"homeland", EngTownDict}, {"profesion", EngProfDict}, {"world wision", EngWorldVisDict}, {"bad habbit", EngBadHabDict}, {"phrases", EngPersonalDict },{"habbit discription", EngHabbitDisc }
            //};
            //string Engjson = JsonConvert.SerializeObject(EngDict);
            //string Rujson = JsonConvert.SerializeObject(RuDict);
            //File.WriteAllText(@"translations/EngText.json", Engjson);
            //File.WriteAllText(@"translations/RuText.json", Rujson);
            //using (StreamReader sr = new StreamReader(@"translations/RuText.json"))
            //{
            //    Console.WriteLine(sr.ReadToEnd());
            //}
            MyCharacter Charact = new();
            
            string language;
            string json;
            do
            {
                Console.WriteLine("Choose a language: 1)English(eng). 2)Russian(ru)");
                language = Console.ReadLine();
                if ((language == "2") || (language == "ru"))
                {
                    language = russian;
                    using StreamReader sr = new StreamReader(@"translations/RuText.json");
                    json = sr.ReadToEnd();
                    sr.Close();
                    break;
                }
                if ((language == "1") || (language == "eng"))
                {
                    language = english;
                    using StreamReader sr = new StreamReader(@"translations/EngText.json");
                    json = sr.ReadToEnd();
                    sr.Close();
                    break;
                }
            } while (true);
            TextLocalization localizer = new(language);
            Dictionary<string, Dictionary<int, string>> LangDict = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<int, string>>>(json);
            Dictionary<int, string> RaceDict = LangDict["race"];
            Dictionary<int, string> TownDict = LangDict["homeland"];
            Dictionary<int, string> ProfDict = LangDict["profesion"];
            Dictionary<int, string> WorldVisDict = LangDict["world wision"];
            Dictionary<int, string> BadHabDict = LangDict["bad habbit"];
            Dictionary<int, string> PersonalDict = LangDict["phrases"];
            Dictionary<int, Dictionary<int, string>> BaseDict = new() { { 1, RaceDict }, { 2, TownDict }, { 3, ProfDict }, { 4, WorldVisDict }, { 5, BadHabDict } };
            
            var propertyArr = new int[5, 2];
            for (int i = 1; i <= 5; i++)
            {
                propertyArr[i - 1, 1] = BaseDict[i].Count;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(localizer.Begining());

            Console.ForegroundColor = ConsoleColor.Yellow;

            for (int i = 0; i < 5; i++)
            {
                propertyArr[i, 0] = Charact.ParamRandomizer(0, propertyArr[i,1]+1);
                if (propertyArr[i, 0] == 0)
                {
                    Console.WriteLine(localizer.PlayerChoice(PersonalDict[i], propertyArr[i, 1]));
                    for(int j=1; j<= propertyArr[i, 1]; j++)
                    {
                        var Elem = BaseDict[i + 1];
                        Console.Write($"{j}. {Elem[j]}  ");
                    }
                    Console.WriteLine();
                    string answer = Console.ReadLine();
                    if ((int.TryParse(answer, out int num)) && (num > 0) && (num < propertyArr[i, 1] + 1))
                    {
                        Console.WriteLine(localizer.GoodProgrammAnswer());
                        propertyArr[i, 0] = num;
                    }
                    else
                    {
                        Console.WriteLine(localizer.WrongProgrammAnswer(PersonalDict[i]));
                        propertyArr[i, 0] = Charact.ParamRandomizer(1, propertyArr[i, 1] + 1);
                    }
                }
            }
            int[] resultArray = new int[5];
            for (int i = 0; i < 5; i++)
                resultArray[i] = propertyArr[i, 0];
            var result = Charact.CreateCharacter(resultArray);
            Console.WriteLine(localizer.Ending(LangDict,result));
            Console.ReadKey();
        }
    }
}