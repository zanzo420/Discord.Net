// TODO: docs
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Discord
{
    public interface IChannel : ISnowflakeEntity
    {
        string Name { get; }

        ValueTask<IUser> GetUserAsync(ulong id, StateBehavior stateBehavior = default, RequestOptions? options = default);
        IAsyncEnumerable<IUser> GetUsersAsync(StateBehavior stateBehavior = default, RequestOptions? options = default);
    }
}
