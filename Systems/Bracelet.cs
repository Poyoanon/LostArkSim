using System;
using System.Collections.Generic;
using System.Linq;
using BraceletModels;

public class Bracelet
{
    public int Crit { get; set; }
    public int Swift { get; set; }
    public int Spec { get; set; }
    public int MainStat { get; set; }
    public required Dictionary<string, int> Effects { get; set; }
    

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
        var results = Effects.Select(e => BraceletOptions.Options[e.Key].Modifiers[(Rarity)e.Value]);
        if (mode == 0)
            return results.Sum();
        else
            return results.Aggregate(1.0, (x, y) => x * (y + 1));
    }
}