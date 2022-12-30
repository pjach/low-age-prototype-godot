﻿using low_age_data.Common;
using low_age_data.Domain.Behaviours;
using low_age_data.Domain.Effects;
using low_age_data.Domain.Logic;
using low_age_data.Domain.Shared;
using low_age_data.Domain.Shared.Durations;
using low_age_data.Domain.Shared.Flags;
using low_age_data.Domain.Shared.Modifications;
using System.Collections.Generic;
using low_age_data.Domain.Entities.Tiles;
using low_age_data.Domain.Resources;

namespace low_age_data.Collections
{
    public static class Behaviours
    {
        public static List<Behaviour> Get()
        {
            return new List<Behaviour>
            {
                new Buff(
                    name: BehaviourName.Shared.HighGroundBuff,
                    displayName: nameof(BehaviourName.Shared.HighGroundBuff).CamelCaseToWords(),
                    description: "Unit is on high ground and has +1 Attack Distance for ranged attacks.",
                    initialModifications: new List<Modification>
                    {
                        new AttackModification(
                            change: Change.AddMax,
                            amount: 1,
                            attackType: Attacks.Ranged,
                            attribute: AttackAttribute.MaxDistance)
                    },
                    canStack: false,
                    canResetDuration: false,
                    alignment: Alignment.Positive,
                    restoreChangesOnEnd: true),
                
                new Income(
                    name: BehaviourName.Shared.PassiveIncomeIncome,
                    displayName: nameof(BehaviourName.Shared.PassiveIncomeIncome).CamelCaseToWords(),
                    description: "Provides 3 Scraps and 7 Celestium at the start of each planning phase.",
                    resources: new List<ResourceModification>
                    {
                        new(change: Change.AddCurrent,
                            amount: 3,
                            resource: ResourceName.Scraps),
                        new(change: Change.AddCurrent, 
                            amount: 7,
                            resource: ResourceName.Celestium)
                    }),
                
                new Income(
                    name: BehaviourName.Shared.ScrapsIncomeIncome,
                    displayName: nameof(BehaviourName.Shared.ScrapsIncomeIncome).CamelCaseToWords(),
                    description: "At the start of each planning phase provides 5 Scraps.",
                    resources: new List<ResourceModification>
                    {
                        new(change: Change.AddCurrent,
                            amount: 5,
                            resource: ResourceName.Scraps)
                    }),
                
                new Income(
                    name: BehaviourName.Shared.CelestiumIncomeIncome,
                    displayName: nameof(BehaviourName.Shared.CelestiumIncomeIncome).CamelCaseToWords(),
                    description: "At the start of each planning phase provides 5 Celestium (-2 for each subsequently " +
                                 "constructed Obelisk, total minimum of 1).",
                    resources: new List<ResourceModification>
                    {
                        new(change: Change.AddCurrent,
                            amount: 5,
                            resource: ResourceName.Celestium)
                    },
                    diminishingReturn: 2),

                new Income(
                    name: BehaviourName.Citadel.ExecutiveStashIncome,
                    displayName: nameof(BehaviourName.Citadel.ExecutiveStashIncome).CamelCaseToWords(),
                    description: "Provides 4 Population and 4 spaces of storage for Weapons.",
                    resources: new List<ResourceModification>
                    {
                        new(change: Change.AddCurrent,
                            amount: 4,
                            resource: ResourceName.Population),
                        new(change: Change.AddCurrent,
                            amount: 4,
                            resource: ResourceName.WeaponStorage)
                    }),
                
                new Ascendable(
                    name: BehaviourName.Citadel.AscendableAscendable,
                    displayName: nameof(BehaviourName.Citadel.AscendableAscendable).CamelCaseToWords(),
                    description: "Can be navigated through to go up to high ground.",
                    path: new List<Area>
                    {
                       new(start: new Vector2<int>(x: 1, y: 1), 
                           size: new Vector2<int>(x: 1, y: 1)) 
                    }),
                
                new HighGround(
                    name: BehaviourName.Citadel.HighGroundHighGround,
                    displayName: nameof(BehaviourName.Citadel.HighGroundHighGround).CamelCaseToWords(),
                    description: "Provides an area of high ground to other units, who all gain +1 Attack Distance " +
                                 "for their ranged attacks.",
                    highGroundAreas: new List<Area>
                    {
                        new(start: new Vector2<int>(x: 0, y: 0), 
                            size: new Vector2<int>(x: 3, y: 2)) 
                    }),
                
                new Buff(
                    name: BehaviourName.Obelisk.CelestiumDischargeBuffLong,
                    displayName: nameof(BehaviourName.Obelisk.CelestiumDischargeBuffLong).CamelCaseToWords(),
                    description: "",
                    initialModifications: new List<Modification>
                    {
                        new StatModification(
                            change: Change.AddCurrent, 
                            amount: 5, 
                            stat: Stats.Health)
                    },
                    endsAt: EndsAt.Instant,
                    canStack: false,
                    canResetDuration: false,
                    alignment: Alignment.Positive),
                
                new Buff(
                    name: BehaviourName.Obelisk.CelestiumDischargeBuffShort,
                    displayName: nameof(BehaviourName.Obelisk.CelestiumDischargeBuffShort).CamelCaseToWords(),
                    description: "",
                    initialModifications: new List<Modification>
                    {
                        new StatModification(
                            change: Change.AddCurrent, 
                            amount: 15, 
                            stat: Stats.Health)
                    },
                    initialEffects: new List<EffectName>
                    {
                        EffectName.Obelisk.CelestiumDischargeApplyBehaviourNegative
                    },
                    endsAt: EndsAt.Instant,
                    canStack: false,
                    canResetDuration: false,
                    alignment: Alignment.Positive),
                
                new Buff(
                    name: BehaviourName.Obelisk.CelestiumDischargeBuffNegative,
                    displayName: nameof(BehaviourName.Obelisk.CelestiumDischargeBuffNegative).CamelCaseToWords(),
                    description: "This unit has its vision, Melee and Range Armour all reduced by 3 for 3 actions.",
                    initialModifications: new List<Modification>
                    {
                        new StatModification(
                            change: Change.SubtractCurrent, 
                            amount: 3, 
                            stat: Stats.Vision),
                        new StatModification(
                            change: Change.SubtractCurrent, 
                            amount: 3, 
                            stat: Stats.MeleeArmour),
                        new StatModification(
                            change: Change.SubtractCurrent, 
                            amount: 3, 
                            stat: Stats.RangedArmour)
                    },
                    endsAt: EndsAt.EndOf.Third.Action,
                    canStack: false,
                    canResetDuration: true,
                    alignment: Alignment.Negative,
                    restoreChangesOnEnd: true),

                new Buff(
                    name: BehaviourName.Leader.AllForOneBuff,
                    displayName: nameof(BehaviourName.Leader.AllForOneBuff).CamelCaseToWords(),
                    description: "Revelators faction loses when this unit dies.",
                    finalEffects: new List<EffectName>
                    {
                        EffectName.Leader.AllForOnePlayerLoses
                    }),

                new Buff(
                    name: BehaviourName.Leader.MenacingPresenceBuff,
                    displayName: nameof(BehaviourName.Leader.MenacingPresenceBuff).CamelCaseToWords(),
                    description: "Melee and Range Damage for this unit is reduced by 2.",
                    initialModifications: new List<Modification>
                    {
                        new AttackModification(
                            change: Change.SubtractMax,
                            amount: 2,
                            attackType: Attacks.Melee,
                            attribute: AttackAttribute.MaxAmount),
                        new AttackModification(
                            change: Change.SubtractMax,
                            amount: 2,
                            attackType: Attacks.Ranged,
                            attribute: AttackAttribute.MaxAmount)
                    },
                    endsAt: EndsAt.EndOf.This.Action,
                    canStack: false,
                    canResetDuration: true,
                    alignment: Alignment.Negative,
                    destroyOnConditionsMet: false,
                    restoreChangesOnEnd: true),

                new Buff(
                    name: BehaviourName.Leader.OneForAllObeliskBuff,
                    displayName: nameof(BehaviourName.Leader.OneForAllObeliskBuff).CamelCaseToWords(),
                    description: "This unit has recently been sapped for health.",
                    modificationFlags: null,
                    initialModifications: null,
                    initialEffects: new List<EffectName>
                    {
                        EffectName.Leader.OneForAllSearch
                    },
                    finalModifications: null,
                    finalEffects: null,
                    endsAt: EndsAt.StartOf.Tenth.Planning,
                    canStack: false,
                    canResetDuration: false,
                    alignment: Alignment.Negative),

                new Buff(
                    name: BehaviourName.Leader.OneForAllHealBuff,
                    displayName: nameof(BehaviourName.Leader.OneForAllHealBuff).CamelCaseToWords(),
                    description: "Heals for 2 Health.",
                    modificationFlags: null,
                    initialModifications: new List<Modification>
                    {
                        new StatModification(
                            change: Change.AddCurrent,
                            amount: 2,
                            stat: Stats.Health)
                    },
                    initialEffects: null,
                    finalModifications: null,
                    finalEffects: null,
                    endsAt: EndsAt.Instant,
                    canStack: false,
                    canResetDuration: false,
                    alignment: Alignment.Positive),
                
                new Buildable(
                    name: BehaviourName.Hut.BuildingBuildable,
                    displayName: nameof(BehaviourName.Hut.BuildingBuildable).CamelCaseToWords(),
                    description: "This building can only be placed on the low ground Scraps tiles, and can be built " +
                                 "by multiple Slaves simultaneously.",
                    placementValidators: new List<Validator>
                    {
                        new(conditions: new List<Condition>
                        {
                            new(conditionFlag: Flag.Condition.TargetIsLowGround)
                        }),
                        new (conditions: new List<Condition>
                        {
                            new EntityCondition(
                                conditionFlag: Flag.Condition.Entity.Exists,
                                conditionedEntity: TileName.Scraps,
                                amountOfEntitiesRequired: 2)
                        })
                    }),
                
                new Buildable(
                    name: BehaviourName.Obelisk.BuildingBuildable,
                    displayName: nameof(BehaviourName.Obelisk.BuildingBuildable).CamelCaseToWords(),
                    description: "This building can only be placed on the low ground Celestium tiles, and can be " +
                                 "built by multiple Slaves simultaneously.",
                    placementValidators: new List<Validator>
                    {
                        new(conditions: new List<Condition>
                        {
                            new(conditionFlag: Flag.Condition.TargetIsLowGround)
                        }),
                        new (conditions: new List<Condition>
                        {
                            new EntityCondition(
                                conditionFlag: Flag.Condition.Entity.Exists,
                                conditionedEntity: TileName.Celestium,
                                amountOfEntitiesRequired: 2)
                        })
                    }),
                
                new Buildable(
                    name: BehaviourName.Shack.BuildingBuildable,
                    displayName: nameof(BehaviourName.Shack.BuildingBuildable).CamelCaseToWords(),
                    description: "This building can only be placed on the low ground and can be built by multiple " +
                                 "Slaves simultaneously.",
                    placementValidators: new List<Validator>
                    {
                        new(conditions: new List<Condition>
                        {
                            new(conditionFlag: Flag.Condition.TargetIsLowGround)
                        })
                    }),
                
                new Buildable(
                    name: BehaviourName.Smith.BuildingBuildable,
                    displayName: nameof(BehaviourName.Smith.BuildingBuildable).CamelCaseToWords(),
                    description: "This building can only be placed on the low ground and can be built by multiple " +
                                 "Slaves simultaneously.",
                    placementValidators: new List<Validator>
                    {
                        new(conditions: new List<Condition>
                        {
                            new(conditionFlag: Flag.Condition.TargetIsLowGround)
                        })
                    }),
                
                new Buildable(
                    name: BehaviourName.Fletcher.BuildingBuildable,
                    displayName: nameof(BehaviourName.Fletcher.BuildingBuildable).CamelCaseToWords(),
                    description: "This building can only be placed on the low ground and can be built by multiple " +
                                 "Slaves simultaneously.",
                    placementValidators: new List<Validator>
                    {
                        new(conditions: new List<Condition>
                        {
                            new(conditionFlag: Flag.Condition.TargetIsLowGround)
                        })
                    }),
                
                new Buildable(
                    name: BehaviourName.Alchemy.BuildingBuildable,
                    displayName: nameof(BehaviourName.Alchemy.BuildingBuildable).CamelCaseToWords(),
                    description: "This building can only be placed on the low ground and can be built by multiple " +
                                 "Slaves simultaneously.",
                    placementValidators: new List<Validator>
                    {
                        new(conditions: new List<Condition>
                        {
                            new(conditionFlag: Flag.Condition.TargetIsLowGround)
                        })
                    }),
                
                new Buildable(
                    name: BehaviourName.Depot.BuildingBuildable,
                    displayName: nameof(BehaviourName.Depot.BuildingBuildable).CamelCaseToWords(),
                    description: "This building can only be placed on the low ground and can be built by multiple " +
                                 "Slaves simultaneously.",
                    placementValidators: new List<Validator>
                    {
                        new(conditions: new List<Condition>
                        {
                            new(conditionFlag: Flag.Condition.TargetIsLowGround)
                        })
                    }),
                
                new Buildable(
                    name: BehaviourName.Workshop.BuildingBuildable,
                    displayName: nameof(BehaviourName.Workshop.BuildingBuildable).CamelCaseToWords(),
                    description: "This building can only be placed on the low ground and can be built by multiple " +
                                 "Slaves simultaneously.",
                    placementValidators: new List<Validator>
                    {
                        new(conditions: new List<Condition>
                        {
                            new(conditionFlag: Flag.Condition.TargetIsLowGround)
                        })
                    }),
                
                new Buildable(
                    name: BehaviourName.Outpost.BuildingBuildable,
                    displayName: nameof(BehaviourName.Outpost.BuildingBuildable).CamelCaseToWords(),
                    description: "This building can only be placed on the low ground and can be built by multiple " +
                                 "Slaves simultaneously.",
                    placementValidators: new List<Validator>
                    {
                        new(conditions: new List<Condition>
                        {
                            new(conditionFlag: Flag.Condition.TargetIsLowGround)
                        })
                    }),
                
                new Buildable(
                    name: BehaviourName.Barricade.BuildingBuildable,
                    displayName: nameof(BehaviourName.Barricade.BuildingBuildable).CamelCaseToWords(),
                    description: "This building can only be placed on the low ground and can be built by multiple " +
                                 "Slaves simultaneously.",
                    placementValidators: new List<Validator>
                    {
                        new(conditions: new List<Condition>
                        {
                            new(conditionFlag: Flag.Condition.TargetIsLowGround)
                        })
                    }),

                new Buff(
                    name: BehaviourName.Slave.RepairStructureBuff,
                    displayName: nameof(BehaviourName.Slave.RepairStructureBuff).CamelCaseToWords(),
                    description: "This structure will be repaired by +1 Health at the start of the planning phase.",
                    modificationFlags: null,
                    initialModifications: null,
                    initialEffects: new List<EffectName>
                    {
                        EffectName.Slave.RepairApplyBehaviourSelf
                    },
                    finalModifications: new List<Modification>
                    {
                        new StatModification(
                            change: Change.AddCurrent,
                            amount: 1,
                            stat: Stats.Health)
                    },
                    finalEffects: null,
                    endsAt: EndsAt.StartOf.Next.Planning,
                    canStack: true,
                    canResetDuration: false,
                    alignment: Alignment.Positive,
                    triggers: new List<Trigger>
                    {
                        new(events: new List<Event>
                        {
                            Event.OriginIsInterrupted
                        })
                    },
                    destroyOnConditionsMet: true),

                new Wait(
                    name: BehaviourName.Slave.RepairWait,
                    displayName: nameof(BehaviourName.Slave.RepairWait).CamelCaseToWords(),
                    description: "Currently repairing a structure.",
                    endsAt: EndsAt.StartOf.Next.Planning),

                new Buff(
                    name: BehaviourName.Slave.ManualLabourBuff,
                    displayName: nameof(BehaviourName.Slave.ManualLabourBuff).CamelCaseToWords(),
                    description: "Slave is working on this Hut to provide +2 Scraps at the start of the planning phase.",
                    modificationFlags: null,
                    initialModifications: null,
                    initialEffects: new List<EffectName>
                    {
                        EffectName.Slave.ManualLabourApplyBehaviourSelf
                    },
                    finalModifications: null,
                    finalEffects: new List<EffectName>
                    {
                        EffectName.Slave.ManualLabourModifyPlayer
                    },
                    endsAt: EndsAt.StartOf.Next.Planning,
                    canStack: false,
                    canResetDuration: false,
                    alignment: Alignment.Positive,
                    triggers: new List<Trigger>
                    {
                        new(events: new List<Event>
                        {
                            Event.OriginIsDestroyed
                        })
                    },
                    destroyOnConditionsMet: true),

                new Wait(
                    name: BehaviourName.Slave.ManualLabourWait,
                    displayName: nameof(BehaviourName.Slave.ManualLabourWait).CamelCaseToWords(),
                    description: "Currently working on a nearby Hut.",
                    endsAt: EndsAt.StartOf.Next.Planning),

                new ExtraAttack(
                    name: BehaviourName.Quickdraw.DoubleshotExtraAttack,
                    displayName: nameof(BehaviourName.Quickdraw.DoubleshotExtraAttack).CamelCaseToWords(),
                    description: "Ranged attacks twice.",
                    attackTypes: new List<Attacks>
                    {
                        Attacks.Ranged
                    }),

                new Buff(
                    name: BehaviourName.Quickdraw.CrippleBuff,
                    displayName: nameof(BehaviourName.Quickdraw.CrippleBuff).CamelCaseToWords(),
                    description: "This unit has only 60% of their maximum Movement (rounded up) and cannot receive healing " +
                                 "from any sources until the end of its action.",
                    modificationFlags: new List<Flag>
                    {
                        Flag.Modification.CannotBeHealed
                    },
                    initialModifications: new List<Modification>
                    {
                        new StatModification(
                            change: Change.MultiplyMax,
                            amount: 0.6f,
                            stat: Stats.Movement)
                    },
                    initialEffects: null,
                    finalModifications: null,
                    finalEffects: null,
                    endsAt: EndsAt.EndOf.This.Action,
                    canStack: false,
                    canResetDuration: true,
                    alignment: Alignment.Negative,
                    triggers: null,
                    destroyOnConditionsMet: false,
                    conditionalEffects: null,
                    restoreChangesOnEnd: true),

                new Buff(
                    name: BehaviourName.Gorger.FanaticSuicideBuff,
                    displayName: nameof(BehaviourName.Gorger.FanaticSuicideBuff).CamelCaseToWords(),
                    description: "Upon getting killed or executing a melee attack Gorger explodes dealing its Melee Damage " +
                                 "to all friendly and enemy units in 1 Distance.",
                    modificationFlags: null,
                    initialModifications: null,
                    initialEffects: null,
                    finalModifications: null,
                    finalEffects: new List<EffectName>
                    {
                        EffectName.Gorger.FanaticSuicideSearch
                    }),

                new Buff(
                    name: BehaviourName.Camou.SilentAssassinBuff,
                    displayName: nameof(BehaviourName.Camou.SilentAssassinBuff).CamelCaseToWords(),
                    description: "This unit is silenced (use of any abilities is disabled).",
                    modificationFlags: new List<Flag>
                    {
                        Flag.Modification.AbilitiesDisabled
                    },
                    initialModifications: null,
                    initialEffects: null,
                    finalModifications: null,
                    finalEffects: null,
                    endsAt: EndsAt.EndOf.Second.Action,
                    canStack: false,
                    canResetDuration: true,
                    alignment: Alignment.Negative,
                    triggers: null,
                    destroyOnConditionsMet: false,
                    conditionalEffects: null,
                    restoreChangesOnEnd: true),

                new Wait(
                    name: BehaviourName.Camou.ClimbWait,
                    displayName: nameof(BehaviourName.Camou.ClimbWait).CamelCaseToWords(),
                    description: "Camou will complete climbing on an adjacent high ground space at the end of this action phase.",
                    endsAt: EndsAt.EndOf.This.ActionPhase),

                new Buff(
                    name: BehaviourName.Camou.ClimbBuff,
                    displayName: nameof(BehaviourName.Camou.ClimbBuff).CamelCaseToWords(),
                    description: "Camou can move down from high ground at the additional cost of 1 Movement.",
                    modificationFlags: new List<Flag>
                    {
                        Flag.Modification.ClimbsDown
                    },
                    initialModifications: null,
                    initialEffects: null,
                    finalModifications: null,
                    finalEffects: null,
                    endsAt: EndsAt.Death,
                    canStack: false,
                    canResetDuration: false,
                    alignment: Alignment.Positive),

                new Wait(
                    name: BehaviourName.Shaman.WondrousGooFeatureWait,
                    displayName: nameof(BehaviourName.Shaman.WondrousGooFeatureWait).CamelCaseToWords(),
                    description: "Effect area will expand at the end of this action phase.",
                    endsAt: EndsAt.EndOf.This.ActionPhase,
                    nextBehaviour: BehaviourName.Shaman.WondrousGooFeatureBuff),

                new Buff(
                    name: BehaviourName.Shaman.WondrousGooFeatureBuff,
                    displayName: nameof(BehaviourName.Shaman.WondrousGooFeatureBuff).CamelCaseToWords(),
                    description: "Effect area will disappear at the end of this action phase.",
                    modificationFlags: null,
                    initialModifications: new List<Modification>
                    {
                        new SizeModification(
                            change: Change.SetMax,
                            amount: 3)
                    },
                    initialEffects: null,
                    finalModifications: null,
                    finalEffects: new List<EffectName>
                    {
                        EffectName.Shaman.WondrousGooDestroy
                    },
                    endsAt: EndsAt.EndOf.This.ActionPhase),

                new Buff(
                    name: BehaviourName.Shaman.WondrousGooBuff,
                    displayName: nameof(BehaviourName.Shaman.WondrousGooBuff).CamelCaseToWords(),
                    description: "Unit has its vision and Attack Distance reduced by 3 (total minimum of 1) " +
                                 "and receives 1 Pure Damage at the start of its turn, at which point the effect ends.",
                    modificationFlags: null,
                    initialModifications: new List<Modification>
                    {
                        new AttackModification(
                            change: Change.SubtractMax,
                            amount: 3,
                            attackType: Attacks.Melee,
                            attribute: AttackAttribute.MaxDistance),
                        new AttackModification(
                            change: Change.SubtractMax,
                            amount: 3,
                            attackType: Attacks.Ranged,
                            attribute: AttackAttribute.MaxDistance)
                    },
                    initialEffects: null,
                    finalModifications: null,
                    finalEffects: new List<EffectName>
                    {
                        EffectName.Shaman.WondrousGooDamage
                    },
                    endsAt: EndsAt.StartOf.Next.Action,
                    canStack: false,
                    canResetDuration: false,
                    alignment: Alignment.Negative,
                    triggers: null,
                    destroyOnConditionsMet: false,
                    conditionalEffects: null,
                    restoreChangesOnEnd: true),

                new Tether(
                    name: BehaviourName.Pyre.CargoTether,
                    displayName: nameof(BehaviourName.Pyre.CargoTether).CamelCaseToWords(),
                    description: "The cargo follows Pyre.",
                    source: Location.Origin,
                    extendsSelection: true,
                    sharedDamage: true,
                    maximumLeashRange: 1,
                    calculatedForSourcePathfinding: true),

                new Buff(
                    name: BehaviourName.Pyre.CargoWallOfFlamesBuff,
                    displayName: nameof(BehaviourName.Pyre.CargoWallOfFlamesBuff).CamelCaseToWords(),
                    description: "The cargo leaves a path of flames when moved, which stay until the start of the next " +
                                 "Pyre's action or until death. Any unit which starts its turn or moves onto the flames receives " +
                                 "5 Melee Damage.",
                    modificationFlags: null,
                    initialModifications: null,
                    initialEffects: null,
                    finalModifications: null,
                    finalEffects: null,
                    endsAt: null,
                    canStack: false,
                    canResetDuration: false,
                    alignment: null,
                    triggers: new List<Trigger>
                    {
                        new(events: new List<Event>
                        {
                            Event.EntityIsAboutToMove
                        })
                    },
                    destroyOnConditionsMet: false,
                    conditionalEffects: new List<EffectName>
                    {
                        EffectName.Pyre.WallOfFlamesCreateEntity
                    }),

                new Buff(
                    name: BehaviourName.Pyre.WallOfFlamesBuff,
                    displayName: nameof(BehaviourName.Pyre.WallOfFlamesBuff).CamelCaseToWords(),
                    description: "",
                    modificationFlags: null,
                    initialModifications: null,
                    initialEffects: null,
                    finalModifications: null,
                    finalEffects: new List<EffectName>
                    {
                        EffectName.Pyre.WallOfFlamesDestroy
                    },
                    endsAt: EndsAt.StartOf.Next.Action,
                    canStack: false,
                    canResetDuration: false,
                    alignment: Alignment.Negative,
                    triggers: new List<Trigger>
                    {
                        new(events: new List<Event>
                        {
                            Event.OriginIsDestroyed
                        })
                    },
                    destroyOnConditionsMet: true,
                    conditionalEffects: new List<EffectName>
                    {
                        EffectName.Pyre.WallOfFlamesDestroy
                    }),

                new Buff(
                    name: BehaviourName.Pyre.PhantomMenaceBuff,
                    displayName: nameof(BehaviourName.Pyre.PhantomMenaceBuff).CamelCaseToWords(),
                    description: "Pyre can move through enemy units (but not buildings).",
                    modificationFlags: new List<Flag>
                    {
                        Flag.Modification.MovesThroughEnemyUnits
                    }),

                new Buff(
                    name: BehaviourName.Roach.DegradingCarapaceBuff,
                    displayName: nameof(BehaviourName.Roach.DegradingCarapaceBuff).CamelCaseToWords(),
                    description: "Increases periodic damage by 1 at the start of each action.",
                    modificationFlags: null,
                    initialModifications: null,
                    initialEffects: null,
                    finalModifications: null,
                    finalEffects: new List<EffectName>
                    {
                        EffectName.Roach.DegradingCarapacePeriodicApplyBehaviour,
                        EffectName.Roach.DegradingCarapaceApplyBehaviour
                    },
                    endsAt: EndsAt.StartOf.Next.Action,
                    canStack: true,
                    canResetDuration: false,
                    alignment: Alignment.Negative),

                new Buff(
                    name: BehaviourName.Roach.DegradingCarapacePeriodicDamageBuff,
                    displayName: nameof(BehaviourName.Roach.DegradingCarapacePeriodicDamageBuff).CamelCaseToWords(),
                    description: "This unit will continue to receive 1 damage at every start of its action.",
                    modificationFlags: null,
                    initialModifications: null,
                    initialEffects: new List<EffectName>
                    {
                        EffectName.Roach.DegradingCarapaceSelfDamage
                    },
                    finalModifications: null,
                    finalEffects: new List<EffectName>
                    {
                        EffectName.Roach.DegradingCarapacePeriodicApplyBehaviour
                    },
                    endsAt: EndsAt.StartOf.Next.Action,
                    canStack: true,
                    canResetDuration: false,
                    alignment: Alignment.Negative),

                new Tether(
                    name: BehaviourName.Parasite.ParalysingGraspTether,
                    displayName: nameof(BehaviourName.Parasite.ParalysingGraspTether).CamelCaseToWords(),
                    description: "This unit is possessed by Parasite. On Parasite turn, it moves both units using the movement " +
                                 "speed that the possessed unit has. Any damage received is shared between both.",
                    source: Location.Inherited,
                    extendsSelection: false,
                    sharedDamage: true,
                    maximumLeashRange: 0,
                    calculatedForSourcePathfinding: true),

                new Buff(
                    name: BehaviourName.Parasite.ParalysingGraspBuff,
                    displayName: nameof(BehaviourName.Parasite.ParalysingGraspBuff).CamelCaseToWords(),
                    description: "This unit is possessed by Parasite. On its turn, the possessed unit controls the attack which it " +
                                 "must do unless there are no legal targets.",
                    modificationFlags: new List<Flag>
                    {
                        Flag.Modification.CanAttackAnyTeam,
                        Flag.Modification.MovementDisabled,
                        Flag.Modification.MustExecuteAttack
                    },
                    initialModifications: null,
                    initialEffects: new List<EffectName>
                    {
                        EffectName.Parasite.ParalysingGraspApplySelfBehaviour
                    },
                    finalModifications: null,
                    finalEffects: null,
                    endsAt: null,
                    canStack: null,
                    canResetDuration: null,
                    alignment: Alignment.Negative,
                    triggers: new List<Trigger>
                    {
                        new(events: new List<Event>
                        {
                            Event.OriginIsDestroyed
                        })
                    },
                    destroyOnConditionsMet: true,
                    conditionalEffects: null,
                    restoreChangesOnEnd: true),

                new Buff(
                    name: BehaviourName.Parasite.ParalysingGraspSelfBuff,
                    displayName: nameof(BehaviourName.Parasite.ParalysingGraspSelfBuff).CamelCaseToWords(),
                    description: "Parasite has possessed the unit on top, gaining its movement speed and the ability to move both " +
                                 "units on Parasite's turn.",
                    modificationFlags: new List<Flag>
                    {
                        Flag.Modification.AbilitiesDisabled,
                        Flag.Modification.CannotAttack
                    },
                    initialModifications: new List<Modification>
                    {
                        new StatCopyModification(
                            change: Change.SetMax,
                            copyFrom: Location.Source,
                            additionalAmount: 0,
                            stat: Stats.Movement)
                    },
                    initialEffects: null,
                    finalModifications: null,
                    finalEffects: null,
                    endsAt: null,
                    canStack: false,
                    canResetDuration: false,
                    alignment: Alignment.Positive,
                    triggers: new List<Trigger>
                    {
                        new(events: new List<Event>
                        {
                            Event.SourceIsDestroyed
                        })
                    },
                    destroyOnConditionsMet: true,
                    conditionalEffects: null,
                    restoreChangesOnEnd: true),

                new Buff(
                    name: BehaviourName.Horrior.ExpertFormationBuff,
                    displayName: nameof(BehaviourName.Horrior.ExpertFormationBuff).CamelCaseToWords(),
                    description: "Range Armour for this unit is increased by 2 because it is in formation with an adjacent Horrior.",
                    modificationFlags: null,
                    initialModifications: new List<Modification>
                    {
                        new StatModification(
                            change: Change.AddMax,
                            amount: 2,
                            stat: Stats.RangedArmour)
                    },
                    initialEffects: null,
                    finalModifications: null,
                    finalEffects: null,
                    endsAt: EndsAt.EndOf.This.ActionPhase,
                    canStack: false,
                    canResetDuration: true,
                    alignment: Alignment.Positive,
                    triggers: null,
                    destroyOnConditionsMet: false,
                    conditionalEffects: null,
                    restoreChangesOnEnd: true),

                new Wait(
                    name: BehaviourName.Horrior.MountWait,
                    displayName: nameof(BehaviourName.Horrior.MountWait).CamelCaseToWords(),
                    description: "This unit is mounting up to transform into Surfer.",
                    endsAt: EndsAt.StartOf.Fourth.Planning,
                    nextBehaviour: BehaviourName.Horrior.MountBuff),

                new Buff(
                    name: BehaviourName.Horrior.MountBuff,
                    displayName: nameof(BehaviourName.Horrior.MountBuff).CamelCaseToWords(),
                    description: "",
                    modificationFlags: null,
                    initialModifications: null,
                    initialEffects: new List<EffectName>
                    {
                        EffectName.Horrior.MountCreateEntity
                    },
                    finalModifications: null,
                    finalEffects: new List<EffectName>
                    {
                        EffectName.Horrior.MountDestroy
                    },
                    endsAt: EndsAt.Instant),

                new Buff(
                    name: BehaviourName.Marksman.CriticalMarkBuff,
                    displayName: nameof(BehaviourName.Marksman.CriticalMarkBuff).CamelCaseToWords(),
                    description: "Marksman has marked this target until the end of the next action phase. The mark " +
                                 "is consumed dealing 5 Melee Damage, when an ally of Marksman attacks this unit.",
                    modificationFlags: null,
                    initialModifications: null,
                    initialEffects: null,
                    finalModifications: null,
                    finalEffects: null,
                    endsAt: EndsAt.EndOf.Next.ActionPhase,
                    canStack: false,
                    canResetDuration: true,
                    alignment: Alignment.Negative,
                    triggers: new List<Trigger>
                    {
                        new(events: new List<Event>
                        {
                            Event.EntityIsAttacked
                        }, validators: new List<Validator>
                        {
                            new(
                                conditions: new List<Condition>
                                {
                                    new(conditionFlag: Flag.Condition.TargetIsDifferentTypeThanOrigin)
                                },
                                filterFlags: new List<Flag>
                                {
                                    Flag.Filter.Enemy,
                                    Flag.Filter.Unit
                                })
                        })
                    },
                    destroyOnConditionsMet: true,
                    conditionalEffects: new List<EffectName>
                    {
                        EffectName.Marksman.CriticalMarkDamage
                    },
                    restoreChangesOnEnd: false),
                
                new Buff(
                    name: BehaviourName.Surfer.DismountBuff,
                    displayName: nameof(BehaviourName.Surfer.DismountBuff).CamelCaseToWords(),
                    description: "Upon death, reemerges as Horrior.",
                    modificationFlags: null,
                    initialModifications: null,
                    initialEffects: null,
                    finalModifications: null,
                    finalEffects: new List<EffectName>
                    {
                        EffectName.Surfer.DismountCreateEntity
                    },
                    endsAt: EndsAt.Death,
                    canStack: false,
                    canResetDuration: false,
                    alignment: Alignment.Positive),
                
                new Ammunition(
                    name: BehaviourName.Mortar.DeadlyAmmunitionAmmunition,
                    displayName: nameof(BehaviourName.Mortar.DeadlyAmmunitionAmmunition).CamelCaseToWords(),
                    description: "Each ranged attack consumes 1 ammo out of 2 total. Cannot range attack when out " +
                                 "of ammo. Each ranged attack deals full Ranged Damage to all adjacent units around the target.",
                    maxAmmunitionAmount: 2, 
                    ammunitionAttackTypes: new List<Attacks>
                    {
                        Attacks.Ranged
                    },
                    ammunitionAmountLostOnHit: 1,
                    onHitEffects: new List<EffectName>
                    {
                        EffectName.Mortar.DeadlyAmmunitionSearch
                    },
                    ammunitionRecoveredOnReload: 2,
                    applyOriginalAttackToTarget: false),
                
                new Wait(
                    name: BehaviourName.Mortar.ReloadWait,
                    displayName: nameof(BehaviourName.Mortar.ReloadWait).CamelCaseToWords(),
                    description: "Mortar will reload its ammunition at the end of this action.",
                    endsAt: EndsAt.EndOf.This.Action,
                    nextBehaviour: BehaviourName.Mortar.ReloadBuff),
                
                new Buff(
                    name: BehaviourName.Mortar.ReloadBuff,
                    displayName: nameof(BehaviourName.Mortar.ReloadBuff).CamelCaseToWords(),
                    description: "",
                    modificationFlags: null,
                    initialModifications: null,
                    initialEffects: new List<EffectName>
                    {
                        EffectName.Mortar.ReloadReload
                    },
                    finalModifications: null,
                    finalEffects: null,
                    endsAt: EndsAt.Instant),
                
                new Buff(
                    name: BehaviourName.Mortar.PiercingBlastBuff,
                    displayName: nameof(BehaviourName.Mortar.PiercingBlastBuff).CamelCaseToWords(),
                    description: "Ranged Armour from the main target is ignored when attacking with Deadly Ammunition.",
                    modificationFlags: null,
                    initialModifications: new List<Modification>
                    {
                        new AttackModification(
                            attackType: Attacks.Ranged, 
                            modificationFlags: new List<Flag>
                            {
                                Flag.Modification.IgnoreArmour
                            })
                    },
                    initialEffects: null,
                    finalModifications: null,
                    finalEffects: null,
                    endsAt: EndsAt.Death,
                    canStack: null,
                    canResetDuration: null,
                    alignment: Alignment.Positive),
                
                new Buff(
                    name: BehaviourName.Hawk.TacticalGogglesBuff,
                    displayName: nameof(BehaviourName.Hawk.TacticalGogglesBuff).CamelCaseToWords(),
                    description: "Gains +3 Vision range.",
                    modificationFlags: null,
                    initialModifications: new List<Modification>
                    {
                        new StatModification(change: Change.AddMax, amount: 3, stat: Stats.Vision)
                    },
                    initialEffects: null,
                    finalModifications: null,
                    finalEffects: null,
                    endsAt: EndsAt.Death,
                    canStack: false,
                    canResetDuration: null,
                    alignment: Alignment.Positive),
                
                new Buff(
                    name: BehaviourName.Hawk.LeadershipBuff,
                    displayName: nameof(BehaviourName.Hawk.LeadershipBuff).CamelCaseToWords(),
                    description: "Gains +1 Attack Distance range from nearby Hawk. Bonus will be lost at the end of " +
                                 "the next action or if Hawk is not adjacent anymore.",
                    modificationFlags: null,
                    initialModifications: new List<Modification>
                    {
                        new AttackModification(
                            change: Change.AddMax, 
                            amount: 1, 
                            attackType: Attacks.Ranged, 
                            attribute: AttackAttribute.MaxDistance)
                    },
                    initialEffects: null,
                    finalModifications: null,
                    finalEffects: null,
                    endsAt: EndsAt.EndOf.This.Action,
                    canStack: false,
                    canResetDuration: null,
                    alignment: Alignment.Positive,
                    triggers: new List<Trigger>
                    {
                        new(events: new List<Event>
                        {
                            Event.SourceIsNotAdjacent
                        })
                    },
                    destroyOnConditionsMet: true,
                    conditionalEffects: null,
                    restoreChangesOnEnd: true),
                
                new Buff(
                    name: BehaviourName.Hawk.HealthKitBuff,
                    displayName: nameof(BehaviourName.Hawk.HealthKitBuff).CamelCaseToWords(),
                    description: "Restores 1 Health to all adjacent friendly units at the start of each planning phase.",
                    modificationFlags: null,
                    initialModifications: null,
                    initialEffects: null,
                    finalModifications: null,
                    finalEffects: new List<EffectName>
                    {
                        EffectName.Hawk.HealthKitSearch,
                        EffectName.Hawk.HealthKitApplyBehaviour // Reapply the same buff to achieve periodic effect
                    },
                    endsAt: EndsAt.StartOf.Next.Planning,
                    canStack: true, // Only needed because final effects happen right before this behaviour is destroyed
                    canResetDuration: null,
                    alignment: Alignment.Positive),
                
                new Buff(
                    name: BehaviourName.Hawk.HealthKitHealBuff,
                    displayName: nameof(BehaviourName.Hawk.HealthKitHealBuff).CamelCaseToWords(),
                    description: "Heals for 1 Health.",
                    modificationFlags: null,
                    initialModifications: new List<Modification>
                    {
                        new StatModification(
                            change: Change.AddCurrent,
                            amount: 1,
                            stat: Stats.Health)
                    },
                    initialEffects: null,
                    finalModifications: null,
                    finalEffects: null,
                    endsAt: EndsAt.Instant,
                    canStack: false,
                    canResetDuration: false,
                    alignment: Alignment.Positive),
                
                new Buildable(
                    name: BehaviourName.Cannon.AssemblingBuildable,
                    displayName: nameof(BehaviourName.Cannon.AssemblingBuildable).CamelCaseToWords(),
                    description: "This machine can only be placed on the low ground and can be assembled by a maximum of " +
                                 "3 Engineers at once.",
                    placementValidators: new List<Validator>
                    {
                        new(conditions: new List<Condition>
                        {
                            new(conditionFlag: Flag.Condition.TargetIsLowGround)
                        })
                    },
                    maximumHelpers: 3),
                
                new Buildable(
                    name: BehaviourName.Ballista.AssemblingBuildable,
                    displayName: nameof(BehaviourName.Ballista.AssemblingBuildable).CamelCaseToWords(),
                    description: "This machine can only be placed on a Watchtower and can be assembled by a maximum of " +
                                 "1 Engineer at once.",
                    placementValidators: new List<Validator>
                    {
                        new(conditions: new List<Condition>
                        {
                            new BehaviourCondition(
                                conditionFlag: Flag.Condition.Behaviour.Exists,
                                conditionedBehaviour: BehaviourName.Ballista.AimBuff) // TODO change when the Watchtower structure has
                                                                // the appropriate behaviour created or use the
                                                                // entity behaviour
                        })
                    },
                    maximumHelpers: 1),
                
                new Buildable(
                    name: BehaviourName.Radar.AssemblingBuildable,
                    displayName: nameof(BehaviourName.Radar.AssemblingBuildable).CamelCaseToWords(),
                    description: "This machine can only be placed on the low ground and can be assembled by a maximum of " +
                                 "1 Engineer at once.",
                    placementValidators: new List<Validator>
                    {
                        new(conditions: new List<Condition>
                        {
                            new(conditionFlag: Flag.Condition.TargetIsLowGround)
                        })
                    },
                    maximumHelpers: 1),
                
                new Buff(
                    name: BehaviourName.Engineer.OperateBuff,
                    displayName: nameof(BehaviourName.Engineer.OperateBuff).CamelCaseToWords(),
                    description: "",
                    modificationFlags: null,
                    initialModifications: null,
                    initialEffects: new List<EffectName>
                    {
                        EffectName.Engineer.OperateModifyCounter
                    },
                    finalModifications: null,
                    finalEffects: new List<EffectName>
                    {
                        EffectName.Engineer.OperateDestroy
                    },
                    endsAt: EndsAt.Instant),
                
                new Buff(
                    name: BehaviourName.Engineer.RepairStructureOrMachineBuff,
                    displayName: nameof(BehaviourName.Engineer.RepairStructureOrMachineBuff).CamelCaseToWords(),
                    description: "This structure or machine will be repaired by +2 Health at the start of the planning phase.",
                    modificationFlags: null,
                    initialModifications: null,
                    initialEffects: new List<EffectName>
                    {
                        EffectName.Engineer.RepairApplyBehaviourSelf
                    },
                    finalModifications: new List<Modification>
                    {
                        new StatModification(
                            change: Change.AddCurrent,
                            amount: 1,
                            stat: Stats.Health)
                    },
                    finalEffects: null,
                    endsAt: EndsAt.StartOf.Next.Planning,
                    canStack: true,
                    canResetDuration: false,
                    alignment: Alignment.Positive,
                    triggers: new List<Trigger>
                    {
                        new(events: new List<Event>
                        {
                            Event.OriginIsInterrupted
                        })
                    },
                    destroyOnConditionsMet: true),
                
                new Buff(
                    name: BehaviourName.Engineer.RepairHorriorBuff,
                    displayName: nameof(BehaviourName.Engineer.RepairHorriorBuff).CamelCaseToWords(),
                    description: "This Horrior will have their Mount duration reduced by one turn at the start of the " +
                                 "planning phase.",
                    modificationFlags: null,
                    initialModifications: null,
                    initialEffects: new List<EffectName>
                    {
                        EffectName.Engineer.RepairApplyBehaviourSelf
                    },
                    finalModifications: new List<Modification>
                    {
                        new DurationModification(
                            change: Change.SubtractCurrent, 
                            amount: 1f,
                            behaviourToModify: BehaviourName.Horrior.MountWait)
                    },
                    finalEffects: null,
                    endsAt: EndsAt.StartOf.Next.Planning,
                    canStack: true,
                    canResetDuration: false,
                    alignment: Alignment.Positive,
                    triggers: new List<Trigger>
                    {
                        new(events: new List<Event>
                        {
                            Event.OriginIsInterrupted
                        })
                    },
                    destroyOnConditionsMet: true),

                new Wait(
                    name: BehaviourName.Engineer.RepairWait,
                    displayName: nameof(BehaviourName.Engineer.RepairWait).CamelCaseToWords(),
                    description: "Currently repairing.",
                    endsAt: EndsAt.StartOf.Next.Planning),
                
                new Counter(
                    name: BehaviourName.Cannon.MachineCounter,
                    displayName: nameof(BehaviourName.Cannon.MachineCounter).CamelCaseToWords(),
                    description: "Needs 3 Engineers to operate this machine.",
                    maxAmount: 3,
                    triggerAmount: 3,
                    triggeredEffects: new List<EffectName>
                    {
                        EffectName.Cannon.MachineRemoveBehaviour
                    }),
                
                new Buff(
                    name: BehaviourName.Cannon.MachineBuff,
                    displayName: nameof(BehaviourName.Cannon.MachineBuff).CamelCaseToWords(),
                    description: "This machine is disabled until it is fully operated by the required number of Engineers.",
                    modificationFlags: new List<Flag>
                    {
                        Flag.Modification.FullyDisabled
                    },
                    initialModifications: null,
                    initialEffects: null,
                    finalModifications: null,
                    finalEffects: null,
                    endsAt: EndsAt.Death,
                    canStack: false,
                    canResetDuration: null,
                    alignment: Alignment.Negative,
                    triggers: null,
                    destroyOnConditionsMet: false,
                    conditionalEffects: null,
                    restoreChangesOnEnd: true),
                
                new Buff(
                    name: BehaviourName.Cannon.HeatUpDangerZoneBuff,
                    displayName: nameof(BehaviourName.Cannon.HeatUpDangerZoneBuff).CamelCaseToWords(),
                    description: "This tile will receive massive damage on the next Cannon's turn. Until then, Cannon's " +
                                 "owner has vision of this tile.",
                    modificationFlags: new List<Flag>
                    {
                        Flag.Modification.ProvidesVision
                    },
                    initialModifications: new List<Modification>
                    {
                        new StatModification(change: Change.SetCurrent, amount: 1, stat: Stats.Vision)
                    },
                    initialEffects: new List<EffectName>
                    {
                        EffectName.Cannon.HeatUpApplyWaitBehaviour
                    },
                    finalModifications: null,
                    finalEffects: new List<EffectName>
                    {
                        EffectName.Cannon.HeatUpSearch,
                        EffectName.Cannon.HeatUpDestroy
                    },
                    endsAt: EndsAt.EndOf.Next.Action,
                    canStack: false,
                    canResetDuration: false,
                    alignment: Alignment.Positive,
                    triggers: new List<Trigger>
                    {
                        new(events: new List<Event>
                        {
                            Event.OriginIsInterrupted
                        }),
                        new(events: new List<Event>
                        {
                            Event.OriginIsDestroyed
                        })
                    },
                    destroyOnConditionsMet: true,
                    conditionalEffects: new List<EffectName>
                    {
                        EffectName.Cannon.MachineRemoveBehaviour,
                        EffectName.Cannon.HeatUpDestroy
                    },
                    restoreChangesOnEnd: true),
                
                new Wait(
                    name: BehaviourName.Cannon.HeatUpWait,
                    displayName: nameof(BehaviourName.Cannon.HeatUpWait).CamelCaseToWords(),
                    description: "This Cannon is heating up for a blast at the danger zone.",
                    endsAt: EndsAt.EndOf.Next.Action),
                
                new Counter(
                    name: BehaviourName.Ballista.MachineCounter,
                    displayName: nameof(BehaviourName.Ballista.MachineCounter).CamelCaseToWords(),
                    description: "Needs 1 Engineer to operate this machine.",
                    maxAmount: 3,
                    triggerAmount: 3,
                    triggeredEffects: new List<EffectName>
                    {
                        EffectName.Ballista.MachineRemoveBehaviour
                    }),
                
                new Buff(
                    name: BehaviourName.Ballista.MachineBuff,
                    displayName: nameof(BehaviourName.Ballista.MachineBuff).CamelCaseToWords(),
                    description: "This machine is disabled until it is fully operated by the required number of Engineers.",
                    modificationFlags: new List<Flag>
                    {
                        Flag.Modification.FullyDisabled
                    },
                    initialModifications: null,
                    initialEffects: null,
                    finalModifications: null,
                    finalEffects: null,
                    endsAt: EndsAt.Death,
                    canStack: false,
                    canResetDuration: null,
                    alignment: Alignment.Negative,
                    triggers: null,
                    destroyOnConditionsMet: false,
                    conditionalEffects: null,
                    restoreChangesOnEnd: true),
                
                new Buff(
                    name: BehaviourName.Ballista.AimBuff,
                    displayName: nameof(BehaviourName.Ballista.AimBuff).CamelCaseToWords(),
                    description: "This unit is aimed by a Ballista, which allows it to shoot every turn as long as this " +
                                 "unit remains in range.",
                    modificationFlags: null,
                    initialModifications: null,
                    initialEffects: null,
                    finalModifications: null,
                    finalEffects: null,
                    endsAt: EndsAt.EndOf.Next.ActionPhase,
                    canStack: false,
                    canResetDuration: true,
                    alignment: Alignment.Negative,
                    triggers: new List<Trigger>
                    {
                        new(events: new List<Event>
                        {
                            Event.EntityFinishedMoving
                        },validators: new List<Validator> 
                        {
                            new ResultValidator(
                                searchEffect: EffectName.Ballista.AimSearch, 
                                conditions: new List<Condition>
                                {
                                    new(conditionFlag: Flag.Condition.NoActorsFoundFromEffect)
                                })
                        }),
                        new(events: new List<Event>
                        {
                            Event.OriginIsDestroyed
                        })
                    },
                    destroyOnConditionsMet: true,
                    conditionalEffects: null,
                    restoreChangesOnEnd: null,
                    ownerAllowed: true,
                    hasSameInstanceForAllOwners: false),
                
                new Counter(
                    name: BehaviourName.Radar.MachineCounter,
                    displayName: nameof(BehaviourName.Radar.MachineCounter).CamelCaseToWords(),
                    description: "Needs 1 Engineer to operate this machine.",
                    maxAmount: 3,
                    triggerAmount: 3,
                    triggeredEffects: new List<EffectName>
                    {
                        EffectName.Radar.MachineRemoveBehaviour
                    }),
                
                new Buff(
                    name: BehaviourName.Radar.MachineBuff,
                    displayName: nameof(BehaviourName.Radar.MachineBuff).CamelCaseToWords(),
                    description: "This machine is disabled until it is fully operated by the required number of Engineers.",
                    modificationFlags: new List<Flag>
                    {
                        Flag.Modification.FullyDisabled
                    },
                    initialModifications: null,
                    initialEffects: null,
                    finalModifications: null,
                    finalEffects: null,
                    endsAt: EndsAt.Death,
                    canStack: false,
                    canResetDuration: null,
                    alignment: Alignment.Negative,
                    triggers: null,
                    destroyOnConditionsMet: false,
                    conditionalEffects: null,
                    restoreChangesOnEnd: true),
                
                new Buff(
                    name: BehaviourName.Radar.PowerDependencyBuff,
                    displayName: nameof(BehaviourName.Radar.PowerDependencyBuff).CamelCaseToWords(),
                    description: "If this unit is not connected to Power, all abilities get disabled and it loses 1 Health " +
                                 "at the start of its action.",
                    modificationFlags: null,
                    initialModifications: null,
                    initialEffects: null,
                    finalModifications: null,
                    finalEffects: null,
                    endsAt: EndsAt.Death,
                    canStack: false,
                    canResetDuration: false,
                    alignment: Alignment.Neutral,
                    triggers: new List<Trigger>
                    {
                        new(events: new List<Event>
                        {
                            Event.EntityStartsActionNotOnPower
                        })
                    },
                    destroyOnConditionsMet: false,
                    conditionalEffects: new List<EffectName>
                    {
                        EffectName.Radar.PowerDependencyDamage,
                        EffectName.Radar.PowerDependencyApplyBehaviourDisable,
                    }),
                
                new Buff(
                    name: BehaviourName.Radar.PowerDependencyBuffDisable,
                    displayName: nameof(BehaviourName.Radar.PowerDependencyBuffDisable).CamelCaseToWords(),
                    description: "All abilities are disabled because Power is not supplied.",
                    modificationFlags: new List<Flag>
                    {
                        Flag.Modification.AbilitiesDisabled
                    },
                    initialModifications: null,
                    initialEffects: null,
                    finalModifications: null,
                    finalEffects: null,
                    endsAt: EndsAt.StartOf.Next.ActionPhase,
                    canStack: false,
                    canResetDuration: true,
                    alignment: Alignment.Negative,
                    triggers: new List<Trigger>
                    {
                        new(events: new List<Event>
                        {
                            Event.EntityReceivedPower
                        })
                    },
                    destroyOnConditionsMet: true,
                    conditionalEffects: null,
                    restoreChangesOnEnd: true),
                
                new Buff(
                    name: BehaviourName.Radar.ResonatingSweepBuff,
                    displayName: nameof(BehaviourName.Radar.ResonatingSweepBuff).CamelCaseToWords(),
                    description: "Provides vision to the Radar's owner.",
                    modificationFlags: new List<Flag>
                    {
                        Flag.Modification.ProvidesVision
                    },
                    initialModifications: new List<Modification>
                    {
                        new StatModification(change: Change.SetCurrent, amount: 1, stat: Stats.Vision)
                    },
                    initialEffects: null,
                    finalModifications: null,
                    finalEffects: new List<EffectName>
                    {
                        EffectName.Radar.ResonatingSweepDestroy
                    },
                    endsAt: EndsAt.StartOf.Next.Planning,
                    canStack: false,
                    canResetDuration: false,
                    alignment: Alignment.Positive),
                
                new Buff(
                    name: BehaviourName.Radar.RadioLocationBuff,
                    displayName: nameof(BehaviourName.Radar.RadioLocationBuff).CamelCaseToWords(),
                    description: "",
                    modificationFlags: null,
                    initialModifications: null,
                    initialEffects: new List<EffectName>
                    {
                        EffectName.Radar.RadioLocationSearchDestroy
                    },
                    finalModifications: null,
                    finalEffects: new List<EffectName>
                    {
                        EffectName.Radar.RadioLocationSearchCreate
                    },
                    endsAt: EndsAt.Instant,
                    canStack: false,
                    canResetDuration: false),
                
                new Buff(
                    name: BehaviourName.Radar.RadioLocationFeatureBuff,
                    displayName: nameof(BehaviourName.Radar.RadioLocationFeatureBuff).CamelCaseToWords(),
                    description: "This red dot is able to detect enemy units in the fog of war.",
                    modificationFlags: new List<Flag>
                    {
                        Flag.Modification.OnlyVisibleToAllies,
                        Flag.Modification.OnlyVisibleInFogOfWar
                    },
                    initialModifications: null,
                    initialEffects: null,
                    finalModifications: null,
                    finalEffects: new List<EffectName>
                    {
                        EffectName.Radar.RadioLocationDestroy
                    },
                    endsAt: EndsAt.EndOf.This.Planning),
                
                new Counter(
                    name: BehaviourName.Vessel.MachineCounter,
                    displayName: nameof(BehaviourName.Vessel.MachineCounter).CamelCaseToWords(),
                    description: "Needs 3 Engineers to operate this machine.",
                    maxAmount: 3,
                    triggerAmount: 3,
                    triggeredEffects: new List<EffectName>
                    {
                        EffectName.Vessel.MachineRemoveBehaviour
                    }),
                
                new Buff(
                    name: BehaviourName.Vessel.MachineBuff,
                    displayName: nameof(BehaviourName.Vessel.MachineBuff).CamelCaseToWords(),
                    description: "This machine is disabled until it is fully operated by the required number of Engineers.",
                    modificationFlags: new List<Flag>
                    {
                        Flag.Modification.FullyDisabled
                    },
                    initialModifications: null,
                    initialEffects: null,
                    finalModifications: null,
                    finalEffects: null,
                    endsAt: EndsAt.Death,
                    canStack: false,
                    canResetDuration: null,
                    alignment: Alignment.Negative,
                    triggers: null,
                    destroyOnConditionsMet: false,
                    conditionalEffects: null,
                    restoreChangesOnEnd: true),

                new InterceptDamage(
                    name: BehaviourName.Vessel.AbsorbentFieldInterceptDamage,
                    displayName: nameof(BehaviourName.Vessel.AbsorbentFieldInterceptDamage).CamelCaseToWords(),
                    description: "The melee and ranged damage this unit receives is reduced by 50%, but this amount is " +
                                 "also dealt to a nearby Vessel.",
                    endsAt: EndsAt.Death,
                    numberOfInterceptions: 0,
                    damageTypes: new List<DamageType>
                    {
                        DamageType.Melee,
                        DamageType.Ranged
                    },
                    amountDealtInstead: null,
                    damageTypeDealtInstead: null,
                    shareWith: Location.Origin,
                    amountShared: new Amount(flat: 0, multiplier: 0.5f),
                    damageTypeShared: null,
                    reduceByTheSharedAmount: true,
                    ownerAllowed: true,
                    hasSameInstanceForAllOwners: false),

                new Buff(
                    name: BehaviourName.Vessel.FortifyDestroyBuff,
                    displayName: nameof(BehaviourName.Vessel.FortifyDestroyBuff).CamelCaseToWords(),
                    description: "Provides +3 Melee Armour and +3 Range Armour to all friendly units until the start " +
                                 "of Vessel's action.",
                    modificationFlags: null,
                    initialModifications: null,
                    initialEffects: null,
                    finalModifications: null,
                    finalEffects: new List<EffectName>
                    {
                        EffectName.Vessel.FortifyDestroy
                    },
                    endsAt: EndsAt.StartOf.Next.Action,
                    canStack: false,
                    canResetDuration: false,
                    alignment: Alignment.Positive),
                
                new Buff(
                    name: BehaviourName.Vessel.FortifyBuff,
                    displayName: nameof(BehaviourName.Vessel.FortifyBuff).CamelCaseToWords(),
                    description: "Has +3 Melee Armour and +3 Range Armour due to a nearby fortified Vessel",
                    modificationFlags: null,
                    initialModifications: new List<Modification>
                    {
                        new StatModification(
                            change: Change.AddCurrent,
                            amount: 3,
                            stat: Stats.MeleeArmour),
                        new StatModification(
                            change: Change.AddCurrent,
                            amount: 3,
                            stat: Stats.RangedArmour)
                    },
                    initialEffects: null,
                    finalModifications: null,
                    finalEffects: null,
                    endsAt: EndsAt.StartOf.Next.Action,
                    canStack: false,
                    canResetDuration: false,
                    alignment: Alignment.Positive,
                    restoreChangesOnEnd: true),
                
                new Buff(
                    name: BehaviourName.Omen.RenditionPlacementBuff,
                    displayName: nameof(BehaviourName.Omen.RenditionPlacementBuff).CamelCaseToWords(),
                    description: "This unit is about to have its rendition placed in a 3 Attack Distance.",
                    modificationFlags: null,
                    initialModifications: null,
                    initialEffects: new List<EffectName>
                    {
                        EffectName.Omen.RenditionPlacementExecuteAbility
                    },
                    finalModifications: null,
                    finalEffects: null,
                    endsAt: EndsAt.Instant,
                    canStack: true,
                    canResetDuration: false,
                    alignment: Alignment.Negative),
                
                new InterceptDamage(
                    name: BehaviourName.Omen.RenditionInterceptDamage,
                    displayName: nameof(BehaviourName.Omen.RenditionPlacementBuff).CamelCaseToWords(),
                    description: "50% of any damage dealt will be dealt as Pure Damage to the unit that was the target of " +
                                 "this rendition.",
                    endsAt: EndsAt.Death,
                    numberOfInterceptions: 0,
                    damageTypes: null,
                    amountDealtInstead: null,
                    damageTypeDealtInstead: null,
                    shareWith: Location.Source,
                    amountShared: new Amount(
                        flat: 0, 
                        multiplier: 0.5f),
                    damageTypeShared: DamageType.Pure),
                
                new Buff(
                    name: BehaviourName.Omen.RenditionBuffTimer,
                    displayName: nameof(BehaviourName.Omen.RenditionBuffTimer).CamelCaseToWords(),
                    description: "The rendition stays for 2 action phases and disappears afterwards.",
                    modificationFlags: null,
                    initialModifications: null,
                    initialEffects: null,
                    finalModifications: null,
                    finalEffects: new List<EffectName>
                    {
                        EffectName.Omen.RenditionDestroy
                    },
                    endsAt: EndsAt.EndOf.Next.ActionPhase,
                    canStack: false,
                    canResetDuration: false,
                    alignment: Alignment.Negative,
                    triggers: new List<Trigger>
                    {
                        new(events: new List<Event>
                        {
                            Event.SourceIsDestroyed
                        })
                    },
                    destroyOnConditionsMet: true,
                    conditionalEffects: new List<EffectName>
                    {
                        EffectName.Omen.RenditionDestroy
                    }),
                
                new Buff(
                    name: BehaviourName.Omen.RenditionBuffDeath,
                    displayName: nameof(BehaviourName.Omen.RenditionBuffDeath).CamelCaseToWords(),
                    description: "The unit that was the target of this rendition will emit a blast if this rendition " +
                                 "is destroyed. This blast would deal 10 Melee Damage and slow all adjacent enemy units by 50% " +
                                 "until the end of their next action.",
                    modificationFlags: null,
                    initialModifications: null,
                    initialEffects: null,
                    finalModifications: null,
                    finalEffects: new List<EffectName>
                    {
                        EffectName.Omen.RenditionSearch
                    },
                    endsAt: EndsAt.Death,
                    canStack: false,
                    canResetDuration: false,
                    alignment: Alignment.Positive),
                
                new Buff(
                    name: BehaviourName.Omen.RenditionBuffDeath,
                    displayName: nameof(BehaviourName.Omen.RenditionBuffDeath).CamelCaseToWords(),
                    description: "This unit is slowed by 50% until the end of its next action.",
                    modificationFlags: null,
                    initialModifications: new List<Modification>
                    {
                        new StatModification(
                            change: Change.MultiplyMax, 
                            amount: 0.5f, 
                            stat: Stats.Movement)
                    },
                    initialEffects: null,
                    finalModifications: null,
                    finalEffects: null,
                    endsAt: EndsAt.EndOf.Next.Action,
                    canStack: false,
                    canResetDuration: true,
                    alignment: Alignment.Negative,
                    triggers: null,
                    destroyOnConditionsMet: null,
                    conditionalEffects: null,
                    restoreChangesOnEnd: true)
            };
        }
    }
}