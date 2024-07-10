using System.Collections.Generic;

public class TranscendenceModels
{
    public static Dictionary<int, int> LvlWeaponBonus { get; } = new()
    {
        { 1, 300 },
        { 2, 340 },
        { 3, 380 },
        { 4, 420 },
        { 5, 460 },
        { 6, 500 },
        { 7, 540 }
    };

    public static Dictionary<int, int> LvlArmorBonus { get; } = new()
    {
        { 1, 600 },
        { 2, 680 },
        { 3, 760 },
        { 4, 840 },
        { 5, 920 },
        { 6, 1000 },
        { 7, 1080 }
    };
}