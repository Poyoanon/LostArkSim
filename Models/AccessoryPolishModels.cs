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
                    "추가 피해 %",
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
                    "적에게 주는 피해 %",
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
                    "세레나데, 신앙, 조화 게이지 획득량 %",
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
                    "낙인력 %",
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
                    "최대 생명력 +",
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
                    "공격력 +",
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
                    "무기 공격력 +",
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
                    "최대 마나 +",
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
                    "상태이상 공격 지속시간 %",
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
                    "전투 중 생명력 회복량 +",
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
