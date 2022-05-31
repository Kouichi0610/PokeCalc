
namespace PokeCalc.Domain.Stats
{
    public interface IBuilderProcessor
    {
        IStatsBuilder Process(IStatsBuilder source);
    }
}
