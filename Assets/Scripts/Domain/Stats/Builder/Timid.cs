using PokeCalc.Domain.Stats.Calculator;

namespace PokeCalc.Domain.Stats.Builder
{
    /// <summary>
    /// �����т傤
    /// </summary>
    internal class Timid : IStatsBuilder
    {
        ICalculator IStatsBuilder.HP => new HP();
        ICalculator IStatsBuilder.Attack => new Lower();
        ICalculator IStatsBuilder.Defence => new Flat();
        ICalculator IStatsBuilder.SpAttack => new Flat();
        ICalculator IStatsBuilder.SpDefence => new Flat();
        ICalculator IStatsBuilder.Speed => new Upper();
    }
}
