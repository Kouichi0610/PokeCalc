using PokeCalc.Domain.DamageCalculator;

namespace PokeCalc.Domain.Stats.Calculator
{
    /// <summary>
    /// �k�P�j��HP
    /// 1�Œ�
    /// </summary>
    public class ShadinjaHP : ICalculator
    {
        IStatsValue ICalculator.Calculate(Level level, Species sp, Individuals ip, BasePoints bp)
        {
            return new StatsValue(1);
        }
    }
}
