using PokeCalc.Domain.Stats.Calculator;

namespace PokeCalc.Domain.Stats.Builder
{
    /// <summary>
    /// �����Ƃ�
    /// </summary>
    internal class Mild : IStatsBuilder
    {
        ICalculator IStatsBuilder.HP => new HP();
        ICalculator IStatsBuilder.Attack => new Flat();
        ICalculator IStatsBuilder.Defence => new Lower();
        ICalculator IStatsBuilder.SpAttack => new Upper();
        ICalculator IStatsBuilder.SpDefence => new Flat();
        ICalculator IStatsBuilder.Speed => new Flat();
    }
}
