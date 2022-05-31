using PokeCalc.Domain.DamageCalculator;

namespace PokeCalc.Domain.Stats.Calculator
{
    public sealed class StatsValue : IStatsValue
    {
        int IStatsValue.Value => value;

        readonly int value;

        public StatsValue(int value)
        {
            this.value = value;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is IStatsValue)) return false;
            return GetHashCode() == obj.GetHashCode();
        }
        public override int GetHashCode()
        {
            return value.GetHashCode();
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}
