using PokeCalc.Domain.DamageCalculator;

namespace PokeCalc.Domain.Stats
{
    public interface IStatsBuilder
    {
        ICalculator HP { get; }
        ICalculator Attack { get; }
        ICalculator Defence { get; }
        ICalculator SpAttack { get; }
        ICalculator SpDefence { get; }
        ICalculator Speed { get; }
    }
}
