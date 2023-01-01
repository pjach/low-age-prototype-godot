﻿using low_age_data.Common;

namespace low_age_data.Domain.Effects
{
    public class EffectName : Name
    {
        private EffectName(string value) : base($"effect-{value}")
        {
        }

        public static class Shared
        {
            public static EffectName HighGroundSearch => new($"{nameof(Shared)}{nameof(HighGroundSearch)}".ToKebabCase());
            public static EffectName HighGroundApplyBehaviour => new($"{nameof(Shared)}{nameof(HighGroundApplyBehaviour)}".ToKebabCase());
            public static EffectName PassiveIncomeApplyBehaviour => new($"{nameof(Shared)}{nameof(PassiveIncomeApplyBehaviour)}".ToKebabCase());
            public static EffectName ScrapsIncomeApplyBehaviour => new($"{nameof(Shared)}{nameof(ScrapsIncomeApplyBehaviour)}".ToKebabCase());
            public static EffectName CelestiumIncomeApplyBehaviour => new($"{nameof(Shared)}{nameof(CelestiumIncomeApplyBehaviour)}".ToKebabCase());
            public static EffectName NoPopulationSpaceSearch => new($"{nameof(Shared)}{nameof(NoPopulationSpaceSearch)}".ToKebabCase());
            public static EffectName NoPopulationSpaceApplyBehaviour => new($"{nameof(Shared)}{nameof(NoPopulationSpaceApplyBehaviour)}".ToKebabCase());
        }
        
        public static class Citadel
        {
            public static EffectName ExecutiveStashApplyBehaviour => new($"{nameof(Citadel)}{nameof(ExecutiveStashApplyBehaviour)}".ToKebabCase());
            public static EffectName AscendableApplyBehaviour => new($"{nameof(Citadel)}{nameof(AscendableApplyBehaviour)}".ToKebabCase());
            public static EffectName HighGroundApplyBehaviour => new($"{nameof(Citadel)}{nameof(HighGroundApplyBehaviour)}".ToKebabCase());
        }

        public static class Hut
        {
        }
        
        public static class Obelisk
        {
            public static EffectName CelestiumDischargeSearchLong => new($"{nameof(Obelisk)}{nameof(CelestiumDischargeSearchLong)}".ToKebabCase());
            public static EffectName CelestiumDischargeApplyBehaviourLong => new($"{nameof(Obelisk)}{nameof(CelestiumDischargeApplyBehaviourLong)}".ToKebabCase());
            public static EffectName CelestiumDischargeSearchShort => new($"{nameof(Obelisk)}{nameof(CelestiumDischargeSearchShort)}".ToKebabCase());
            public static EffectName CelestiumDischargeApplyBehaviourShort => new($"{nameof(Obelisk)}{nameof(CelestiumDischargeApplyBehaviourShort)}".ToKebabCase());
            public static EffectName CelestiumDischargeApplyBehaviourNegative => new($"{nameof(Obelisk)}{nameof(CelestiumDischargeApplyBehaviourNegative)}".ToKebabCase());
        }

        public static class Shack
        {
            public static EffectName AccommodationApplyBehaviour => new($"{nameof(Shack)}{nameof(AccommodationApplyBehaviour)}".ToKebabCase());
        }

        public static class Leader
        {
            public static EffectName AllForOneApplyBehaviour => new($"{nameof(Leader)}{nameof(AllForOneApplyBehaviour)}".ToKebabCase());
            public static EffectName AllForOnePlayerLoses => new($"{nameof(Leader)}{nameof(AllForOnePlayerLoses)}".ToKebabCase());
            public static EffectName MenacingPresenceSearch => new($"{nameof(Leader)}{nameof(MenacingPresenceSearch)}".ToKebabCase());
            public static EffectName MenacingPresenceApplyBehaviour => new($"{nameof(Leader)}{nameof(MenacingPresenceApplyBehaviour)}".ToKebabCase());
            public static EffectName OneForAllApplyBehaviourObelisk => new($"{nameof(Leader)}{nameof(OneForAllApplyBehaviourObelisk)}".ToKebabCase());
            public static EffectName OneForAllSearch => new($"{nameof(Leader)}{nameof(OneForAllSearch)}".ToKebabCase());
            public static EffectName OneForAllApplyBehaviourHeal => new($"{nameof(Leader)}{nameof(OneForAllApplyBehaviourHeal)}".ToKebabCase());
        }

        public static class Slave
        {
            public static EffectName RepairApplyBehaviourStructure => new($"{nameof(Slave)}{nameof(RepairApplyBehaviourStructure)}".ToKebabCase());
            public static EffectName RepairApplyBehaviourSelf => new($"{nameof(Slave)}{nameof(RepairApplyBehaviourSelf)}".ToKebabCase());
            public static EffectName ManualLabourApplyBehaviourHut => new($"{nameof(Slave)}{nameof(ManualLabourApplyBehaviourHut)}".ToKebabCase());
            public static EffectName ManualLabourApplyBehaviourSelf => new($"{nameof(Slave)}{nameof(ManualLabourApplyBehaviourSelf)}".ToKebabCase());
            public static EffectName ManualLabourModifyPlayer => new($"{nameof(Slave)}{nameof(ManualLabourModifyPlayer)}".ToKebabCase());
        }

        public static class Quickdraw
        {
            public static EffectName DoubleshotApplyBehaviour => new($"{nameof(Quickdraw)}{nameof(DoubleshotApplyBehaviour)}".ToKebabCase());
            public static EffectName CrippleApplyBehaviour => new($"{nameof(Quickdraw)}{nameof(CrippleApplyBehaviour)}".ToKebabCase());
        }

        public static class Gorger
        {
            public static EffectName FanaticSuicideApplyBehaviourBuff => new($"{nameof(Gorger)}{nameof(FanaticSuicideApplyBehaviourBuff)}".ToKebabCase());
            public static EffectName FanaticSuicideDestroy => new($"{nameof(Gorger)}{nameof(FanaticSuicideDestroy)}".ToKebabCase());
            public static EffectName FanaticSuicideSearch => new($"{nameof(Gorger)}{nameof(FanaticSuicideSearch)}".ToKebabCase());
            public static EffectName FanaticSuicideDamage => new($"{nameof(Gorger)}{nameof(FanaticSuicideDamage)}".ToKebabCase());
        }

        public static class Camou
        {
            public static EffectName SilentAssassinOnHitDamage => new($"{nameof(Camou)}{nameof(SilentAssassinOnHitDamage)}".ToKebabCase());
            public static EffectName SilentAssassinOnHitSilence => new($"{nameof(Camou)}{nameof(SilentAssassinOnHitSilence)}".ToKebabCase());
            public static EffectName SilentAssassinSearchFriendly => new($"{nameof(Camou)}{nameof(SilentAssassinSearchFriendly)}".ToKebabCase());
            public static EffectName SilentAssassinSearchEnemy => new($"{nameof(Camou)}{nameof(SilentAssassinSearchEnemy)}".ToKebabCase());
            public static EffectName ClimbTeleport => new($"{nameof(Camou)}{nameof(ClimbTeleport)}".ToKebabCase());
            public static EffectName ClimbApplyBehaviour => new($"{nameof(Camou)}{nameof(ClimbApplyBehaviour)}".ToKebabCase());
        }

        public static class Shaman
        {
            public static EffectName WondrousGooCreateEntity => new($"{nameof(Shaman)}{nameof(WondrousGooCreateEntity)}".ToKebabCase());
            public static EffectName WondrousGooSearch => new($"{nameof(Shaman)}{nameof(WondrousGooSearch)}".ToKebabCase());
            public static EffectName WondrousGooApplyBehaviour => new($"{nameof(Shaman)}{nameof(WondrousGooApplyBehaviour)}".ToKebabCase());
            public static EffectName WondrousGooDestroy => new($"{nameof(Shaman)}{nameof(WondrousGooDestroy)}".ToKebabCase());
            public static EffectName WondrousGooDamage => new($"{nameof(Shaman)}{nameof(WondrousGooDamage)}".ToKebabCase());
        }

        public static class Pyre
        {
            public static EffectName CargoCreateEntity => new($"{nameof(Pyre)}{nameof(CargoCreateEntity)}".ToKebabCase());
            public static EffectName WallOfFlamesCreateEntity => new($"{nameof(Pyre)}{nameof(WallOfFlamesCreateEntity)}".ToKebabCase());
            public static EffectName WallOfFlamesDestroy => new($"{nameof(Pyre)}{nameof(WallOfFlamesDestroy)}".ToKebabCase());
            public static EffectName WallOfFlamesDamage => new($"{nameof(Pyre)}{nameof(WallOfFlamesDamage)}".ToKebabCase());
            public static EffectName PhantomMenaceApplyBehaviour => new($"{nameof(Pyre)}{nameof(PhantomMenaceApplyBehaviour)}".ToKebabCase());
        }

        public static class BigBadBull
        {
            public static EffectName UnleashTheRageSearch => new($"{nameof(BigBadBull)}{nameof(UnleashTheRageSearch)}".ToKebabCase());
            public static EffectName UnleashTheRageDamage => new($"{nameof(BigBadBull)}{nameof(UnleashTheRageDamage)}".ToKebabCase());
            public static EffectName UnleashTheRageForce => new($"{nameof(BigBadBull)}{nameof(UnleashTheRageForce)}".ToKebabCase());
            public static EffectName UnleashTheRageForceDamage => new($"{nameof(BigBadBull)}{nameof(UnleashTheRageForceDamage)}".ToKebabCase());
        }

        public static class Mummy
        {
            public static EffectName SpawnRoachCreateEntity => new($"{nameof(Mummy)}{nameof(SpawnRoachCreateEntity)}".ToKebabCase());
            public static EffectName LeapOfHungerModifyAbility => new($"{nameof(Mummy)}{nameof(LeapOfHungerModifyAbility)}".ToKebabCase());
        }

        public static class Roach
        {
            public static EffectName DegradingCarapaceApplyBehaviour => new($"{nameof(Roach)}{nameof(DegradingCarapaceApplyBehaviour)}".ToKebabCase());
            public static EffectName DegradingCarapacePeriodicApplyBehaviour => new($"{nameof(Roach)}{nameof(DegradingCarapacePeriodicApplyBehaviour)}".ToKebabCase());
            public static EffectName DegradingCarapaceSelfDamage => new($"{nameof(Roach)}{nameof(DegradingCarapaceSelfDamage)}".ToKebabCase());
            public static EffectName CorrosiveSpitDamage => new($"{nameof(Roach)}{nameof(CorrosiveSpitDamage)}".ToKebabCase());
        }

        public static class Parasite
        {
            public static EffectName ParalysingGraspApplyTetherBehaviour => new($"{nameof(Parasite)}{nameof(ParalysingGraspApplyTetherBehaviour)}".ToKebabCase());
            public static EffectName ParalysingGraspApplyAttackBehaviour => new($"{nameof(Parasite)}{nameof(ParalysingGraspApplyAttackBehaviour)}".ToKebabCase());
            public static EffectName ParalysingGraspApplySelfBehaviour => new($"{nameof(Parasite)}{nameof(ParalysingGraspApplySelfBehaviour)}".ToKebabCase());
        }

        public static class Horrior
        {
            public static EffectName ExpertFormationSearch => new($"{nameof(Horrior)}{nameof(ExpertFormationSearch)}".ToKebabCase());
            public static EffectName ExpertFormationApplyBehaviour => new($"{nameof(Horrior)}{nameof(ExpertFormationApplyBehaviour)}".ToKebabCase());
            public static EffectName MountApplyBehaviour => new($"{nameof(Horrior)}{nameof(MountApplyBehaviour)}".ToKebabCase());
            public static EffectName MountCreateEntity => new($"{nameof(Horrior)}{nameof(MountCreateEntity)}".ToKebabCase());
            public static EffectName MountDestroy => new($"{nameof(Horrior)}{nameof(MountDestroy)}".ToKebabCase());
        }

        public static class Marksman
        {
            public static EffectName CriticalMarkApplyBehaviour => new($"{nameof(Marksman)}{nameof(CriticalMarkApplyBehaviour)}".ToKebabCase());
            public static EffectName CriticalMarkDamage => new($"{nameof(Marksman)}{nameof(CriticalMarkDamage)}".ToKebabCase());
        }

        public static class Surfer
        {
            public static EffectName DismountApplyBehaviour => new($"{nameof(Surfer)}{nameof(DismountApplyBehaviour)}".ToKebabCase());
            public static EffectName DismountCreateEntity => new($"{nameof(Surfer)}{nameof(DismountCreateEntity)}".ToKebabCase());
        }
        
        public static class Mortar
        {
            public static EffectName DeadlyAmmunitionApplyBehaviour => new($"{nameof(Mortar)}{nameof(DeadlyAmmunitionApplyBehaviour)}".ToKebabCase());
            public static EffectName DeadlyAmmunitionSearch => new($"{nameof(Mortar)}{nameof(DeadlyAmmunitionSearch)}".ToKebabCase());
            public static EffectName DeadlyAmmunitionDamage => new($"{nameof(Mortar)}{nameof(DeadlyAmmunitionDamage)}".ToKebabCase());
            public static EffectName ReloadApplyBehaviour => new($"{nameof(Mortar)}{nameof(ReloadApplyBehaviour)}".ToKebabCase());
            public static EffectName ReloadReload => new($"{nameof(Mortar)}{nameof(ReloadReload)}".ToKebabCase());
            public static EffectName PiercingBlastApplyBehaviour => new($"{nameof(Mortar)}{nameof(PiercingBlastApplyBehaviour)}".ToKebabCase());
        }

        public static class Hawk
        {
            public static EffectName TacticalGogglesApplyBehaviour => new($"{nameof(Hawk)}{nameof(TacticalGogglesApplyBehaviour)}".ToKebabCase());
            public static EffectName LeadershipApplyBehaviour => new($"{nameof(Hawk)}{nameof(LeadershipApplyBehaviour)}".ToKebabCase());
            public static EffectName HealthKitApplyBehaviour => new($"{nameof(Hawk)}{nameof(HealthKitApplyBehaviour)}".ToKebabCase());
            public static EffectName HealthKitSearch => new($"{nameof(Hawk)}{nameof(HealthKitSearch)}".ToKebabCase());
            public static EffectName HealthKitHealApplyBehaviour => new($"{nameof(Hawk)}{nameof(HealthKitHealApplyBehaviour)}".ToKebabCase());
        }

        public static class Engineer
        {
            public static EffectName OperateApplyBehaviour => new($"{nameof(Engineer)}{nameof(OperateApplyBehaviour)}".ToKebabCase());
            public static EffectName OperateModifyCounter => new($"{nameof(Engineer)}{nameof(OperateModifyCounter)}".ToKebabCase());
            public static EffectName OperateDestroy => new($"{nameof(Engineer)}{nameof(OperateDestroy)}".ToKebabCase());
            public static EffectName RepairStructureApplyBehaviour => new($"{nameof(Engineer)}{nameof(RepairStructureApplyBehaviour)}".ToKebabCase());
            public static EffectName RepairMachineApplyBehaviour => new($"{nameof(Engineer)}{nameof(RepairMachineApplyBehaviour)}".ToKebabCase());
            public static EffectName RepairHorriorApplyBehaviour => new($"{nameof(Engineer)}{nameof(RepairHorriorApplyBehaviour)}".ToKebabCase());
            public static EffectName RepairApplyBehaviourSelf => new($"{nameof(Engineer)}{nameof(RepairApplyBehaviourSelf)}".ToKebabCase());
        }
        
        public static class Cannon
        {
            public static EffectName MachineApplyBehaviour => new($"{nameof(Cannon)}{nameof(MachineApplyBehaviour)}".ToKebabCase());
            public static EffectName MachineRemoveBehaviour => new($"{nameof(Cannon)}{nameof(MachineRemoveBehaviour)}".ToKebabCase());
            public static EffectName HeatUpCreateEntity => new($"{nameof(Cannon)}{nameof(HeatUpCreateEntity)}".ToKebabCase());
            public static EffectName HeatUpApplyWaitBehaviour => new($"{nameof(Cannon)}{nameof(HeatUpApplyWaitBehaviour)}".ToKebabCase());
            public static EffectName HeatUpSearch => new($"{nameof(Cannon)}{nameof(HeatUpSearch)}".ToKebabCase());
            public static EffectName HeatUpDamage => new($"{nameof(Cannon)}{nameof(HeatUpDamage)}".ToKebabCase());
            public static EffectName HeatUpDestroy => new($"{nameof(Cannon)}{nameof(HeatUpDestroy)}".ToKebabCase());
            public static EffectName HeatUpRemoveBehaviour => new($"{nameof(Cannon)}{nameof(HeatUpRemoveBehaviour)}".ToKebabCase());
        }

        public static class Ballista
        {
            public static EffectName MachineApplyBehaviour => new($"{nameof(Ballista)}{nameof(MachineApplyBehaviour)}".ToKebabCase());
            public static EffectName MachineRemoveBehaviour => new($"{nameof(Ballista)}{nameof(MachineRemoveBehaviour)}".ToKebabCase());
            public static EffectName AimDamage => new($"{nameof(Ballista)}{nameof(AimDamage)}".ToKebabCase());
            public static EffectName AimApplyBehaviour => new($"{nameof(Ballista)}{nameof(AimApplyBehaviour)}".ToKebabCase());
            public static EffectName AimSearch => new($"{nameof(Ballista)}{nameof(AimSearch)}".ToKebabCase());
        }
        
        public static class Radar
        {
            public static EffectName MachineApplyBehaviour => new($"{nameof(Radar)}{nameof(MachineApplyBehaviour)}".ToKebabCase());
            public static EffectName MachineRemoveBehaviour => new($"{nameof(Radar)}{nameof(MachineRemoveBehaviour)}".ToKebabCase());
            public static EffectName PowerDependencyApplyBehaviour => new($"{nameof(Radar)}{nameof(PowerDependencyApplyBehaviour)}".ToKebabCase());
            public static EffectName PowerDependencyDamage => new($"{nameof(Radar)}{nameof(PowerDependencyDamage)}".ToKebabCase());
            public static EffectName PowerDependencyApplyBehaviourDisable => new($"{nameof(Radar)}{nameof(PowerDependencyApplyBehaviourDisable)}".ToKebabCase());
            public static EffectName ResonatingSweepCreateEntity => new($"{nameof(Radar)}{nameof(ResonatingSweepCreateEntity)}".ToKebabCase());
            public static EffectName ResonatingSweepDestroy => new($"{nameof(Radar)}{nameof(ResonatingSweepDestroy)}".ToKebabCase());
            public static EffectName RadioLocationApplyBehaviour => new($"{nameof(Radar)}{nameof(RadioLocationApplyBehaviour)}".ToKebabCase());
            public static EffectName RadioLocationSearchDestroy => new($"{nameof(Radar)}{nameof(RadioLocationSearchDestroy)}".ToKebabCase());
            public static EffectName RadioLocationDestroy => new($"{nameof(Radar)}{nameof(RadioLocationDestroy)}".ToKebabCase());
            public static EffectName RadioLocationSearchCreate => new($"{nameof(Radar)}{nameof(RadioLocationSearchCreate)}".ToKebabCase());
            public static EffectName RadioLocationCreateEntity => new($"{nameof(Radar)}{nameof(RadioLocationCreateEntity)}".ToKebabCase());
        }

        public static class Vessel
        {
            public static EffectName MachineApplyBehaviour => new($"{nameof(Vessel)}{nameof(MachineApplyBehaviour)}".ToKebabCase());
            public static EffectName MachineRemoveBehaviour => new($"{nameof(Vessel)}{nameof(MachineRemoveBehaviour)}".ToKebabCase());
            public static EffectName AbsorbentFieldSearch => new($"{nameof(Vessel)}{nameof(AbsorbentFieldSearch)}".ToKebabCase());
            public static EffectName AbsorbentFieldApplyBehaviour => new($"{nameof(Vessel)}{nameof(AbsorbentFieldApplyBehaviour)}".ToKebabCase());
            public static EffectName FortifyCreateEntity => new($"{nameof(Vessel)}{nameof(FortifyCreateEntity)}".ToKebabCase());
            public static EffectName FortifyDestroy => new($"{nameof(Vessel)}{nameof(FortifyDestroy)}".ToKebabCase());
            public static EffectName FortifySearch => new($"{nameof(Vessel)}{nameof(FortifySearch)}".ToKebabCase());
            public static EffectName FortifyApplyBehaviour => new($"{nameof(Vessel)}{nameof(FortifyApplyBehaviour)}".ToKebabCase());
        }

        public static class Omen
        {
            public static EffectName RenditionPlacementApplyBehaviour => new($"{nameof(Omen)}{nameof(RenditionPlacementApplyBehaviour)}".ToKebabCase());
            public static EffectName RenditionPlacementExecuteAbility => new($"{nameof(Omen)}{nameof(RenditionPlacementExecuteAbility)}".ToKebabCase());
            public static EffectName RenditionPlacementCreateEntity => new($"{nameof(Omen)}{nameof(RenditionPlacementCreateEntity)}".ToKebabCase());
            public static EffectName RenditionDestroy => new($"{nameof(Omen)}{nameof(RenditionDestroy)}".ToKebabCase());
            public static EffectName RenditionSearch => new($"{nameof(Omen)}{nameof(RenditionSearch)}".ToKebabCase());
            public static EffectName RenditionDamage => new($"{nameof(Omen)}{nameof(RenditionDamage)}".ToKebabCase());
            public static EffectName RenditionApplyBehaviourSlow => new($"{nameof(Omen)}{nameof(RenditionApplyBehaviourSlow)}".ToKebabCase());
        }
    }
}
