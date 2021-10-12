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
        public string TempBadHabbit { get; set; }

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
            int raceId = array[0]; int townId = array[1]; int profId = array[2]; int worldId = array[3]; int bhId = array[4];
            MyRace = RaceDict[raceId];
            MyTown = TownDict[townId];
            MyProfecy = ProfDict[profId];
            MyWorldVision = WorldVisDict[worldId];
            MyBadHabbit = BadHabDict[bhId];
            return new Dictionary<int, int>() { {1 , raceId },{2 , townId },{3 , profId },{4, worldId },{5 , bhId } };
        }
    }
}