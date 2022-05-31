using PokeCalc.Domain.DamageCalculator;

namespace PokeCalc.Domain.Stats
{
    // TODO:îjä¸ÅAIStatsBuilderÇ…
    public sealed class Loader
    {
        // Loader(ID, Nature)

        ICalculator hp;
        ICalculator attack;
        ICalculator defence;
        ICalculator spAttack;
        ICalculator spDefence;
        ICalculator speed;


        // TODO:Lv, Sp, In, Base
        IStats Create()
        {
            throw new System.NotSupportedException("TODO:");
        }
    }
}
