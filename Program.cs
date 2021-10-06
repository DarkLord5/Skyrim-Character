using System;
using System.Collections.Generic;

namespace SkyrimPlayer
{
    class Program
    {
        static Dictionary<int, string> EngHabbitDisc = new()
        {
            { 1, "You are a addict, so, you must take 1 dose of skooma every two days." },
            { 2, "As you can see, brother, you are another drunk from the street. Now you have to drink two extra bottles after eating." },
            { 3, "You are thief! You cannot control yourself and every night you steal 3 things from the residents' hut. I condemn." },
            { 4, "Hmmm, you're also a fagot because you've been diagnosed with severe northern HIV. Now you cannot heal diseases." },
            { 5, "They are looking for you, they cannot go to their hometown, but if you are from the forest then give a fuck. Find out what it is like for the Skyrim bums, roam like Genghis Khan every three days to another city." },
            { 6, "You are a schizo, so every two days you are obliged to change your bad habit, if the schiz falls, roll again." },
            { 7, "Become a vampire before starting the game. Do not heal, suck yourself calmly, but do not let anyone know about it." },
            { 8, "Your face is boring, no one will give you money. You can't carry more than 500 gold." },
            { 9, "Apparently you are not a liar, but a schizo. Since you have already chosen a victim and you rearrange objects there every night. What the fuck? Fuck knows you." }
        };

        static Dictionary<int, string> RuHabbitDisc = new()
        {
            { 1, "Так как ты наркоман, ты обязан принимать 1 дозу скумы раз в два дня." },
            { 2, "Как видишь, друг, ты алкоголик. Теперь ты обязан пить две доп бутылки после принятия пищи." },
            { 3, "Ты ворюга ебучая! Не можешь себя контролировать и каждую ночь воруешь по 3 вещи с хаты жителей. Осуждаю." },
            { 4, "М-да, ты ещё и заднеприводный у нас, ведь у тебя диагностировали суровый северный ВИЧ. Теперь ты не можешь излечивать болезни." },
            { 5, "Тебя ищут, в родной город те нельзя, но если ты из лесу то похуй. Узнай каково скайримским бомжам, кочуй как Чингисхан каждый три дня в другой город." },
            { 6, "Ты шизик, поэтому каждые два дня ты обязан менять свою вредную привычку, коль упадёт шиза, роляй снова." },
            { 7, "Стань вампирчиком перед началом игры. Не лечись, соси себе спокойно, но не дай никому узнать об этом." },
            { 8, "У тебя лицо скучное, тебе никто денег не даст. Больше 500 золота носить не можешь." },
            { 9, "Видимо ты не лжец, а шизик. Так как уже выбрал жертву и переставляешь каждую ночь там предметы. Нахуя? А хуй тебя знает." }
        };

        static Dictionary<int, string> EngRaceDict = new()
        {
                {1, "Argonian" }, {2, "Khajiit" }, {3, "Orc" }, {4, "Altmer" }, {5, "Dunmer" }, {6, "Bosmer" },
                {7, "Nord" }, {8, "Redguard" }, {9, "Breton" }, {10, "Imperial" }
        };

        static Dictionary<int, string> EngTownDict = new()
        {
                {1, "Whiterun" }, {2, "Riften" }, {3, "Windhelm" }, {4, "Winterhold" }, {5, "Dawnstar" }, {6, "Solitude" },
                {7, "Morthal" }, {8, "Falkreath" }, {9, "Forest" }
        };
        static Dictionary<int, string> EngProfDict = new()
        {
                {1, "Dealer" }, {2, "Blacksmith" }, {3, "Alchemist" }, {4, "Enchanter" }, {5, "Fisherman" }, {6, "Hunter" },
                {7, "Miner" }, {8, "Chef" }, {9, "Murderer" }
        };
        static Dictionary<int, string> EngWorldVisDict = new()
        {
                {1, "Kind" }, {2, "Neutral" }, {3, "Rightfull" }, {4, "Lawful" }, {5, "Hero" }, {6, "Idiot" },
                {7, "CriminalInLaw" }, {8, "Selfish" }, {9, "Evil" }
        };
        static Dictionary<int, string> EngBadHabDict = new()
        {
                {1, "Addict" }, {2, "Alcoholic" }, {3, "Kleptomaniac" }, {4, "Weakened" }, {5, "Criminal" }, {6, "Schizophrenic" },
                {7, "Vampire" }, {8, "Ugly" }, {9, "Liar" }
        };

        static Dictionary<int, string> RuRaceDict = new()  
         {
                {1, "Аргонианен" }, {2, "Каджит" }, {3, "Орк" }, {4, "Альтмер" }, {5, "Данмер" }, {6, "Босмер" },
                {7, "Норд" }, {8, "Редгард" }, {9, "Бретонец" }, {10, "Имперец" }
         };

        static Dictionary<int, string> RuTownDict = new()  
        {
                {1, "Вайтран" }, {2, "Рифтен" }, {3, "Виндхельм" }, {4, "Винтерхолд" }, {5, "Данстар" }, {6, "Солитьюд" },
                {7, "Морфал" }, {8, "Фолкрит" }, {9, "Дикая природа" }
        };
        static Dictionary<int, string> RuProfDict = new()  
        {
                {1, "Торговец" }, {2, "Кузнец" }, {3, "Алхимик" }, {4, "Зачарователь" }, {5, "Рыбак" }, {6, "Охотник" },
                {7, "Шахтер" }, {8, "Повар" }, {9, "Головорез" }
        };
        static Dictionary<int, string> RuWorldVisDict = new()  
        {
                {1, "Добрый" }, {2, "Нейтральный" }, {3, "Праведный" }, {4, "Законопослушный" }, {5, "Герой" }, {6, "Раздолбай" },
                {7, "Авторитетный бандюган" }, {8, "Эгоистичный" }, {9, "Злой" }
        };
        static Dictionary<int, string> RuBadHabDict = new()  
        {
                {1, "Наркоман" }, {2, "Алкоголик" }, {3, "Клептоматик" }, {4, "Ослабленный" }, {5, "Вор" }, {6, "Шизофренник" },
                {7, "Вампир" }, {8, "Урод" }, {9, "Лжец" }
        };
        static void Main(string[] args)
        {
            Dictionary<int, Dictionary<int, string>> EngBaseDict = new() { { 1, EngRaceDict }, { 2, EngTownDict }, { 3, EngProfDict }, { 4, EngWorldVisDict }, { 5, EngBadHabDict } };
            Dictionary<int, Dictionary<int, string>> RuBaseDict = new() { { 1, RuRaceDict }, { 2, RuTownDict }, { 3, RuProfDict }, { 4, RuWorldVisDict }, { 5, RuBadHabDict } };
            Dictionary<int, string> EngPersonalDict = new() { {0, "race" },{1, "homeland" },{2, "profesion" },{3, "world wision" },{4,"bad habbit" } };
            Dictionary<int, string> RuPersonalDict = new() { { 0, "расу" }, { 1, "родину" }, { 2, "профессию" }, { 3, "мировоззрение" }, { 4, "вредную привычку" } };

            MyCharacter Charact = new();
            var propertyArr = new int[5,2];
            for (int i = 1; i <= 5; i++)
            {
                propertyArr[i - 1, 1] = RuBaseDict[i].Count;
            }
            string language;
            do
            {
                Console.WriteLine("Choose a language: 1)English(eng). 2)Russian(ru)");
                language = Console.ReadLine();
            } while ((language != "1") && (language != "2") && (language != "ru") && (language != "eng"));

            Console.ForegroundColor = ConsoleColor.Green;
            if (language == "ru")
            {
                Console.WriteLine("Перед созданием персонажа, расскажу тебе главные правила:\n-Начинаешь на максимальном уровне сложности и не меняешь его.\n-Перезагружать игру нельзя. Твои решения окончательны.\n-У тебя всего одна жизнь. Если умер, удаляешь его.\n-Ты можешь выбрать только одну фрацию.\n");
            }
            else Console.WriteLine("Before creating a character, I'll tell you the main rules:\n-You start at the maximum difficulty level and don't change it. \n-You cannot restart the game. Your decisions are final. \n-You only have one life. \n-You can only choose one facies.\n");
            
            Console.ForegroundColor = ConsoleColor.Yellow;

            for (int i = 0; i < 5; i++)
            {
                propertyArr[i, 0] = Charact.ParamRandomizer(0, propertyArr[i,1]+1);
                if (propertyArr[i, 0] == 0)
                {

                    if ((language == "ru") || (language == "2")) { 
                        Console.WriteLine($"Выберите {RuPersonalDict[i]} самостоятельно, введите число от 1 до {propertyArr[i, 1]}. Список параметров:");
                        for(int j=1; j<= propertyArr[i, 1]; j++)
                        {
                            var Elem = RuBaseDict[i + 1];
                            Console.Write($"{j}. {Elem[j]}  ");
                        }
                    }
                    else{
                    Console.WriteLine($"Choose {EngPersonalDict[i]} yourself, put the number from 1 to {propertyArr[i, 1]}. List of properties");
                        for (int j = 1; j <= propertyArr[i, 1]; j++)
                        {
                            var Elem = EngBaseDict[i + 1];
                            Console.Write($"{j}. {Elem[j]}  ");
                        }
                    }
                    Console.WriteLine();
                    string answer = Console.ReadLine();
                    if ((int.TryParse(answer, out int num)) && (num > 0) && (num < propertyArr[i, 1] + 1))
                    {
                        if (language == "ru")
                            Console.WriteLine("Принято\n");
                        else Console.WriteLine("Okey\n");
                        propertyArr[i, 0] = num;
                    }
                    else
                    {
                        if (language == "ru")
                            Console.WriteLine($"\nРешил наебать меня? Собака, хуй тебе, теперь у тебя не будет шанса выбрать самому {EngPersonalDict[i]}.\n");
                        else { Console.WriteLine($"\nDid you fuck with me, dog? Now you won't have a chance to choose {EngPersonalDict[i]} yourself. \n"); }
                        propertyArr[i, 0] = Charact.ParamRandomizer(1, propertyArr[i, 1] + 1);
                    }
                }
            }
            int[] resultArray = new int[5];
            for (int i = 0; i < 5; i++)
                resultArray[i] = propertyArr[i, 0];
            var result = Charact.CreateCharacter(resultArray);
            if (language == "ru")
            {
                Console.WriteLine($"Запомни, Довакин, теперь ты {RuRaceDict[result[1]]}. Так вышло, что твоя родина - {RuTownDict[result[2]]}.\nРабота непростая, ведь ты у нас {RuProfDict[result[3]]}. Как я понял, ты дохуя {RuWorldVisDict[result[4]]}, что ж, дело твоё. \nВ твоей жизни не всё так просто, у тебя есть хреновая особенность, ты {RuBadHabDict[result[5]]}!");
                Console.WriteLine($"Расскажу-ка тебе, как с такой особенностью живётся. \n{RuHabbitDisc[result[4]]}\n\n");
                Console.WriteLine("Вот тебе ещё правила, мотай на ус:\n1)Быстрое перемещение запрещено. Использовать баги/читы/консольку нельзя.\n2)Ездить на лошади разрешено, но только по дорогам.\n3)Ешь три раза в день, твой рацион - 3 блюда и 1 напиток\n4)Спи минимум 7 часов, если недоспал или спал слишком много, то отними или прибавь доп часы к следующему сну.\nСпать можешь только на оборудованных для сна местах.\n5)Ты не можешь носить больше 80 килограмм груза.\n6)Если на улице дождь - надевай головной убор\n7)Твоя сумка вмещает только то, что может в реальности, то есть без огромных предметов внутри.\n8)Cлушай все диалоги в игре без пропусков.\n9)Твоё имя должно подходить твоей расе.\n10)Получай опыт реалистично, без пауэрлевелинга.\n11)Путешествие начинается после того, как ты поспал в родной локации. Игнорируй главный квест.");
            }
            else
            {
                Console.WriteLine($"Remember, Dovahkiin, now you are {EngRaceDict[result[1]]}. It so happened that your homeland is {EngTownDict[result[2]]}. \nWork is not easy, because you are {EngProfDict[result[3]]}. As I understand, you are fucking {RuWorldVisDict[result[5]]}, well, it's your business. \nYour life is not so simple, you have a shitty peculiarity, you are {EngBadHabDict[result[5]]}!");
                Console.WriteLine($"I'll tell you how you live with such a feature. \n{EngHabbitDisc[result[4]]}\n\n");
                Console.WriteLine("Here are some more rules, read and remember: \n1) Fast travel is prohibited. You cannot use bugs / cheats / console. \n2) Riding a horse is allowed, but only on the roads. \n3) Eat three times a day, your diet is 3 meals and 1 drink \n4) Sleep at least 7 hours if you did not sleep enough or slept too much, then take away or add extra hours to the next sleep. \nSleep only in places equipped for sleeping.\n5) You cannot carry more than 80 kilograms of cargo. \n6) If it is raining outside, put on a hat \n7) Your bag only holds what it can in reality, that is, without huge objects inside. \n8) Listen to all the dialogues in play without skipping. \n9) Your name must be suitable for your race. \n10) Experience realistically, without power leveling. \n11) The journey begins after you have slept in your home location. Ignore the main quest.");
            }
            Console.ReadKey();
        }
    }
}