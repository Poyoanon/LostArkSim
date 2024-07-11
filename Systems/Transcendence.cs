using System;
using System.Collections.Generic;
using System.Linq;
using LostArkSim.Common;

public class Transcendence
{
    private Dictionary<GearType, int> Levels;
    private Dictionary<GearType, int> Grade;

    public Transcendence()
    {
        Levels = new Dictionary<GearType, int>();
        Grade = new Dictionary<GearType, int>();

        foreach (var piece in Enum.GetValues(typeof(GearType)))
        {
            Levels[(GearType)piece] = 0;
            Grade[(GearType)piece] = 0;
        }
    }

    public void SetLevel(GearType piece, int lvl)
    {
        Levels[piece] = Math.Min(7, lvl);
    }

    public void SetGrade(GearType piece, int grade)
    {
        Levels[piece] = Math.Min(Levels[piece] * 3, grade);
    }

    public int LvlMainStat()
    {
        return Levels.Values.Select(level => TranscendenceModels.LvlArmorBonus[level]).Sum();
    }

    public int LvlWeaponPower()
    {
        return Levels
            .Values.Where(level => level == (int)GearType.Weapon)
            .Select(level => TranscendenceModels.LvlWeaponBonus[level])
            .Sum();
    }

    public int TotalGrade
    {
        get { return Grade.Values.Sum(); }
    }

    public float StatsFlat(GearType piece, List<int> grades, List<float> values)
    {
        if (grades.Count != values.Count)
            return 0;

        return values.Select((value, index) => Grade[piece] >= grades[index] ? value : 0).Sum();
    }

    public float StatsScale(GearType piece, object grades, float value)
    {
        if (grades is int)
        {
            return Grade[piece] >= (int)grades ? value * TotalGrade : 0;
        }
        else if (grades is List<int>)
        {
            return ((IList<int>)grades)
                .Cast<int>()
                .Select((grade, index) => Grade[piece] >= grade ? value * TotalGrade : 0)
                .Sum();
        }
        return 0;
    }

    public float MainStat
    {
        get
        {
            float helmet = StatsScale(GearType.Helmet, 10, 55f);
            float gloves = StatsFlat(
                GearType.Gloves,
                new List<int> { 5, 15, 20 },
                new List<float> { 4200f, 4200f, 4200f }
            );
            int levels = LvlMainStat();
            return helmet + gloves + levels;
        }
    }

    public float WpnPower
    {
        get
        {
            float helmet = StatsScale(GearType.Helmet, 15, 14f);
            float shoulder = StatsFlat(
                GearType.Shoulder,
                new List<int> { 5, 15, 20 },
                new List<float> { 1200f, 1200f, 1200f }
            );
            float chest = StatsFlat(
                GearType.Chest,
                new List<int> { 5, 15, 20 },
                new List<float> { 2000f, 2000f, 3200f }
            );
            int levels = LvlWeaponPower();
            return helmet + shoulder + chest + levels;
        }
    }

    public float FlatAP
    {
        get
        {
            float helmet = StatsScale(GearType.Helmet, 20, 6f);
            float weapon = StatsFlat(
                GearType.Weapon,
                new List<int> { 5, 10, 15, 20 },
                new List<float> { 800f, 800f, 800f, 1125f }
            );
            return helmet + weapon;
        }
    }

    public float BuffAP
    {
        get
        {
            float helmet = StatsScale(GearType.Helmet, new List<int> { 5, 10, 15, 20 }, 0.0001f);
            float shoulder = StatsScale(GearType.Shoulder, new List<int> { 5, 15, 20 }, 0.01f);
            float gloves = StatsScale(GearType.Gloves, new List<int> { 5, 15, 20 }, 0.01f);
            float pants = StatsFlat(
                GearType.Pants,
                new List<int> { 10, 15, 20 },
                new List<float> { 0.015f, 0.015f, 0.03f }
            );
            return helmet + shoulder + gloves + pants;
        }
    }

    public bool Intimidation
    {
        get { return Grade[GearType.Pants] >= 20; }
    }

    public long Successor
    {
        get
        {
            if (Grade[GearType.Pants] >= 20)
                return 1_400_000_000;
            else if (Grade[GearType.Pants] >= 15)
                return 70_000_000_000;
            return 0;
        }
    }

    public float BrandPower
    {
        get
        {
            return StatsFlat(
                GearType.Weapon,
                new List<int> { 5, 10, 15, 20 },
                new List<float> { 0.02f, 0.02f, 0.02f, 0.04f }
            );
        }
    }
}
