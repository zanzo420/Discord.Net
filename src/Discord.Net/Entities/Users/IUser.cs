// todo: docs
// todo: methods
using System.Threading.Tasks;
using Voltaic;

namespace Discord
{
    public interface IUser : ISnowflakeEntity
    {
        string Username { get; }
        string Discriminator { get; }
        // review: does anyone use DiscriminatorValue? seems like a waste of memory
        string? AvatarId { get; }
        bool IsBot { get; }

        ValueTask<IDMChannel> GetOrCreateDMChannelAsync(StateBehavior stateBehavior = StateBehavior.AllowDownload, RequestOptions? options = default);
    }
}
