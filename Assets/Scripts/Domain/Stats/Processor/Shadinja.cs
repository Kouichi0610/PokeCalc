using PokeCalc.Domain.Stats.Calculator;

namespace PokeCalc.Domain.Stats.Processor
{
    public class Shadinja : IBuilderProcessor
    {
        IStatsBuilder IBuilderProcessor.Process(IStatsBuilder source)
        {
            return new Temp(source);
        }

        class Temp : IStatsBuilder
        {
            public ICalculator HP { get; private set; }
            public ICalculator Attack { get; private set; }
            public ICalculator Defence { get; private set; }
            public ICalculator SpAttack { get; private set; }
            public ICalculator SpDefence { get; private set; }
            public ICalculator Speed { get; private set; }

            public Temp(IStatsBuilder source)
            {
                HP = new ShadinjaHP();
                Attack = source.Attack;
                Defence = source.Defence;
                SpAttack = source.SpAttack;
                SpDefence = source.SpDefence;
                Speed = source.Speed;
            }
        }
    }
}
