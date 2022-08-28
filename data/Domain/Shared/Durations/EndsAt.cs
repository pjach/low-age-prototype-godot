﻿using System.Collections.Generic;
using low_age_data.Common;
using low_age_data.Domain.Behaviours;
using low_age_data.Domain.Entities.Actors;
using low_age_data.Domain.Entities.Features;

namespace low_age_data.Domain.Shared.Durations
{
    /// <summary>
    /// Used to calculate duration. Calculation is done on the last <see cref="Actor"/> in the chain (e.g. when
    /// an <see cref="Actor"/> creates a <see cref="Feature"/> and there is a <see cref="Buff"/> with
    /// EndsAt.EndOf.Next.Action, this then refers to the <see cref="Actor"/>'s action), unless stated otherwise.
    /// </summary>
    public class EndsAt : ValueObject<EndsAt>
    {
        public override string ToString()
        {
            return $"{nameof(EndsAt)}.{Value}";
        }

        public static EndsAt Death => new(Durations.Death);
        public static EndsAt Instant => new(Durations.Instant);

        public static class StartOf
        {
            public static class Next
            {
                public static EndsAt Planning => new(Durations.StartOfNextPlanning);
                public static EndsAt ActionPhase => new(Durations.StartOfNextActionPhase);
                public static EndsAt Action => new(Durations.StartOfNextAction);
            }

            public static class Second
            {
                public static EndsAt Planning => new(Durations.StartOfSecondPlanning);
                public static EndsAt ActionPhase => new(Durations.StartOfSecondActionPhase);
                public static EndsAt Action => new(Durations.StartOfSecondAction);
            }

            public static class Third
            {
                public static EndsAt Planning => new(Durations.StartOfThirdPlanning);
                public static EndsAt ActionPhase => new(Durations.StartOfThirdActionPhase);
                public static EndsAt Action => new(Durations.StartOfThirdAction);
            }

            public static class Fourth
            {
                public static EndsAt Planning => new(Durations.StartOfFourthPlanning);
                public static EndsAt ActionPhase => new(Durations.StartOfFourthActionPhase);
                public static EndsAt Action => new(Durations.StartOfFourthAction);
            }

            public static class Tenth
            {
                public static EndsAt Planning => new(Durations.StartOfTenthPlanning);
            }
        }

        public static class EndOf
        {
            public static class This
            {
                public static EndsAt Planning => new(Durations.EndOfThisPlanning);
                public static EndsAt ActionPhase => new(Durations.EndOfThisActionPhase);
                public static EndsAt Action => new(Durations.EndOfThisAction);
            }

            public static class Next
            {
                public static EndsAt Planning => new(Durations.EndOfNextPlanning);
                public static EndsAt ActionPhase => new(Durations.EndOfNextActionPhase);
                public static EndsAt Action => new(Durations.EndOfNextAction);
            }

            public static class Second
            {
                public static EndsAt Planning => new(Durations.EndOfSecondPlanning);
                public static EndsAt ActionPhase => new(Durations.EndOfSecondActionPhase);
                public static EndsAt Action => new(Durations.EndOfSecondAction);
            }

            public static class Third
            {
                public static EndsAt Planning => new(Durations.EndOfThirdPlanning);
                public static EndsAt ActionPhase => new(Durations.EndOfThirdActionPhase);
                public static EndsAt Action => new(Durations.EndOfThirdAction);
            }

            public static class Fourth
            {
                public static EndsAt Planning => new(Durations.EndOfFourthPlanning);
                public static EndsAt ActionPhase => new(Durations.EndOfFourthActionPhase);
                public static EndsAt Action => new(Durations.EndOfFourthAction);
            }
        }

        private EndsAt(Durations @enum)
        {
            Value = @enum;
        }

        private Durations Value { get; }

        private enum Durations
        {
            Death,
            Instant,
            StartOfNextPlanning,
            StartOfNextActionPhase,
            StartOfNextAction,
            StartOfSecondPlanning,
            StartOfSecondActionPhase,
            StartOfSecondAction,
            StartOfThirdPlanning,
            StartOfThirdActionPhase,
            StartOfThirdAction,
            StartOfFourthPlanning,
            StartOfFourthActionPhase,
            StartOfFourthAction,
            StartOfTenthPlanning,
            EndOfThisPlanning,
            EndOfThisActionPhase,
            EndOfThisAction,
            EndOfNextPlanning,
            EndOfNextActionPhase,
            EndOfNextAction,
            EndOfSecondPlanning,
            EndOfSecondActionPhase,
            EndOfSecondAction,
            EndOfThirdPlanning,
            EndOfThirdActionPhase,
            EndOfThirdAction,
            EndOfFourthPlanning,
            EndOfFourthActionPhase,
            EndOfFourthAction
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
