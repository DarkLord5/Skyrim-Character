using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyrimPlayer
{
    public enum Race //пречисление
    {
        Argonian = 1,
        Khajiit,
        Orc,
        Altmer,
        Dunmer,
        Bosmer,
        Nord,
        Redguard,
        Breton,
        Imperial
    }

    public enum Town //пречисление
    {
        Whiterun = 1,
        Riften,
        Windhelm,
        Winterhold,
        Dawnstar,
        Solitude,
        Morthal,
        Falkreath,
        Forest
    }

    public enum Profession
    {
        Dealer = 1,
        Blacksmith,
        Alchemist,
        Enchanter,
        Fisherman,
        Hunter,
        Miner,
        Chef,
        Murderer

    }

    public enum WorldVision
    {
        Kind = 1,
        Neutral,
        Rightfull,
        Lawful,
        Hero,
        Idiot,
        CriminalInLaw,
        Selfish,
        Evil
    }

    public enum BadHabbits
    {
        Addict = 1,
        Alcoholic,
        Kleptomaniac,
        Weakened,
        Criminal,
        Schizophrenic,
        Vampire,
        Ugly,
        Liar

    }
    class MyCharacter
    {
        public MyCharacter(string l)
        {
            if ((l == "ru") || (l == "2"))
            {
                language = "ru";
                Console.WriteLine("Вы выбрали русский язык");
            }
            else
            {
                language = "eng";
                Console.WriteLine("You have chosen english");
            }

        }
        public static string language { get; set; }
        public Race MyRace { get; set; }
        public Town MyTown { get; set; }
        public Profession MyProfecy { get; set; }
        public WorldVision MyWorldVision { get; set; }
        public BadHabbits MyBadHabbit { get; set; }

        private static readonly Dictionary<int, string> RuRaceDict = new Dictionary<int, string>()  //Словарь
       {
                {1, "Аргонианен" }, {2, "Каджит" }, {3, "Орк" }, {4, "Альтмер" }, {5, "Данмер" }, {6, "Босмер" },
                {7, "Норд" }, {8, "Редгард" }, {9, "Бретонец" }, {10, "Имперец" }
       };

        private static readonly Dictionary<int, string> RuTownDict = new Dictionary<int, string>()  //Словарь
       {
                {1, "Вайтран" }, {2, "Рифтен" }, {3, "Виндхельм" }, {4, "Винтерхолд" }, {5, "Данстар" }, {6, "Солитьюд" },
                {7, "Морфал" }, {8, "Фолкрит" }, {9, "Дикая природа" }
       };
        private static readonly Dictionary<int, string> RuProfDict = new Dictionary<int, string>()  //Словарь
       {
                {1, "Торговец" }, {2, "Кузнец" }, {3, "Алхимик" }, {4, "Зачарователь" }, {5, "Рыбак" }, {6, "Охотник" },
                {7, "Шахтер" }, {8, "Повар" }, {9, "Головорез" }
       };
        private static readonly Dictionary<int, string> RuWorldVisDict = new Dictionary<int, string>()  //Словарь
       {
                {1, "Добрый" }, {2, "Нейтральный" }, {3, "Праведный" }, {4, "Законопослушный" }, {5, "Герой" }, {6, "Раздолбай" },
                {7, "Авторитетный бандюган" }, {8, "Эгоистичный" }, {9, "Злой" }
       };
        private static readonly Dictionary<int, string> RuBadHabDict = new Dictionary<int, string>()  //Словарь
       {
                {1, "Накроман" }, {2, "Алкоголик" }, {3, "Клептоматик" }, {4, "Ослабленный" }, {5, "Вор" }, {6, "Шизофренник" },
                {7, "Вампир" }, {8, "Урод" }, {9, "Лжец" }
       };

        public string ChangeHabbit(out string Habbit)
        {
            string rudescription = "";
            string engdescription = "";
            string s = language == "ru" ? "вредную привычку" : "bad habbit";
            switch (Rand(s, 9)) //Упрощённый свитч кейс
            {
                case 1:
                    MyBadHabbit = BadHabbits.Addict;
                    rudescription = "Так как ты наркоман ебанный, ты обязан принимать 1 дозу скумы раз в два дня.";
                    engdescription = "Since you are a fucking addict, you must take 1 dose of skooma every two days.";
                    break;
                case 2:
                    MyBadHabbit = BadHabbits.Alcoholic;
                    rudescription = "Как видишь, браток, ты очередной алкаш с падика. Теперь ты обязан жрать две доп бутылки после принятия пищи.";
                    engdescription = "As you can see, brother, you are another drunk from the entrance. Now you have to eat two extra bottles after eating.";
                    break;
                case 3:
                    MyBadHabbit = BadHabbits.Kleptomaniac;
                    rudescription = "Ты ворюга ебучая! Не можешь себя контролировать и каждую ночь воруешь по 3 вещи с хаты жителей. Осуждаю.";
                    engdescription = "You fucking thief! You cannot control yourself and every night you steal 3 things from the residents' hut. I condemn.";
                    break;
                case 4:
                    MyBadHabbit = BadHabbits.Weakened;
                    rudescription = "М-да, ты ещё и заднеприводный у нас, ведь у тебя диагностировали суровый северный ВИЧ. Теперь ты не можешь излечивать болезни.";
                    engdescription = "Hmmm, you're also a fagot because you've been diagnosed with severe northern HIV. Now you cannot heal diseases.";
                    break;
                case 5:
                    MyBadHabbit = BadHabbits.Criminal;
                    rudescription = "Тебя ищут, в родной город те нельзя, но если ты из лесу то похуй. Узнай каково скайримским бомжам, кочуй как Чингисхан каждый три дня в другой город.";
                    engdescription = "They are looking for you, they cannot go to their hometown, but if you are from the forest then give a fuck. Find out what it is like for the Skyrim bums, roam like Genghis Khan every three days to another city.";
                    break;
                case 6:
                    MyBadHabbit = BadHabbits.Schizophrenic;
                    rudescription = "Ты шизик, поэтому каждые два дня ты обязан менять свою вредную привычку, коль упадёт шиза, роляй снова.";
                    engdescription = "You are a schizo, so every two days you are obliged to change your bad habit, if the schiz falls, roll again.";
                    break;
                case 7:
                    MyBadHabbit = BadHabbits.Vampire;
                    rudescription = "Стань вампирчиком перед началом игры. Не лечись, соси себе спокойно, но не дай никому узнать об этом.";
                    engdescription = "Become a vampire before starting the game. Do not heal, suck yourself calmly, but do not let anyone know about it.";
                    break;
                case 8:
                    MyBadHabbit = BadHabbits.Ugly;
                    rudescription = "У тебя лицо скучное, тебе никто денег не даст. Больше 500 золота носить не можешь.";
                    engdescription = "Your face is boring, no one will give you money. You can't carry more than 500 gold.";
                    break;
                case 9:
                    MyBadHabbit = BadHabbits.Liar;
                    rudescription = "Видимо ты не лжец, а шизик. Так как уже выбрал жертву и переставляешь каждую ночь там предметы. Нахуя? А хуй тебя знает.";
                    engdescription = "Apparently you are not a liar, but a schizo. Since you have already chosen a victim and you rearrange objects there every night. What the fuck? Fuck knows you.";
                    break;
                default:
                    break;
            }
            Habbit = RuBadHabDict[(int)MyBadHabbit];
            if (language == "ru") return rudescription;
            else return engdescription;
        }
        public void CreateCaracter()
        {
            int langkey = language == "ru" ? 0 : 1;
            string[] raceKeyword = new[] { "расу", "race" };
            string[] townKeyword = new[] { "родную локацию", "homeland" };
            string[] profKeyword = new[] { "профессию", "profesion" };
            string[] wvisKeyword = new[] { "мировоззрение", "world vision" };
            Console.ForegroundColor = ConsoleColor.Green;
            if (language == "ru")
            {
                Console.WriteLine("Перед созданием персонажа, расскажу тебе главные правила:\n-Начинаешь на максимальном уровне сложности и не меняешь его.\n-Перезагружать игру нельзя. Твои решения окончательны.\n-У тебя всего одна жизнь. Если умер, удаляешь его.\n-Ты можешь выбрать только одну фрацию.\n");
            }
            else Console.WriteLine("Before creating a character, I'll tell you the main rules:\n-You start at the maximum difficulty level and don't change it. \n-You cannot restart the game. Your decisions are final. \n-You only have one life. \n-You can only choose one facies.\n");

            Console.ForegroundColor = ConsoleColor.Yellow;
            MyRace = Rand(raceKeyword[langkey], 10) switch //Упрощённый свитч кейс
            {
                1 => Race.Argonian,
                2 => Race.Khajiit,
                3 => Race.Orc,
                4 => Race.Altmer,
                5 => Race.Dunmer,
                6 => Race.Bosmer,
                7 => Race.Nord,
                8 => Race.Redguard,
                9 => Race.Breton,
                10 => Race.Imperial,
                _ => Race.Nord
            };
            string ruRace = RuRaceDict[(int)MyRace]; //поиск в словаре, для русской раскладки

            MyTown = Rand(townKeyword[langkey], 9) switch //Упрощённый свитч кейс
            {
                1 => Town.Whiterun,
                2 => Town.Riften,
                3 => Town.Windhelm,
                4 => Town.Winterhold,
                5 => Town.Dawnstar,
                6 => Town.Solitude,
                7 => Town.Morthal,
                8 => Town.Falkreath,
                9 => Town.Forest,
                _ => Town.Whiterun
            };
            string ruTown = RuTownDict[(int)MyTown];


            MyProfecy = Rand(profKeyword[langkey], 9) switch //Упрощённый свитч кейс
            {
                1 => Profession.Dealer,
                2 => Profession.Blacksmith,
                3 => Profession.Alchemist,
                4 => Profession.Enchanter,
                5 => Profession.Fisherman,
                6 => Profession.Hunter,
                7 => Profession.Miner,
                8 => Profession.Chef,
                9 => Profession.Murderer,
                _ => Profession.Dealer,
            };
            string ruProf = RuProfDict[(int)MyProfecy];

            MyWorldVision = Rand(wvisKeyword[langkey], 9) switch //Упрощённый свитч кейс
            {
                1 => WorldVision.Kind,
                2 => WorldVision.Neutral,
                3 => WorldVision.Rightfull,
                4 => WorldVision.Hero,
                5 => WorldVision.Lawful,
                6 => WorldVision.Idiot,
                7 => WorldVision.CriminalInLaw,
                8 => WorldVision.Selfish,
                9 => WorldVision.Evil,
                _ => WorldVision.Kind,
            };
            string ruVision = RuWorldVisDict[(int)MyWorldVision];

            string description = ChangeHabbit(out string ruHabbit);
            if (language == "ru")
            {
                Console.WriteLine($"Запомни, Довакин, теперь ты {ruRace}. Так вышло, что твоя родина - {ruTown}.\nРабота непростая, ведь ты у нас {ruProf}. Как я понял, ты дохуя {ruVision}, что ж, дело твоё. \nВ твоей жизни не всё так просто, у тебя есть хреновая особенность, ты {ruHabbit}!");
                Console.WriteLine($"Расскажу-ка тебе, как с такой особенностью живётся. \n{description}\n\n");
                Console.WriteLine("Вот тебе ещё правила, мотай на ус:\n1)Быстрое перемещение запрещено. Использовать баги/читы/консольку нельзя.\n2)Ездить на лошади разрешено, но только по дорогам.\n3)Ешь три раза в день, твой рацион - 3 блюда и 1 напиток\n4)Спи минимум 7 часов, если недоспал или спал слишком много, то отними или прибавь доп часы к следующему сну.\nСпать можешь только на оборудованных для сна местах.\n5)Ты не можешь носить больше 80 килограмм груза.\n6)Если на улице дождь - надевай головной убор\n7)Твоя сумка вмещает только то, что может в реальности, то есть без огромных предметов внутри.\n8)Cлушай все диалоги в игре без пропусков.\n9)Твоё имя должно подходить твоей расе.\n10)Получай опыт реалистично, без пауэрлевелинга.\n11)Путешествие начинается после того, как ты поспал в родной локации. Игнорируй главный квест.");
            }
            else
            {
                Console.WriteLine($"Remember, Dovahkiin, now you are {MyRace}. It so happened that your homeland is {MyTown}. \nWork is not easy, because you are {MyProfecy}. As I understand, you are fucking {MyWorldVision}, well, it's your business. \nYour life is not so simple, you have a shitty peculiarity, you are {MyBadHabbit}!");
                Console.WriteLine($"I'll tell you how you live with such a feature. \n{description}\n\n");
                Console.WriteLine("Here are some more rules, read and remember: \n1) Fast travel is prohibited. You cannot use bugs / cheats / console. \n2) Riding a horse is allowed, but only on the roads. \n3) Eat three times a day, your diet is 3 meals and 1 drink \n4) Sleep at least 7 hours if you did not sleep enough or slept too much, then take away or add extra hours to the next sleep. \nSleep only in places equipped for sleeping.\n5) You cannot carry more than 80 kilograms of cargo. \n6) If it is raining outside, put on a hat \n7) Your bag only holds what it can in reality, that is, without huge objects inside. \n8) Listen to all the dialogues in play without skipping. \n9) Your name must be suitable for your race. \n10) Experience realistically, without power leveling. \n11) The journey begins after you have slept in your home location. Ignore the main quest.");
            }
        }

        public static int Rand(string param, int count)
        {
            Random random = new Random();
            int r = random.Next(1, count + 2);
            if (r == count + 1)
            {
                string choice = language == "ru" ? $"Выберите {param} самостоятельно, введите число от 1 до {count}, список параметров:" : $"Choose a {param} yourself, enter a number from 1 to {count}, a list of parameters:";
                Console.WriteLine(choice);
                switch (param)
                {

                    case "расу":
                    case "race":
                        for (int i = 1; i <= RuRaceDict.Count; i++)
                        {
                            string rc = $"{(Race)i}";
                            string s = language == "ru" ? RuRaceDict[i] : rc;
                            Console.Write($"{i}. {s}.  ");
                        }
                        break;

                    case "родную локацию":
                    case "homeland":
                        for (int i = 1; i <= RuTownDict.Count; i++)
                        {
                            string town = $"{(Town)i}";
                            string s = language == "ru" ? RuTownDict[i] : town;
                            Console.Write($"{i}. {s}.  ");
                        }
                        break;


                    case "профессию":
                    case "profesion":
                        for (int i = 1; i <= RuProfDict.Count; i++)
                        {
                            string pro = $"{(Profession)i}";
                            string s = language == "ru" ? RuProfDict[i] : pro;
                            Console.Write($"{i}. {s}.  ");
                        }
                        break;



                    case "мировоззрение":
                    case "world vision":
                        for (int i = 1; i <= RuWorldVisDict.Count; i++)
                        {
                            string wv = $"{(WorldVision)i}";
                            string s = language == "ru" ? RuWorldVisDict[i] : wv;
                            Console.Write($"{i}. {s}.  ");
                        }
                        break;



                    default:
                        for (int i = 1; i <= RuBadHabDict.Count; i++)
                        {
                            string bh = $"{(BadHabbits)i}";
                            string s = language == "ru" ? RuBadHabDict[i] : bh;
                            Console.Write($"{i}. {s}.  ");
                        }
                        break;


                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                string answer = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                if ((int.TryParse(answer, out int num)) && (num > 0) && (num < count + 1))
                {
                    if (language == "ru")
                        Console.WriteLine("Принято\n");
                    else Console.WriteLine("Okey\n");
                    r = num;
                }

                else
                {
                    if (language == "ru")
                        Console.WriteLine($"\nРешил наебать меня? Собака, хуй тебе, теперь у тебя не будет шанса выбрать самому {param}.\n");
                    else { Console.WriteLine($"\nDid you fuck with me, dog? Now you won't have a chance to choose {param} yourself. \n"); }
                    r = random.Next(1, count + 1);

                }
            }
            return r;
        }
    }
}
