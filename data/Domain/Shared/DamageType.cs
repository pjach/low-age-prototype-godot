﻿using System.Collections.Generic;
using low_age_data.Common;
using low_age_data.Domain.Entities.Actors;

namespace low_age_data.Domain.Shared
{
    public class DamageType : ValueObject<DamageType>
    {
        public override string ToString()
        {
            return $"{nameof(DamageType)}.{Value}";
        }

        /// <summary>
        /// Deals damage subtracted by melee armour of the target.
        /// </summary>
        public static DamageType Melee => new(DamageTypes.Melee);
        
        /// <summary>
        /// Deals damage subtracted by ranged armour of the target.
        /// </summary>
        public static DamageType Ranged => new(DamageTypes.Ranged);
        
        /// <summary>
        /// Deals damage directly to health.
        /// </summary>
        public static DamageType Pure => new(DamageTypes.Pure);
        
        /// <summary>
        /// Any damage amount is added to the source's current melee attack damage (includes bonus). Source is the
        /// first valid <see cref="Actor"/> in the chain.
        /// </summary>
        public static DamageType CurrentMelee => new(DamageTypes.CurrentMelee);
        
        /// <summary>
        /// Any damage amount is added to the source's current ranged attack damage (includes bonus). Source is the
        /// first valid <see cref="Actor"/> in the chain.
        /// </summary>
        public static DamageType CurrentRanged => new(DamageTypes.CurrentRanged);
        
        /// <summary>
        /// Any damage amount is overwritten by the source's current melee attack damage (includes bonus).
        /// </summary>
        public static DamageType OverrideMelee => new(DamageTypes.OverrideMelee);
        
        /// <summary>
        /// Any damage amount is overwritten by the source's current ranged attack damage (includes bonus).
        /// </summary>
        public static DamageType OverrideRanged => new(DamageTypes.OverrideRanged);

        /// <summary>
        /// Any damage amount is overwritten by the target's current melee attack damage (includes bonus).
        /// </summary>
        public static DamageType TargetMelee => new(DamageTypes.TargetMelee);

        /// <summary>
        /// Any damage amount is overwritten by the target's current ranged attack damage (includes bonus).
        /// </summary>
        public static DamageType TargetRanged => new(DamageTypes.TargetRanged);

        private DamageType(DamageTypes @enum)
        {
            Value = @enum;
        }

        private DamageTypes Value { get; }

        private enum DamageTypes
        {
            Melee,
            Ranged,
            Pure,
            CurrentMelee, 
            CurrentRanged, 
            OverrideMelee, 
            OverrideRanged, 
            TargetMelee, 
            TargetRanged 
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
