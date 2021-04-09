﻿using System.Collections.Generic;
using low_age_data.Domain.Behaviours;
using low_age_data.Domain.Effects;
using low_age_data.Domain.Shared;
using low_age_data.Domain.Shared.Conditions;
using low_age_data.Domain.Shared.Flags;
using low_age_data.Domain.Shared.Modifications;

namespace low_age_data.Collections
{
    public static class Effects
    {
        public static List<Effect> Get()
        {
            return new List<Effect>
            {
                new ApplyBehaviour(
                    EffectName.Leader.AllForOneApplyBehaviour,
                    new List<BehaviourName>
                    {
                        BehaviourName.Leader.AllForOneBuff
                    },
                    Location.Self,
                    new List<Flag>
                    {
                        Flag.Filter.Self
                    }),

                new ModifyPlayer(
                    EffectName.Leader.AllForOnePlayerLoses,
                    new List<Flag>
                    {
                        Flag.Filter.Self
                    },
                    new List<Flag>
                    {
                        Flag.Effect.ModifyPlayer.GameLost
                    }),

                new Search(
                    EffectName.Leader.MenacingPresenceSearch,
                    6,
                    new List<Flag>
                    {
                        Flag.Effect.Search.AppliedOnEnter,
                        Flag.Effect.Search.AppliedOnAction,
                        Flag.Effect.Search.RemovedOnExit
                    },
                    new List<Flag>
                    {
                        Flag.Filter.Ally,
                        Flag.Filter.Enemy,
                        Flag.Filter.Unit
                    }, 
                    new List<EffectName>
                    {
                        EffectName.Leader.MenacingPresenceApplyBehaviour
                    },
                    Location.Self),

                new ApplyBehaviour(
                    EffectName.Leader.MenacingPresenceApplyBehaviour,
                    new List<BehaviourName>
                    {
                        BehaviourName.Leader.MenacingPresenceBuff
                    }),

                new ApplyBehaviour(
                    EffectName.Leader.OneForAllApplyBehaviourObelisk,
                    new List<BehaviourName>
                    {
                        BehaviourName.Leader.OneForAllObeliskBuff
                    },
                    Location.Actor,
                    new List<Flag>
                    {
                        Flag.Filter.Ally,
                        Flag.Filter.Structure,
                        Flag.Structure.Obelisk
                    },
                    new List<Condition>
                    {
                        Condition.Behaviour.DoesNotAlreadyExist
                    }),

                new Search(
                    EffectName.Leader.OneForAllSearch,
                    1,
                    new List<Flag>(),
                    new List<Flag>
                    {
                        Flag.Filter.Ally,
                        Flag.Filter.Unit
                    },
                    new List<EffectName>
                    {
                        EffectName.Leader.OneForAllApplyBehaviourHeal
                    },
                    Location.Self,
                    Shape.Map),

                new ApplyBehaviour(
                    EffectName.Leader.OneForAllApplyBehaviourHeal,
                    new List<BehaviourName>
                    {
                        BehaviourName.Leader.OneForAllHealBuff
                    },
                    Location.Self),

                new ApplyBehaviour(
                    EffectName.Slave.RepairApplyBehaviourStructure,
                    new List<BehaviourName>
                    {
                        BehaviourName.Slave.RepairStructureBuff
                    },
                    Location.Actor,
                    new List<Flag>
                    {
                        Flag.Filter.Ally,
                        Flag.Filter.Structure
                    },
                    new List<Condition>
                    {
                        Condition.Target.DoesNotHaveFullHealth
                    }),

                new ApplyBehaviour(
                    EffectName.Slave.RepairApplyBehaviourSelf,
                    new List<BehaviourName>
                    {
                        BehaviourName.Slave.RepairWait
                    },
                    Location.Origin),

                new ApplyBehaviour(
                    EffectName.Slave.ManualLabourApplyBehaviourHut,
                    new List<BehaviourName>
                    {
                        BehaviourName.Slave.ManualLabourBuff
                    },
                    Location.Actor,
                    new List<Flag>
                    {
                        Flag.Filter.Ally,
                        Flag.Filter.Structure,
                        Flag.Structure.Hut
                    },
                    new List<Condition>
                    {
                        Condition.Behaviour.DoesNotAlreadyExist
                    }),

                new ApplyBehaviour(
                    EffectName.Slave.ManualLabourApplyBehaviourSelf,
                    new List<BehaviourName>
                    {
                        BehaviourName.Slave.ManualLabourWait
                    },
                    Location.Origin),

                new ModifyPlayer(
                    EffectName.Slave.ManualLabourModifyPlayer,
                    new List<Flag>
                    {
                        Flag.Filter.Self
                    },
                    null,
                    new List<ResourceModification>
                    {
                        new ResourceModification(
                            Change.AddCurrent, 
                            2.0f,
                            Resources.Scraps)
                    }),

                new ApplyBehaviour(
                    EffectName.Quickdraw.DoubleshotApplyBehaviour,
                    new List<BehaviourName>
                    {
                        BehaviourName.Quickdraw.DoubleshotExtraAttack
                    },
                    Location.Self,
                    new List<Flag>
                    {
                        Flag.Filter.Self
                    }),

                new ApplyBehaviour(
                    EffectName.Quickdraw.CrippleApplyBehaviour,
                    new List<BehaviourName>
                    {
                        BehaviourName.Quickdraw.CrippleBuff
                    },
                    Location.Actor,
                    new List<Flag>
                    {
                        Flag.Filter.Enemy,
                        Flag.Filter.Unit
                    }),

                new ApplyBehaviour(
                    EffectName.Gorger.FanaticSuicideApplyBehaviourBuff,
                    new List<BehaviourName>
                    {
                        BehaviourName.Gorger.FanaticSuicideBuff
                    },
                    Location.Self,
                    new List<Flag>
                    {
                        Flag.Filter.Self
                    }),

                new ApplyBehaviour(
                    EffectName.Gorger.FanaticSuicideApplyBehaviourDestroy,
                    new List<BehaviourName>
                    {
                        BehaviourName.Gorger.FanaticSuicideDestroy
                    },
                    Location.Origin),

                new Search(
                    EffectName.Gorger.FanaticSuicideSearch,
                    1,
                    new List<Flag>(),
                    new List<Flag>
                    {
                        Flag.Filter.Ally,
                        Flag.Filter.Enemy,
                        Flag.Filter.Structure,
                        Flag.Filter.Unit
                    },
                    new List<EffectName>
                    {
                        EffectName.Gorger.FanaticSuicideDamage
                    },
                    Location.Self),

                new Damage(
                    EffectName.Gorger.FanaticSuicideDamage,
                    DamageType.CurrentMelee)
            };
        }
    }
}
