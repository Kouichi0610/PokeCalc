using PokeCalc.Domain.DamageCalculator;

namespace PokeCalc.Domain.Stats.Calculator
{
    public class Upper : ICalculator
    {
        ICalculator flat = new Flat();

        IStatsValue ICalculator.Calculate(Level level, Species sp, Individuals ip, BasePoints bp)
        {
            var res = flat.Calculate(level, sp, ip, bp);
            var v = res.Value * 1.1f;
            return new StatsValue((int)v);
        }
    }
}
