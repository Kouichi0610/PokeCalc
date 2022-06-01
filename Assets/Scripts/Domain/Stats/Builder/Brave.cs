using PokeCalc.Domain.Stats.Calculator;

namespace PokeCalc.Domain.Stats.Builder
{
    /// <summary>
    /// �䂤����
    /// </summary>
    internal class Brave : IStatsBuilder
    {
        ICalculator IStatsBuilder.HP => new HP();
        ICalculator IStatsBuilder.Attack => new Upper();
        ICalculator IStatsBuilder.Defence => new Flat();
        ICalculator IStatsBuilder.SpAttack => new Flat();
        ICalculator IStatsBuilder.SpDefence => new Flat();
        ICalculator IStatsBuilder.Speed => new Lower();
    }
}
