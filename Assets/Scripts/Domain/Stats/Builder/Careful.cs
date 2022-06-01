using PokeCalc.Domain.Stats.Calculator;

namespace PokeCalc.Domain.Stats.Builder
{
    /// <summary>
    /// ‚µ‚ñ‚¿‚å‚¤
    /// </summary>
    internal class Careful : IStatsBuilder
    {
        ICalculator IStatsBuilder.HP => new HP();
        ICalculator IStatsBuilder.Attack => new Flat();
        ICalculator IStatsBuilder.Defence => new Flat();
        ICalculator IStatsBuilder.SpAttack => new Lower();
        ICalculator IStatsBuilder.SpDefence => new Upper();
        ICalculator IStatsBuilder.Speed => new Flat();
    }
}
