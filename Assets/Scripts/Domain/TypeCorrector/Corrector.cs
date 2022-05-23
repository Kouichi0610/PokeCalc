using PokeCalc.Domain.Types;
using PokeCalc.Domain.DamageCalculator;

namespace PokeCalc.Domain.TypeCorrector
{
    // TODO:infra‘wŒo—R‚ÅDomain.Damage‚É“n‚·
    public class Corrector : ITypeCorrector
    {
        readonly ITypeCorrector effective;

        public static ITypeCorrector Create(PokeType offence, PokeType[] defence)
        {
            return new Corrector(offence, defence);
        }

        private Corrector(PokeType offence, PokeType[] defence)
        {
            var f = new Factory();
            var o = f.Create(offence);

            var e = Effective.Flat;

            foreach (var d in defence)
            {
                var def = f.Create(d);
                var effective = o.Correct(def);
                e = e.Append(effective);
            }
            effective = e;
        }

        Damage ITypeCorrector.Correct(Damage damage)
        {
            return effective.Correct(damage);
        }
    }
}
