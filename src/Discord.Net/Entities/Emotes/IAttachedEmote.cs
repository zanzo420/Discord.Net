// TODO: docs
// TODO: docs
using System.Threading.Tasks;

namespace Discord
{
    // review: is this naming clear?
    public interface IAttachedEmote : IGuildEmote, IDeletable
    {
        ValueTask<IGuild> GetGuildAsync(StateBehavior stateBehavior = default, RequestOptions? options = default);
        ulong GuildId { get; }

        Task ModifyAsync(EmoteProperties properties, RequestOptions? options = default);
    }
}
