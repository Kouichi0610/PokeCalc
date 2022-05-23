namespace PokeCalc.Domain.Moves
{
    public interface IForce
    {
        IStats Offence { get; }
        IStats Defence { get; }
    }
}
