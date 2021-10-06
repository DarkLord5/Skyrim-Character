using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyrimPlayer
{
    
    class TextLocalization
    {
       internal TextLocalization(string lang)
        {
            language = lang;
        } 
        const string english = "english";
        const string russian = "russian";
        string language { get; set; }
        internal string Begining()
        {
            string result = "";
            if (language == english)
            {
                result = "Before creating a character, I'll tell you the main rules:\n-You start at the maximum difficulty level and don't change it. \n-You cannot restart the game. Your decisions are final. \n-You only have one life. \n-You can only choose one facies.\n";
            }else if(language== russian)
            {
                result = "Перед созданием персонажа, расскажу тебе главные правила:\n-Начинаешь на максимальном уровне сложности и не меняешь его.\n-Перезагружать игру нельзя. Твои решения окончательны.\n-У тебя всего одна жизнь. Если умер, удаляешь его.\n-Ты можешь выбрать только одну фрацию.\n";
            }
            return result;
        }

        internal string PlayerChoice(string param, int count)
        {
            string result = "";
            if (language == english)
            {
                result = $"Выберите {param} самостоятельно, введите число от 1 до {count}. Список параметров:";
            }
            else if (language == russian)
            {
                result = $"Choose {param} yourself, put the number from 1 to {count}. List of properties:";
            }
            return result;
        }

        internal string GoodProgrammAnswer()
        {
            string result = "";
            if (language == english)
            {
                result = "Okay";
            }
            else if (language == russian)
            {
                result = "Принято";
            }
            return result;
        }

        internal string WrongProgrammAnswer(string param)
        {
            string result = "";
            if (language == english)
            {
                result = $"\nHave you just tried to cheat on me? Now you won't have a chance to choose {param} yourself. \n";
            }
            else if (language == russian)
            {
                result = $"\nРешил обмануть меня? Теперь у тебя не будет шанса выбрать самому {param}.\n";
            }
            return result;
        }


        internal string Ending(Dictionary<string, Dictionary<int, string>> LangDict, Dictionary<int, int> res)
        {
            string result = "";
            if (language == english)
            {
                result = $"Remember, Dovahkiin, now you are {LangDict["race"][res[1]]}. It so happened that your homeland is {LangDict["homeland"][res[2]]}. " +
                    $"\nWork is not easy, because you are {LangDict["profesion"][res[3]]}. As I understand, you are {LangDict["world wision"][res[4]]}, well, it's your business. " +
                    $"\nYour life is not so simple, you have a unpleasant peculiarity, you are {LangDict["bad habbit"][res[5]]}!" +
                    $"\nI'll tell you how you live with such a feature. \n{LangDict["habbit discription"][res[5]]}\n" +
                    "\nHere are some more rules, read and remember: \n1) Fast travel is prohibited. You cannot use bugs / cheats / console. " +
                    "\n2) Riding a horse is allowed, but only on the roads. \n3) Eat three times a day, your diet is 3 meals and 1 drink " +
                    "\n4) Sleep at least 7 hours if you did not sleep enough or slept too much, then take away or add extra hours to the next sleep. " +
                    "\nSleep only in places equipped for sleeping.\n5) You cannot carry more than 80 kilograms of cargo. \n6) If it is raining outside, put on a hat " +
                    "\n7) Your bag only holds what it can in reality, that is, without huge objects inside. \n8) Listen to all the dialogues in play without skipping. " +
                    "\n9) Your name must be suitable for your race. \n10) Experience realistically, without power leveling. " +
                    "\n11) The journey begins after you have slept in your home location. Ignore the main quest.";
            }
            else if (language == russian)
            {
                result = $"Запомни, Довакин, теперь ты {LangDict["race"][res[1]]}. Так вышло, что твоя родина - {LangDict["homeland"][res[2]]}." +
                     $"\nРабота непростая, ведь ты у нас {LangDict["profesion"][res[3]]}. Как я понял, ты {LangDict["world wision"][res[4]]}, что ж, твои взгляды - твоё дело. " +
                     $"\nВ твоей жизни не всё так просто, у тебя есть неприятная особенность, ты {LangDict["bad habbit"][res[5]]}!" +
                     $"\nРасскажу-ка тебе, как с такой особенностью живётся. \n{LangDict["habbit discription"][res[5]]}\n" +
                     "\nВот тебе ещё правила, мотай на ус:\n1)Быстрое перемещение запрещено. Использовать баги/читы/консольку нельзя." +
                     "\n2)Ездить на лошади разрешено, но только по дорогам.\n3)Ешь три раза в день, твой рацион - 3 блюда и 1 напиток" +
                     "\n4)Спи минимум 7 часов, если недоспал или спал слишком много, то отними или прибавь доп часы к следующему сну." +
                     "\nСпать можешь только на оборудованных для сна местах.\n5)Ты не можешь носить больше 80 килограмм груза.\n6)Если на улице дождь - надевай головной убор." +
                     "\n7)Твоя сумка вмещает только то, что может в реальности, то есть без огромных предметов внутри.\n8)Cлушай все диалоги в игре без пропусков." +
                     "\n9)Твоё имя должно подходить твоей расе.\n10)Получай опыт реалистично, без пауэрлевелинга." +
                     "\n11)Путешествие начинается после того, как ты поспал в родной локации. Игнорируй главный квест.";
            }
            return result;
        }


    }
}
