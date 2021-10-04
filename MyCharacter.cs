using System;
using System.Collections.Generic;

namespace SkyrimPlayer
{
    class MyCharacter
    {
        public string MyRace { get; set; }
        public string MyTown { get; set; }
        public string MyProfecy { get; set; }
        public string MyWorldVision { get; set; }
        public string MyBadHabbit { get; set; }

        static Dictionary<int, string> RaceDict = new()
        {
                {1, "Argonian" }, {2, "Khajiit" }, {3, "Orc" }, {4, "Altmer" }, {5, "Dunmer" }, {6, "Bosmer" },
                {7, "Nord" }, {8, "Redguard" }, {9, "Breton" }, {10, "Imperial" }
        };

        static Dictionary<int, string> TownDict = new()
        {
                {1, "Whiterun" }, {2, "Riften" }, {3, "Windhelm" }, {4, "Winterhold" }, {5, "Dawnstar" }, {6, "Solitude" },
                {7, "Morthal" }, {8, "Falkreath" }, {9, "Forest" }
        };
        static Dictionary<int, string> ProfDict = new()
        {
                {1, "Dealer" }, {2, "Blacksmith" }, {3, "Alchemist" }, {4, "Enchanter" }, {5, "Fisherman" }, {6, "Hunter" },
                {7, "Miner" }, {8, "Chef" }, {9, "Murderer" }
        };
        static Dictionary<int, string> WorldVisDict = new() 
        {
                {1, "Kind" }, {2, "Neutral" }, {3, "Rightfull" }, {4, "Lawful" }, {5, "Hero" }, {6, "Idiot" },
                {7, "CriminalInLaw" }, {8, "Selfish" }, {9, "Evil" }
        };
        static Dictionary<int, string> BadHabDict = new() 
        {
                {1, "Addict" }, {2, "Alcoholic" }, {3, "Kleptomaniac" }, {4, "Weakened" }, {5, "Criminal" }, {6, "Schizophrenic" },
                {7, "Vampire" }, {8, "Ugly" }, {9, "Liar" }
        };
        public int ParamRandomizer(int min, int max)
        {
            Random random = new();
            return random.Next(min, max);
        }
        public Dictionary<int, int> CreateCharacter(int[] array)
        {
            MyRace = RaceDict[array[0]];
            MyTown = TownDict[array[1]];
            MyProfecy = ProfDict[array[2]];
            MyWorldVision = WorldVisDict[array[3]];
            MyBadHabbit = BadHabDict[array[4]];
            return new Dictionary<int, int>() { {1 , array[0] },{2 , array[1] },{3 , array[2] },{4, array[3] },{5 , array[4] } };
        }
    }
}