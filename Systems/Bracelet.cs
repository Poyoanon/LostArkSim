using System;
using System.Collections.Generic;
using System.Linq;

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

public class BraceletOption
{
    public Stats Stat { get; set; }
    public required Dictionary<Rarity, double> Modifiers { get; set; }
}

public class Bracelet
{
    public int Crit { get; set; }
    public int Swift { get; set; }
    public int Spec { get; set; }
    public int MainStat { get; set; }
    public required Dictionary<string, int> Effects { get; set; }

    private static readonly Dictionary<string, BraceletOption> BraceletOptions = new Dictionary<string, BraceletOption>
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

    public void ChangeStat(string statName, int value)
    {
        switch (statName)
        {
            case "Crit":
                Crit = Math.Max(0, Math.Min(120, value));
                break;
            case "Spec":
                Spec = Math.Max(0, Math.Min(120, value));
                break;
            case "Swift":
                Swift = Math.Max(0, Math.Min(120, value));
                break;
            case "MainStat":
                MainStat = Math.Max(0, Math.Min(5000, value));
                break;
            default:
                throw new ArgumentException("Invalid stat name", nameof(statName));
        }
    }

    public void ChangeEffect(string oldEffect, string newEffect)
    {
        if (Effects.ContainsKey(oldEffect))
        {
            Effects[newEffect] = Effects[oldEffect];
            Effects.Remove(oldEffect);
        }
        double HammerWedgeModifier = Effects.ContainsKey("Hammer") && Effects.ContainsKey("Wedge") ? 2 * 8 / 14 : 1.00;
        double FervorCoolHeadedModifier = Effects.ContainsKey("Fervor") && Effects.ContainsKey("CoolHeaded") ? 1.01 : 1.00;
    }

    public void ChangeLevel(string effect, int level)
    {
        Effects[effect] = level;
    }

    public double GetMod(Stats mod, int mode)
    {
        var results = Effects.Select(e => BraceletOptions[e.Key].Modifiers[(Rarity)e.Value]);
        if (mode == 0)
            return results.Sum();
        else
            return results.Aggregate(1.0, (x, y) => x * (y + 1));
    }
}