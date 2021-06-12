﻿using System.Collections.Generic;
using low_age_data.Common;
using low_age_data.Domain.Abilities;
using low_age_data.Domain.Entities.Actors.Units;
using low_age_data.Domain.Shared;

namespace low_age_data.Collections
{
    public static class Units
    {
        public static List<Unit> Get()
        {
            return new List<Unit>
            {
                new Unit(
                    UnitName.Slave,
                    nameof(UnitName.Slave),
                    "",
                    new List<Stat>
                    {
                        new CombatStat(6, true, Stats.Health),
                        new CombatStat(0, false, Stats.MeleeArmour),
                        new CombatStat(0, false, Stats.RangedArmour),
                        new CombatStat(5, true, Stats.Movement),
                        new CombatStat(20, false, Stats.Initiative),
                        new AttackStat(
                            1, 
                            Attacks.Melee, 
                            1, 
                            1)
                    },
                    Factions.Revelators,
                    new List<CombatAttributes>
                    {
                        CombatAttributes.Light,
                        CombatAttributes.Biological
                    },
                    new List<AbilityName>
                    {
                        AbilityName.Slave.Build,
                        AbilityName.Slave.Repair,
                        AbilityName.Slave.ManualLabour
                    }),

                new Unit(
                    UnitName.Leader,
                    nameof(UnitName.Leader),
                    "",
                    new List<Stat>
                    {
                        new CombatStat(50, true, Stats.Health),
                        new CombatStat(1, false, Stats.MeleeArmour),
                        new CombatStat(5, false, Stats.RangedArmour),
                        new CombatStat(3, true, Stats.Movement),
                        new CombatStat(28, false, Stats.Initiative),
                        new AttackStat(
                            5, 
                            Attacks.Melee, 
                            1, 
                            2, 
                            CombatAttributes.Biological, 
                            7)
                    },
                    Factions.Revelators,
                    new List<CombatAttributes>
                    {
                        CombatAttributes.Armoured,
                        CombatAttributes.Celestial
                    },
                    new List<AbilityName>
                    {
                        AbilityName.Leader.AllForOne,
                        AbilityName.Leader.MenacingPresence,
                        AbilityName.Leader.OneForAll
                    }),

                new Unit(
                    UnitName.Quickdraw,
                    nameof(UnitName.Quickdraw),
                    "",
                    new List<Stat>
                    {
                        new CombatStat(13, true, Stats.Health),
                        new CombatStat(1, false, Stats.MeleeArmour),
                        new CombatStat(0, false, Stats.RangedArmour),
                        new CombatStat(4, true, Stats.Movement),
                        new CombatStat(18, false, Stats.Initiative),
                        new AttackStat(
                            1,
                            Attacks.Melee,
                            1,
                            1),
                        new AttackStat(
                            3,
                            Attacks.Ranged, 
                            2,
                            6,
                            CombatAttributes.Light,
                            2)
                    },
                    Factions.Revelators, 
                    new List<CombatAttributes>
                    {
                        CombatAttributes.Light,
                        CombatAttributes.Biological,
                        CombatAttributes.Ranged
                    },
                    new List<AbilityName>
                    {
                        AbilityName.Quickdraw.Doubleshot,
                        AbilityName.Quickdraw.Cripple
                    }),

                new Unit(
                    UnitName.Gorger,
                    nameof(UnitName.Gorger),
                    "",
                    new List<Stat>
                    {
                        new CombatStat(7, true, Stats.Health),
                        new CombatStat(2, false, Stats.MeleeArmour),
                        new CombatStat(0, false, Stats.RangedArmour),
                        new CombatStat(4, true, Stats.Movement),
                        new CombatStat(26, false, Stats.Initiative),
                        new AttackStat(
                            3,
                            Attacks.Melee,
                            1,
                            1,
                            CombatAttributes.Biological,
                            3)
                    },
                    Factions.Revelators,
                    new List<CombatAttributes>
                    {
                        CombatAttributes.Armoured,
                        CombatAttributes.Biological
                    },
                    new List<AbilityName>
                    {
                        AbilityName.Gorger.FanaticSuicide,
                        AbilityName.Gorger.FanaticSuicidePassive
                    }),

                new Unit(
                    UnitName.Camou,
                    nameof(UnitName.Camou),
                    "",
                    new List<Stat>
                    {
                        new CombatStat(19, true, Stats.Health),
                        new CombatStat(0, false, Stats.MeleeArmour),
                        new CombatStat(1, false, Stats.RangedArmour),
                        new CombatStat(4, true, Stats.Movement),
                        new CombatStat(23, false, Stats.Initiative),
                        new AttackStat(
                            6,
                            Attacks.Melee,
                            1,
                            1,
                            CombatAttributes.Armoured,
                            4)
                    },
                    Factions.Revelators,
                    new List<CombatAttributes>
                    {
                        CombatAttributes.Light,
                        CombatAttributes.Biological
                    },
                    new List<AbilityName>
                    {
                        AbilityName.Camou.SilentAssassin,
                        AbilityName.Camou.Climb
                    }),

                new Unit(
                    UnitName.Shaman, 
                    nameof(UnitName.Shaman),
                    "",
                    new List<Stat>
                    {
                        new CombatStat(18, true, Stats.Health),
                        new CombatStat(1, false, Stats.MeleeArmour),
                        new CombatStat(1, false, Stats.RangedArmour),
                        new CombatStat(4, true, Stats.Movement),
                        new CombatStat(19, false, Stats.Initiative),
                        new AttackStat(
                            1,
                            Attacks.Melee,
                            1,
                            1),
                        new AttackStat(
                            2,
                            Attacks.Ranged,
                            2,
                            4,
                            CombatAttributes.Ranged,
                            9)
                    },
                    Factions.Revelators,
                    new List<CombatAttributes>
                    {
                        CombatAttributes.Armoured,
                        CombatAttributes.Biological,
                        CombatAttributes.Ranged
                    },
                    new List<AbilityName>
                    {
                        AbilityName.Shaman.WondrousGoo
                    }),

                new Unit(
                    UnitName.Pyre,
                    nameof(UnitName.Pyre),
                    "",
                    new List<Stat>
                    {
                        new CombatStat(22, true, Stats.Health),
                        new CombatStat(1, false, Stats.MeleeArmour),
                        new CombatStat(0, false, Stats.RangedArmour),
                        new CombatStat(5, true, Stats.Movement),
                        new CombatStat(12, false, Stats.Initiative),
                        new AttackStat(
                            1,
                            Attacks.Melee,
                            1,
                            1),
                        new AttackStat(
                            6,
                            Attacks.Ranged,
                            2,
                            5,
                            CombatAttributes.Armoured,
                            8)
                    },
                    Factions.Revelators,
                    new List<CombatAttributes>
                    {
                        CombatAttributes.Light,
                        CombatAttributes.Mechanical,
                        CombatAttributes.Ranged
                    },
                    new List<AbilityName>
                    {
                        AbilityName.Pyre.WallOfFlames,
                        AbilityName.Pyre.PhantomMenace
                    }),

                new Unit(
                    UnitName.BigBadBull,
                    nameof(UnitName.BigBadBull).CamelCaseToWords(),
                    "",
                    new List<Stat>
                    {
                        new CombatStat(40, true, Stats.Health),
                        new CombatStat(1, false, Stats.MeleeArmour),
                        new CombatStat(0, false, Stats.RangedArmour),
                        new CombatStat(4, true, Stats.Movement),
                        new CombatStat(25, false, Stats.Initiative),
                        new AttackStat(
                            8,
                            Attacks.Melee,
                            1,
                            1,
                            CombatAttributes.Structure,
                            6)
                    },
                    Factions.Revelators,
                    new List<CombatAttributes>
                    {
                        CombatAttributes.Giant,
                        CombatAttributes.Biological
                    },
                    new List<AbilityName>
                    {
                        AbilityName.BigBadBull.UnleashTheRage
                    },
                    2),

                new Unit(
                    UnitName.Mummy,
                    nameof(UnitName.Mummy),
                    "",
                    new List<Stat>
                    {
                        new CombatStat(39, true, Stats.Health),
                        new CombatStat(0, false, Stats.MeleeArmour),
                        new CombatStat(0, false, Stats.RangedArmour),
                        new CombatStat(2, true, Stats.Movement),
                        new CombatStat(16, false, Stats.Initiative),
                        new AttackStat(
                            3,
                            Attacks.Melee,
                            1,
                            1)
                    },
                    Factions.Revelators,
                    new List<CombatAttributes>
                    {
                        CombatAttributes.Light,
                        CombatAttributes.Biological
                    },
                    new List<AbilityName>
                    {
                        AbilityName.Mummy.SpawnRoach,
                        AbilityName.Mummy.LeapOfHunger
                    }),

                new Unit(
                    UnitName.Roach,
                    nameof(UnitName.Roach),
                    "",
                    new List<Stat>
                    {
                        new CombatStat(5, true, Stats.Health),
                        new CombatStat(0, false, Stats.MeleeArmour),
                        new CombatStat(2, false, Stats.RangedArmour),
                        new CombatStat(5, true, Stats.Movement),
                        new CombatStat(15, false, Stats.Initiative),
                        new AttackStat(
                            6,
                            Attacks.Melee,
                            1,
                            1,
                            CombatAttributes.Giant,
                            1)
                    },
                    Factions.Revelators,
                    new List<CombatAttributes>
                    {
                        CombatAttributes.Armoured,
                        CombatAttributes.Biological
                    },
                    new List<AbilityName>
                    {
                        AbilityName.Roach.DegradingCarapace,
                        AbilityName.Roach.CorrosiveSpit
                    }),

                new Unit(
                    UnitName.Parasite,
                    nameof(UnitName.Parasite),
                    "",
                    new List<Stat>
                    {
                        new CombatStat(36, true, Stats.Health),
                        new CombatStat(1, false, Stats.MeleeArmour),
                        new CombatStat(1, false, Stats.RangedArmour),
                        new CombatStat(6, true, Stats.Movement),
                        new CombatStat(14, false, Stats.Initiative),
                        new AttackStat(
                            0,
                            Attacks.Melee,
                            1,
                            1)
                    },
                    Factions.Revelators,
                    new List<CombatAttributes>
                    {
                        CombatAttributes.Light,
                        CombatAttributes.Celestial
                    },
                    new List<AbilityName>
                    {
                        AbilityName.Parasite.ParalysingGrasp
                    }),
            };
        }
    }
}
