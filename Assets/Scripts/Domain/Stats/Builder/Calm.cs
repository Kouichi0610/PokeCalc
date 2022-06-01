using PokeCalc.Domain.Stats.Calculator;

namespace PokeCalc.Domain.Stats.Builder
{
    /// <summary>
    /// ‚¨‚¾‚â‚©
    /// </summary>
    internal class Calm : IStatsBuilder
    {
        ICalculator IStatsBuilder.HP => new HP();
        ICalculator IStatsBuilder.Attack => new Lower();
        ICalculator IStatsBuilder.Defence => new Flat();
        ICalculator IStatsBuilder.SpAttack => new Flat();
        ICalculator IStatsBuilder.SpDefence => new Upper();
        ICalculator IStatsBuilder.Speed => new Flat();
    }
}
