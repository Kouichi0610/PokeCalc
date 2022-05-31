using PokeCalc.Domain.DamageCalculator;

namespace PokeCalc.Domain.Stats
{
    public interface ICalculator
    {
        IStatsValue Calculate(Level level, Species sp, Individuals ip, BasePoints bp);
    }
}
