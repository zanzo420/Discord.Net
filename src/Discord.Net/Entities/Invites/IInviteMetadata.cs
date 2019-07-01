// todo: docs
using System;
using System.Threading.Tasks;

namespace Discord
{
    public interface IInviteMetadata
    {
        ValueTask<IUser> GetInviterAsync(StateBehavior stateBehavior = default, RequestOptions? options = default);
        ulong InviterId { get; }

        bool IsRevoked { get; }
        bool IsTemporary { get; }
        int? MaxAge { get; }
        int? MaxUses { get; }
        int? Uses { get; }
        DateTimeOffset? CreatedAt { get; }
    }
}
