using System.Collections.Generic;
using LostArkSim.Common;

namespace AccessoryPolishModels
{
    //FYI, this model is for TIER 4 accessories only.
    public record AccessoryStats
    {
        public Stats EvoPoint { get; set;} = new Stats();
        public Stats Stat { get; set; } = new Stats();
        public Accessories Accessory { get; set;} = new Accessories();
        public required Dictionary<Rarity, double> UniqueRolls { get; set; }
    }

    public static class AccessoryRolls
    {
        public static Dictionary<string, AccessoryStats> Rolls { get; } =
            new()
            {
                {
                    "Additional Damage",
                    new AccessoryStats
                    {
                        Accessory = Accessories.Necklace,
                        Stat = Stats.AddDmg,
                        EvoPoint = Stats.EvoPoints,
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
                        Accessory = Accessories.Necklace,
                        Stat = Stats.MultDmg,
                        EvoPoint = Stats.EvoPoints,
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
                        Accessory = Accessories.Necklace,
                        Stat = Stats.IdentityGain,
                        EvoPoint = Stats.EvoPoints,
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
                        Accessory = Accessories.Necklace,
                        Stat = Stats.BrandPower,
                        EvoPoint = Stats.EvoPoints,
                        UniqueRolls = new Dictionary<Rarity, double>
                        {
                            { Rarity.Rare, 2.15 },
                            { Rarity.Epic, 4.80 },
                            { Rarity.Legendary, 8.00 }
                        }
                    }
                },

                {
                    "Attack Power",
                    new AccessoryStats
                    {
                        Accessory = Accessories.Necklace,
                        Stat = Stats.AtkPower,
                        EvoPoint = Stats.EvoPoints,
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
                        Accessory = Accessories.Necklace,
                        Stat = Stats.WpnPower,
                        EvoPoint = Stats.EvoPoints,
                        UniqueRolls = new Dictionary<Rarity, double>
                        {
                            { Rarity.Rare, 195 },
                            { Rarity.Epic, 480 },
                            { Rarity.Legendary, 960 }
                        }
                    }
                }
            };
    }
}
