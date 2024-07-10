using System;
using System.Collections.Generic;
using System.Linq;
using BraceletModels;
using LostArkSim.Common;

public class Bracelet
{
    public enum BraceletTier
    {
        T3,
        T4
    }
    public int Crit { get; set; }
    public int Swift { get; set; }
    public int Spec { get; set; }
    public int MainStat { get; set; }
    // need to differentiate between T3 and T4 Bracelets to limit effect rarities and Ark Passive; ie T3 cannot have Relic effects and Leap Points
    public BraceletTier Tier { get; set; }  // T3 Bracelet -> cannot use Relic effects, cannot have LeapPoints; cannot set this to T4 if Char iLvl < 1640
    public int LeapPoints { get; set; } // setter will set this to 0 automatically if Bracelet.Tier == 0
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