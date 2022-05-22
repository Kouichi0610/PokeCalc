namespace PokeCalc.Domain.TypeCorrector
{
    internal sealed class Fairy : IEffectiveLoader
    {
        Effective IEffectiveLoader.Correct(IEffectiveLoader defence)
        {
            switch (defence)
            {
                case Fire _:
                case Poison _:
                case Steel _:
                    return Effective.NotVery;
                case Fighting _:
                case Dragon _:
                case Dark _:
                    return Effective.Super;
            }
            return Effective.Flat;
        }
    }
}
