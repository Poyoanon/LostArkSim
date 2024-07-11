using System.Collections.Generic;
using LostArkSim.Common;

namespace AccessoryPolishModels
{
    //FYI, this model is for TIER 4 accessories only.
    public record AccessoryStats
    {
        //Needs to init with Leap Points at the very least, stats should probably be consolidated into one input rather than have the user look through several pages just to find how much main stat they have.
        public int LeapPoints { get; set; }
        public required Dictionary<Rarity, double> UniqueRolls { get; set; }
    }

    public static class AccessoryRolls
    {
        //Refer to https://lostark.game.onstove.com/Probability/%EC%9E%A5%EC%8B%A0%EA%B5%AC%20%EC%97%B0%EB%A7%88
        public static Dictionary<string, AccessoryStats> Rolls { get; } =
            new()
            {
                //We need to translate these names from KR. Also, stats from enums should be added but are omitted here.
                {
                    "Additional Damage",
                    new AccessoryStats
                    {
                        LeapPoints = (int)Stats.LeapPoints,
                        UniqueRolls = new Dictionary<Rarity, double>
                        {
                            { Rarity.Rare, 0.70 },
                            { Rarity.Epic, 1.60 },
                            { Rarity.Legendary, 2.60 }
                        }
                    }
                },
                {
                    "Damage to Enemies",
                    new AccessoryStats
                    {
                        LeapPoints = (int)Stats.LeapPoints,
                        UniqueRolls = new Dictionary<Rarity, double>
                        {
                            { Rarity.Rare, 0.55 },
                            { Rarity.Epic, 1.20 },
                            { Rarity.Legendary, 2.00 }
                        }
                    }
                },
                {
                    "Support Identity Gauge",
                    new AccessoryStats
                    {
                        LeapPoints = (int)Stats.LeapPoints,
                        UniqueRolls = new Dictionary<Rarity, double>
                        {
                            { Rarity.Rare, 1.60 },
                            { Rarity.Epic, 3.60 },
                            { Rarity.Legendary, 6.00 }
                        }
                    }
                },
                {
                    "Brand Power",
                    new AccessoryStats
                    {
                        LeapPoints = (int)Stats.LeapPoints,
                        UniqueRolls = new Dictionary<Rarity, double>
                        {
                            { Rarity.Rare, 2.15 },
                            { Rarity.Epic, 4.80 },
                            { Rarity.Legendary, 8.00 }
                        }
                    }
                },
                {
                    "Vitality",
                    new AccessoryStats
                    {
                        LeapPoints = (int)Stats.LeapPoints,
                        UniqueRolls = new Dictionary<Rarity, double>
                        {
                            { Rarity.Rare, 1300 },
                            { Rarity.Epic, 3250 },
                            { Rarity.Legendary, 6500 }
                        }
                    }
                },
                {
                    "Attack Power",
                    new AccessoryStats
                    {
                        LeapPoints = (int)Stats.LeapPoints,
                        UniqueRolls = new Dictionary<Rarity, double>
                        {
                            { Rarity.Rare, 80 },
                            { Rarity.Epic, 195 },
                            { Rarity.Legendary, 390 }
                        }
                    }
                },
                {
                    "Weapon Power",
                    new AccessoryStats
                    {
                        LeapPoints = (int)Stats.LeapPoints,
                        UniqueRolls = new Dictionary<Rarity, double>
                        {
                            { Rarity.Rare, 195 },
                            { Rarity.Epic, 480 },
                            { Rarity.Legendary, 960 }
                        }
                    }
                },
                {
                    "Mana",
                    new AccessoryStats
                    {
                        LeapPoints = (int)Stats.LeapPoints,
                        UniqueRolls = new Dictionary<Rarity, double>
                        {
                            { Rarity.Rare, 6 },
                            { Rarity.Epic, 15 },
                            { Rarity.Legendary, 30 }
                        }
                    }
                },
                {
                    "Abnormal Status Attack Duration",
                    new AccessoryStats
                    {
                        LeapPoints = (int)Stats.LeapPoints,
                        UniqueRolls = new Dictionary<Rarity, double>
                        {
                            { Rarity.Rare, 0.20 },
                            { Rarity.Epic, 0.50 },
                            { Rarity.Legendary, 1.00 }
                        }
                    }
                },
                {
                    "Health Recovery",
                    new AccessoryStats
                    {
                        LeapPoints = (int)Stats.LeapPoints,
                        UniqueRolls = new Dictionary<Rarity, double>
                        {
                            { Rarity.Rare, 10 },
                            { Rarity.Epic, 25 },
                            { Rarity.Legendary, 50 }
                        }
                    }
                },
            };
    }
}
