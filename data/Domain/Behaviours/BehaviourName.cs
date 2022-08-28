﻿using low_age_data.Common;

namespace low_age_data.Domain.Behaviours
{
    public class BehaviourName : Name
    {
        private BehaviourName(string value) : base($"behaviour-{value}")
        {
        }

        public static class Leader
        {
            public static BehaviourName AllForOneBuff => new($"{nameof(Leader)}{nameof(AllForOneBuff)}".ToKebabCase());
            public static BehaviourName MenacingPresenceBuff => new($"{nameof(Leader)}{nameof(MenacingPresenceBuff)}".ToKebabCase());
            public static BehaviourName OneForAllObeliskBuff => new($"{nameof(Leader)}{nameof(OneForAllObeliskBuff)}".ToKebabCase());
            public static BehaviourName OneForAllHealBuff => new($"{nameof(Leader)}{nameof(OneForAllHealBuff)}".ToKebabCase());
        }

        public static class Slave
        {
            public static BehaviourName RepairStructureBuff => new($"{nameof(Slave)}{nameof(RepairStructureBuff)}".ToKebabCase());
            public static BehaviourName RepairWait => new($"{nameof(Slave)}{nameof(RepairWait)}".ToKebabCase());
            public static BehaviourName ManualLabourBuff => new($"{nameof(Slave)}{nameof(ManualLabourBuff)}".ToKebabCase());
            public static BehaviourName ManualLabourWait => new($"{nameof(Slave)}{nameof(ManualLabourWait)}".ToKebabCase());
        }

        public static class Quickdraw
        {
            public static BehaviourName DoubleshotExtraAttack => new($"{nameof(Quickdraw)}{nameof(DoubleshotExtraAttack)}".ToKebabCase());
            public static BehaviourName CrippleBuff => new($"{nameof(Quickdraw)}{nameof(CrippleBuff)}".ToKebabCase());
        }

        public static class Gorger
        {
            public static BehaviourName FanaticSuicideBuff => new($"{nameof(Gorger)}{nameof(FanaticSuicideBuff)}".ToKebabCase());
        }

        public static class Camou
        {
            public static BehaviourName SilentAssassinBuff => new($"{nameof(Camou)}{nameof(SilentAssassinBuff)}".ToKebabCase());
            public static BehaviourName ClimbWait => new($"{nameof(Camou)}{nameof(ClimbWait)}".ToKebabCase());
            public static BehaviourName ClimbBuff => new($"{nameof(Camou)}{nameof(ClimbBuff)}".ToKebabCase());
        }

        public static class Shaman
        {
            public static BehaviourName WondrousGooFeatureWait => new($"{nameof(Shaman)}{nameof(WondrousGooFeatureWait)}".ToKebabCase());
            public static BehaviourName WondrousGooFeatureBuff => new($"{nameof(Shaman)}{nameof(WondrousGooFeatureBuff)}".ToKebabCase());
            public static BehaviourName WondrousGooBuff => new($"{nameof(Shaman)}{nameof(WondrousGooBuff)}".ToKebabCase());
        }

        public static class Pyre
        {
            public static BehaviourName CargoTether => new($"{nameof(Pyre)}{nameof(CargoTether)}".ToKebabCase());
            public static BehaviourName CargoWallOfFlamesBuff => new($"{nameof(Pyre)}{nameof(CargoWallOfFlamesBuff)}".ToKebabCase());
            public static BehaviourName WallOfFlamesBuff => new($"{nameof(Pyre)}{nameof(WallOfFlamesBuff)}".ToKebabCase());
            public static BehaviourName PhantomMenaceBuff => new($"{nameof(Pyre)}{nameof(PhantomMenaceBuff)}".ToKebabCase());
        }

        public static class Roach
        {
            public static BehaviourName DegradingCarapaceBuff => new($"{nameof(Roach)}{nameof(DegradingCarapaceBuff)}".ToKebabCase());
            public static BehaviourName DegradingCarapacePeriodicDamageBuff => new($"{nameof(Roach)}{nameof(DegradingCarapacePeriodicDamageBuff)}".ToKebabCase());
        }

        public static class Parasite
        {
            public static BehaviourName ParalysingGraspTether => new($"{nameof(Parasite)}{nameof(ParalysingGraspTether)}".ToKebabCase());
            public static BehaviourName ParalysingGraspBuff => new($"{nameof(Parasite)}{nameof(ParalysingGraspBuff)}".ToKebabCase());
            public static BehaviourName ParalysingGraspSelfBuff => new($"{nameof(Parasite)}{nameof(ParalysingGraspSelfBuff)}".ToKebabCase());
        }

        public static class Horrior
        {
            public static BehaviourName ExpertFormationBuff => new($"{nameof(Horrior)}{nameof(ExpertFormationBuff)}".ToKebabCase());
            public static BehaviourName MountWait => new($"{nameof(Horrior)}{nameof(MountWait)}".ToKebabCase());
            public static BehaviourName MountBuff => new($"{nameof(Horrior)}{nameof(MountBuff)}".ToKebabCase());
        }

        public static class Marksman
        {
            public static BehaviourName CriticalMarkBuff => new($"{nameof(Marksman)}{nameof(CriticalMarkBuff)}".ToKebabCase());
        }
        
        public static class Surfer
        {
            public static BehaviourName DismountBuff => new($"{nameof(Surfer)}{nameof(DismountBuff)}".ToKebabCase());
        }

        public static class Mortar
        {
            public static BehaviourName DeadlyAmmunitionAmmunition => new($"{nameof(Mortar)}{nameof(DeadlyAmmunitionAmmunition)}".ToKebabCase());
            public static BehaviourName ReloadWait => new($"{nameof(Mortar)}{nameof(ReloadWait)}".ToKebabCase());
            public static BehaviourName ReloadBuff => new($"{nameof(Mortar)}{nameof(ReloadBuff)}".ToKebabCase());
            public static BehaviourName PiercingBlastBuff => new($"{nameof(Mortar)}{nameof(PiercingBlastBuff)}".ToKebabCase());
        }

        public static class Hawk
        {
            public static BehaviourName TacticalGogglesBuff => new($"{nameof(Hawk)}{nameof(TacticalGogglesBuff)}".ToKebabCase());
            public static BehaviourName LeadershipBuff => new($"{nameof(Hawk)}{nameof(LeadershipBuff)}".ToKebabCase());
            public static BehaviourName HealthKitBuff => new($"{nameof(Hawk)}{nameof(HealthKitBuff)}".ToKebabCase());
            public static BehaviourName HealthKitHealBuff => new($"{nameof(Hawk)}{nameof(HealthKitHealBuff)}".ToKebabCase());
        }

        public static class Engineer
        {
            public static BehaviourName OperateBuff => new($"{nameof(Engineer)}{nameof(OperateBuff)}".ToKebabCase());
            public static BehaviourName RepairStructureOrMachineBuff => new($"{nameof(Engineer)}{nameof(RepairStructureOrMachineBuff)}".ToKebabCase());
            public static BehaviourName RepairHorriorBuff => new($"{nameof(Engineer)}{nameof(RepairHorriorBuff)}".ToKebabCase());
            public static BehaviourName RepairWait => new($"{nameof(Engineer)}{nameof(RepairWait)}".ToKebabCase());
        }

        public static class Cannon
        {
            public static BehaviourName AssemblingBuildable => new($"{nameof(Cannon)}{nameof(AssemblingBuildable)}".ToKebabCase());
            public static BehaviourName MachineCounter => new($"{nameof(Cannon)}{nameof(MachineCounter)}".ToKebabCase());
            public static BehaviourName MachineBuff => new($"{nameof(Cannon)}{nameof(MachineBuff)}".ToKebabCase());
            public static BehaviourName HeatUpDangerZoneBuff => new($"{nameof(Cannon)}{nameof(HeatUpDangerZoneBuff)}".ToKebabCase());
            public static BehaviourName HeatUpWait => new($"{nameof(Cannon)}{nameof(HeatUpWait)}".ToKebabCase());
        }

        public static class Ballista
        {
            public static BehaviourName AssemblingBuildable => new($"{nameof(Ballista)}{nameof(AssemblingBuildable)}".ToKebabCase());
            public static BehaviourName MachineCounter => new($"{nameof(Ballista)}{nameof(MachineCounter)}".ToKebabCase());
            public static BehaviourName MachineBuff => new($"{nameof(Ballista)}{nameof(MachineBuff)}".ToKebabCase());
            public static BehaviourName AimBuff => new($"{nameof(Ballista)}{nameof(AimBuff)}".ToKebabCase());
        }

        public static class Radar
        {
            public static BehaviourName AssemblingBuildable => new($"{nameof(Radar)}{nameof(AssemblingBuildable)}".ToKebabCase());
            public static BehaviourName MachineCounter => new($"{nameof(Radar)}{nameof(MachineCounter)}".ToKebabCase());
            public static BehaviourName MachineBuff => new($"{nameof(Radar)}{nameof(MachineBuff)}".ToKebabCase());
            public static BehaviourName PowerDependencyBuff => new($"{nameof(Radar)}{nameof(PowerDependencyBuff)}".ToKebabCase());
            public static BehaviourName PowerDependencyBuffDisable => new($"{nameof(Radar)}{nameof(PowerDependencyBuffDisable)}".ToKebabCase());
            public static BehaviourName ResonatingSweepBuff => new($"{nameof(Radar)}{nameof(ResonatingSweepBuff)}".ToKebabCase());
            public static BehaviourName RadioLocationBuff => new($"{nameof(Radar)}{nameof(RadioLocationBuff)}".ToKebabCase());
            public static BehaviourName RadioLocationFeatureBuff => new($"{nameof(Radar)}{nameof(RadioLocationFeatureBuff)}".ToKebabCase());
        }

        public static class Vessel
        {
            public static BehaviourName MachineCounter => new($"{nameof(Vessel)}{nameof(MachineCounter)}".ToKebabCase());
            public static BehaviourName MachineBuff => new($"{nameof(Vessel)}{nameof(MachineBuff)}".ToKebabCase());
            public static BehaviourName AbsorbentFieldBuffMelee => new($"{nameof(Vessel)}{nameof(AbsorbentFieldBuffMelee)}".ToKebabCase());
            public static BehaviourName AbsorbentFieldBuffRanged => new($"{nameof(Vessel)}{nameof(AbsorbentFieldBuffRanged)}".ToKebabCase());
        }
    }
}
