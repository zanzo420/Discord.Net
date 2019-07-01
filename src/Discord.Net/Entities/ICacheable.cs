using System.Threading.Tasks;

namespace Discord
{
    public interface ICacheable<TEntity> : ISnowflakeEntity
    {
        bool IsSpecified { get; }
        TEntity Value { get; }

        ValueTask<TEntity> GetAsync();
    }
}
