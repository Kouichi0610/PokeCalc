using PokeCalc.Domain.DamageCalculator;

namespace PokeCalc.Domain.Moves
{
    /// <summary>
    /// ボディプレス
    /// 攻撃側のぼうぎょ
    /// 防御側のぼうぎょ
    /// </summary>
    internal class BodyPress : IForcePicker
    {
        readonly IForce force;

        public BodyPress(IForce force)
        {
            this.force = force;
        }
        Offence IForcePicker.Offence => new Offence(force.Offence.Defence);
        Defence IForcePicker.Defence => new Defence(force.Defence.Defence);
    }
}
