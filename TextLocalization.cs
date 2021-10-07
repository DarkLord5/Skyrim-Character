using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace SkyrimPlayer
{
    
    class TextLocalization
    {
        public static readonly string english = "english";
        public static readonly string russian = "russian";
        string language { get; set; }
        readonly Dictionary<int, string> Text;
        internal TextLocalization(string lang)
        {
            string json = "";
            language = lang;
            if (language == english)
            {
                using StreamReader sr = new StreamReader(@"public\translations\EngOutText.json");
                json = sr.ReadToEnd();
                sr.Close();
            }
            else if(language == russian)
            {
                using StreamReader sr = new StreamReader(@"public\translations\RuOutText.json");
                json = sr.ReadToEnd();
                sr.Close();
            }
            Text = JsonConvert.DeserializeObject<Dictionary<int, string>>(json);
        }

        internal string Begining()
        {
            return Text[1];
        }

        internal string PlayerChoice(string param, int count)
        {
            string result = Text[2];
            result = result.Replace("{1}", param);
            result = result.Replace("{2}", count.ToString());
            return result;
        }

        internal string GoodProgrammAnswer()
        {
            return Text[3];
        }

        internal string WrongProgrammAnswer(string param)
        {
            string result = Text[4];
            result = result.Replace("{1}", param);
            return result;
        }


        internal string Ending(Dictionary<string, Dictionary<int, string>> LangDict, Dictionary<int, int> res)
        {
            string result = Text[5];
            result = result.Replace("{1}", LangDict["race"][res[1]]);
            result = result.Replace("{2}", LangDict["homeland"][res[2]]);
            result = result.Replace("{3}", LangDict["profesion"][res[3]]);
            result = result.Replace("{4}", LangDict["world wision"][res[4]]);
            result = result.Replace("{5}", LangDict["bad habbit"][res[5]]);
            result = result.Replace("{6}", LangDict["habbit discription"][res[5]]);
            return result;
        }


    }
}
