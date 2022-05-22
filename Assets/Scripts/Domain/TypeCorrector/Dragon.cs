namespace PokeCalc.Domain.TypeCorrector
{
    internal sealed class Dragon : IEffectiveLoader
    {
        Effective IEffectiveLoader.Correct(IEffectiveLoader defence)
        {
            switch (defence)
            {
                case Steel _:
                    return Effective.NotVery;
                case Dragon _:
                    return Effective.Super;
                case Fairy _:
                    return Effective.NoEffective;
            }
            return Effective.Flat;
        }
    }
}
