using PokeCalc.Domain.DamageCalculator;

namespace PokeCalc.Domain.ForcePicker
{
    /// <summary>
    /// �Ƃ�����
    /// �U�����̂Ƃ�����
    /// �h�䑤�̂Ƃ��ڂ�
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
