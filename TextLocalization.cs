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
            string filepath = "";
            language = lang;
            if (language == english)
            {
                filepath = @"public\translations\EngText.json";
            }
            else if(language == russian)
            {
                filepath = @"public\translations\RuText.json";
            }
            using StreamReader sr = new(filepath);
            string json = sr.ReadToEnd();
            sr.Close();
            Dictionary<string, Dictionary<int, string>> LangDict = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<int, string>>>(json);
            Text = LangDict["textout"];
        }

        internal string JustText(int code)
        {
            return Text[code];
        }

        internal string TextWithParam(string param, int code)
        {
            string result = JustText(code);
            do
            {
              result = result.Replace("{param}", param);
            } while (result.Contains("{param}"));
            return result;
        }

        internal string TextWithParamCount(string param, int count, int code)
        {
            string result = TextWithParam(param, code);
            do
            {
                result = result.Replace("{count}", count.ToString());
            } while (result.Contains("{count}"));
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
