namespace PokeCalc.Domain.TypeCorrector
{
    internal sealed class Fire : IEffectiveLoader
    {
        Effective IEffectiveLoader.Correct(IEffectiveLoader defence)
        {
            switch (defence)
            {
                case Fire _:
                case Water _:
                case Rock _:
                case Dragon _:
                    return Effective.NotVery;
                case Grass _:
                case Ice _:
                case Bug _:
                case Steel _:
                    return Effective.Super;
            }
            return Effective.Flat;
        }
    }
}
