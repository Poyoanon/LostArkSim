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
        EvoPoints, 
        //for general Evolution tree, you can only get these from armor and 1 per level totalling to +20
        //Relic
        //Helmet, Chest, Bottom, Shoulder, Armor, Glove each +8 totalling to +40
        //Ancient
        //Helmet, Chest, Bottom, Shoulder, Armor, Glove each +20 totalling to +100
        EnlightenPoints, 
        //for class-specific Enlightenment tree, you can get these from accessories, 
        //Relic
        //2-4 for neck(8-10 polished)
        //1-3 for earrings (7-9 polished)
        //1-3 for ring (7-9 polished)
        //Ancient
        //Necklace (11-13 polished)
        //Earrings (10-12 polished)
        //Ring (10-12 polished)
        LeapPoints // t4 bracelet points
    }
}