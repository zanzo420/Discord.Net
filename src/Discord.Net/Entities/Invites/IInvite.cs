// todo: docs
using System.Threading.Tasks;

namespace Discord
{
    public interface IInvite : IEntity<string>, IDeletable
    {
        ValueTask<IChannel> GetChannelAsync(StateBehavior stateBehavior, RequestOptions? options = default);

        string Code => Id; // review: is this worth having
        string Url { get; }

        ulong ChannelId { get; }
        string ChannelName { get; }

        ulong? GuildId { get; } // review: do we need to support group DM invites
        string GuildName { get; }

        int? PresenceCount { get; }
        int? MemberCount { get; }
    }
}
