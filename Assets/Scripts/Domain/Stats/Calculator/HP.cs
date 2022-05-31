using PokeCalc.Domain.DamageCalculator;

namespace PokeCalc.Domain.Stats.Calculator
{
    public class HP : ICalculator
    {
        IStatsValue ICalculator.Calculate(Level level, Species sp, Individuals ip, BasePoints bp)
        {
            var x = sp.Value * 2 + ip.Value + bp.Value / 4;
            var y = (float)x * (float)level.Value / 100.0f + (float)level.Value+ 10;
            return new StatsValue((int)y);
        }
    }
}
