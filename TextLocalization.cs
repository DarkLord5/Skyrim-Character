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
    }
}
