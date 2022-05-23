using PokeCalc.Domain.DamageCalculator;

namespace PokeCalc.Domain.Moves
{
    /// <summary>
    /// イカサマ
    /// 防御側のこうげき
    /// 防御側のぼうぎょ
    /// </summary>
    internal class FoulPlay : IForcePicker
    {
        readonly IForce force;
        public FoulPlay(IForce force)
        {
            this.force = force;
        }

        Offence IForcePicker.Offence => new Offence(force.Defence.Attack);
        Defence IForcePicker.Defence => new Defence(force.Defence.Defence);
    }
}
