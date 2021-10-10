using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace SkyrimPlayer
{
    
    class TextLocalization
    {
        public static readonly string english = "english";
        public static readonly string russian = "russian";
        public static readonly string ruFilePath = @"public\translations\RuText.json";
        public static readonly string engFilePath = @"public\translations\EngText.json";
        internal Dictionary<string, Dictionary<int, string>> LangDict;
        string Language { get; set; }
        readonly Dictionary<int, string> Text;
        internal TextLocalization(string lang, string filepath)
        {
            Language = lang;
            using StreamReader sr = new(filepath);
            string json = sr.ReadToEnd();
            sr.Close();
            LangDict = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<int, string>>>(json);
            Text = LangDict["textout"];
        }

        internal string TextOut(int code)
        {
            return Text[code];
        }

        internal string TextOut(string param, int code)
        {
            string result = TextOut(code);
            do
            {
              result = result.Replace("{param}", param);
            } while (result.Contains("{param}"));
            return result;
        }

        internal string TextOut(string param, int count, int code)
        {
            string result = TextOut(param, code);
            do
            {
                result = result.Replace("{count}", count.ToString());
            } while (result.Contains("{count}"));
            return result;
        }
        internal string TextOut(Dictionary<string, Dictionary<int, string>> LangDict, Dictionary<int, int> res, int code)
        {
            string result = TextOut(code);
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
