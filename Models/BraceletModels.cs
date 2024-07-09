using System.Collections.Generic;

namespace BraceletModels
{
    public enum Rarity
    {
        Common,
        Rare,
        Epic,
        Legendary
    }

    public enum Stats
    {
        AddDmg,
        CritDmg,
        MultDmg,
        DefRed,
        CritRate,
        WpnPower,
        BackAtkDmg,
        FrontAtkDmg,
        IdentityGain
    }

    public record BraceletOption
    {
        public Stats Stat { get; init; }
        public required Dictionary<Rarity, double> Modifiers { get; init; }
    }

    public static class BraceletOptions
    {
        public static readonly Dictionary<string, BraceletOption> Options = new Dictionary<string, BraceletOption>
        {
            {
                "Wedge",
                new BraceletOption
                {
                    Stat = Stats.AddDmg,
                    Modifiers = new Dictionary<Rarity, double>
                    {
                        { Rarity.Common, 0.0163 },
                        { Rarity.Rare, 0.019 },
                        { Rarity.Epic, 0.0244 },
                        { Rarity.Legendary, 0.0271 }
                    }
                }
            },
            {
                "Hammer",
                new BraceletOption
                {
                    Stat = Stats.CritDmg,
                    Modifiers = new Dictionary<Rarity, double>
                    {
                        { Rarity.Common, 0.06 },
                        { Rarity.Rare, 0.08 },
                        { Rarity.Epic, 0.1 },
                        { Rarity.Legendary, 0.12 }
                    }
                }
            },
            {
                "Fervor",
                new BraceletOption
                {
                    Stat = Stats.MultDmg,
                    Modifiers = new Dictionary<Rarity, double>
                    {
                        { Rarity.Common, 0.025 },
                        { Rarity.Rare, 0.03 },
                        { Rarity.Epic, 0.035 },
                        { Rarity.Legendary, 0.04 }
                    }
                }
            },
            {
                "CoolHeaded",
                new BraceletOption
                {
                    Stat = Stats.MultDmg,
                    Modifiers = new Dictionary<Rarity, double>
                    {
                        { Rarity.Common, 0.025 },
                        { Rarity.Rare, 0.03 },
                        { Rarity.Epic, 0.035 },
                        { Rarity.Legendary, 0.04 }
                    }
                }
            },
            {
                "Dagger",
                new BraceletOption
                {
                    Stat = Stats.DefRed,
                    Modifiers = new Dictionary<Rarity, double>
                    {
                        { Rarity.Common, 0.015 },
                        { Rarity.Rare, 0.018 },
                        { Rarity.Epic, 0.021 },
                        { Rarity.Legendary, 0.025 }
                    }
                }
            },
            {
                "ExposeWeakness",
                new BraceletOption
                {
                    Stat = Stats.CritRate,
                    Modifiers = new Dictionary<Rarity, double>
                    {
                        { Rarity.Common, 0.015 },
                        { Rarity.Rare, 0.018 },
                        { Rarity.Epic, 0.021 },
                        { Rarity.Legendary, 0.025 }
                    }
                }
            },
            {
                "WeaponPower",
                new BraceletOption
                {
                    Stat = Stats.WpnPower,
                    Modifiers = new Dictionary<Rarity, double>
                    {
                        { Rarity.Common, 1300 },
                        { Rarity.Rare, 1600 },
                        { Rarity.Epic, 1900 },
                        { Rarity.Legendary, 2200 }
                    }
                }
            },
            {
                "Superiority",
                new BraceletOption
                {
                    Stat = Stats.MultDmg,
                    Modifiers = new Dictionary<Rarity, double>
                    {
                        { Rarity.Common, 0.015 },
                        { Rarity.Rare, 0.02 },
                        { Rarity.Epic, 0.025 },
                        { Rarity.Legendary, 0.03 }
                    }
                }
            },
            {
                "Assail",
                new BraceletOption
                {
                    Stat = Stats.CritDmg,
                    Modifiers = new Dictionary<Rarity, double>
                    {
                        { Rarity.Common, 0.04 },
                        { Rarity.Rare, 0.06 },
                        { Rarity.Epic, 0.08 },
                        { Rarity.Legendary, 0.1 }
                    }
                }
            },
            {
                "Precise",
                new BraceletOption
                {
                    Stat = Stats.CritRate,
                    Modifiers = new Dictionary<Rarity, double>
                    {
                        { Rarity.Common, 0.02 },
                        { Rarity.Rare, 0.03 },
                        { Rarity.Epic, 0.04 },
                        { Rarity.Legendary, 0.05 }
                    }
                }
            },
            {
                "Ambush",
                new BraceletOption
                {
                    Stat = Stats.BackAtkDmg,
                    Modifiers = new Dictionary<Rarity, double>
                    {
                        { Rarity.Common, 0.025 },
                        { Rarity.Rare, 0.03 },
                        { Rarity.Epic, 0.035 },
                        { Rarity.Legendary, 0.04 }
                    }
                }
            },
            {
                "Battle",
                new BraceletOption
                {
                    Stat = Stats.FrontAtkDmg,
                    Modifiers = new Dictionary<Rarity, double>
                    {
                        { Rarity.Common, 0.025 },
                        { Rarity.Rare, 0.03 },
                        { Rarity.Epic, 0.035 },
                        { Rarity.Legendary, 0.04 }
                    }
                }
            },
            {
                "Sawtooth",
                new BraceletOption
                {
                    Stat = Stats.CritDmg,
                    Modifiers = new Dictionary<Rarity, double>
                    {
                        { Rarity.Common, 0.02 },
                        { Rarity.Rare, 0.03 },
                        { Rarity.Epic, 0.05 },
                        { Rarity.Legendary, 0.07 }
                    }
                }
            },
        };
    }
}