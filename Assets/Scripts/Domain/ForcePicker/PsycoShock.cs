using PokeCalc.Domain.DamageCalculator;

namespace PokeCalc.Domain.ForcePicker
{
    /// <summary>
    /// サイコショック
    /// 攻撃側のとくこう
    /// 防御側のぼうぎょ
    /// </summary>
    internal class PsycoShock : IForcePicker
    {
        readonly IForce force;

        public PsycoShock(IForce force)
        {
            this.force = force;
        }

        Offence IForcePicker.Offence => new Offence(force.Offence.SpAttack);
        Defence IForcePicker.Defence => new Defence(force.Defence.Defence);
    }
}
