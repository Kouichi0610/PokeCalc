
namespace PokeCalc.Domain.DamageCalculator
{
    /// <summary>
    /// RepositoryÇ…à–óÕÅAçUåÇÅAñhå‰ìnÇ∑->
    /// 
    /// TODO:MovesÇ…à⁄ìÆ
    /// </summary>
    internal sealed class DefaultCalculator : IFomula
    {
        readonly Level level;
        readonly Power power;
        readonly Offence offence;
        readonly Defence defence;
        readonly IDamageCorrector corrector;
        // TODO:É_ÉÅÅ[ÉWï‚ê≥
        public DefaultCalculator(Level level, Power power, Offence offence, Defence defence, IDamageCorrector corrector)
        {
            this.level = level;
            this.power = power;
            this.offence = offence;
            this.defence = defence;
            this.corrector = corrector;
        }
        Damage IFomula.Calculate()
        {
            var l = level.Value * 2 / 5 + 2;
            var o = power.Value * offence.Value / defence.Value;
            var d = l * o / 50 + 2;
            return corrector.Correct(new Damage(d));
        }
    }
}
