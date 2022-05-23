using PokeCalc.Domain.DamageCalculator;

namespace PokeCalc.Domain.Moves
{
    /// <summary>
    /// とくしゅ
    /// 攻撃側のとくこう
    /// 防御側のとくぼう
    /// </summary>
    internal class Special : IForcePicker
    {
        readonly IForce force;

        public Special(IForce force)
        {
            this.force = force;
        }
        Offence IForcePicker.Offence => new Offence(force.Offence.SpAttack);
        Defence IForcePicker.Defence => new Defence(force.Defence.SpDefence);
    }
}
