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
        //We don't have the proper %'s, just the lines.
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
                            { Rarity.Rare, 0 },
                            { Rarity.Epic, 0 },
                            { Rarity.Legendary, 0 }
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
                            { Rarity.Rare, 0 },
                            { Rarity.Epic, 0 },
                            { Rarity.Legendary, 0 }
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
                            { Rarity.Rare, 0 },
                            { Rarity.Epic, 0 },
                            { Rarity.Legendary, 0 }
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
                            { Rarity.Rare, 0 },
                            { Rarity.Epic, 0 },
                            { Rarity.Legendary, 0 }
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
                            { Rarity.Rare, 0 },
                            { Rarity.Epic, 0 },
                            { Rarity.Legendary, 0 }
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
                            { Rarity.Rare, 0 },
                            { Rarity.Epic, 0 },
                            { Rarity.Legendary, 0 }
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
                            { Rarity.Rare, 0 },
                            { Rarity.Epic, 0 },
                            { Rarity.Legendary, 0 }
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
                            { Rarity.Rare, 0 },
                            { Rarity.Epic, 0 },
                            { Rarity.Legendary, 0 }
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
                            { Rarity.Rare, 0 },
                            { Rarity.Epic, 0 },
                            { Rarity.Legendary, 0 }
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
                            { Rarity.Rare, 0 },
                            { Rarity.Epic, 0 },
                            { Rarity.Legendary, 0 }
                        }
                    }
                },
            };
    }
}
