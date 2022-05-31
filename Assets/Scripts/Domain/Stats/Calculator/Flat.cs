using PokeCalc.Domain.DamageCalculator;

namespace PokeCalc.Domain.Stats.Calculator
{
    public class Flat : ICalculator
    {
        IStatsValue ICalculator.Calculate(Level level, Species sp, Individuals ip, BasePoints bp)
        {
            var x = sp.Value * 2 + ip.Value + bp.Value / 4;
            var y = (int)((float)x * level.Value) / 100 + 5;
            return new StatsValue(y);
        }
    }
}
