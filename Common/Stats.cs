namespace LostArkSim.Common
{
    public enum Stats
    {
        // AP stats
        AtkPower,
        WpnPower,
        MainStat,
        FlatAP,
        // Damage related stats
        AddDmg,
        MultDmg,
        SkillDmg,
        AwkDmg,
        EvoDmg,
        // Positional specific multipliers
        BackAtkDmg,
        FrontAtkDmg,
        HeadBackDmg,
        NonPosDmg,
        // Crit stats
        CritRate,
        CritDmg,
        MultCDmg,
        FrontAtkCDmg,
        BackAtkCDmg,
        // Casting speed related
        AtkSpeed,
        ChargeSpeed,
        CastSpeed,
        MoveSpeed,
        DefRed,
        // CDR stats
        CDR1, // legacy from Nightmare 4 Piece, TBD in T4
        CDR2, // legacy from Nightmare 6 Piece, TBD in T4
        SkillCDR,
        AwkCDR,
        // Conditionals
        ChargeDmg,
        CastDmg,
        // Other
        Stagger,
        IdentityGain,
        APBuff,
        BrandPower,
        HealShield,
        LeapPoints
    }
}