using PokeCalc.Domain.DamageCalculator;

namespace PokeCalc.Domain.Moves
{
    /// <summary>
    /// �Ԃ�
    /// �U�����̂�������
    /// �h�䑤�̂ڂ�����
    /// </summary>
    internal class Physical : IForcePicker
    {
        readonly IForce force;
        public Physical(IForce force)
        {
            this.force = force;
        }
        Offence IForcePicker.Offence => new Offence(force.Offence.Attack);
        Defence IForcePicker.Defence => new Defence(force.Defence.Defence);
    }
}
