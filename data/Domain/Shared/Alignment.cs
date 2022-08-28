﻿using System.Collections.Generic;
using low_age_data.Common;

namespace low_age_data.Domain.Shared
{
    public class Alignment : ValueObject<Alignment>
    {
        public override string ToString()
        {
            return $"{nameof(Alignment)}.{Value}";
        }

        public static Alignment Positive => new(Alignments.Positive);
        public static Alignment Neutral => new(Alignments.Neutral);
        public static Alignment Negative => new(Alignments.Negative);

        private Alignment(Alignments @enum)
        {
            Value = @enum;
        }

        private Alignments Value { get; }

        private enum Alignments
        {
            Positive,
            Neutral,
            Negative
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
