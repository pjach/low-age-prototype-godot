﻿using System.Collections.Generic;

namespace low_age_data.Domain.Shared
{
    public class Attacks : ValueObject<Attacks>
    {
        public override string ToString()
        {
            return Value.ToString();
        }

        public static Attacks Melee => new Attacks(AttacksEnum.Melee);
        public static Attacks Ranged => new Attacks(AttacksEnum.Ranged);

        private Attacks(AttacksEnum @enum)
        {
            Value = @enum;
        }

        private AttacksEnum Value { get; }

        private enum AttacksEnum
        {
            Melee = 0,
            Ranged = 1
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
