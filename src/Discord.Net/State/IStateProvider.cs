// todo: impl, docs
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Discord
{
    public interface IStateProvider
    {
        // we'll need to extend this as the client is implemented

        ValueTask<IUser> GetUserAsync(ulong id, StateBehavior stateBehavior, RequestOptions? options);
        // review: IReadOnlyCollection is proper collection type here?
        ValueTask<IReadOnlyCollection<IUser>> GetUsersAsync(StateBehavior stateBehavior, RequestOptions? options);
        ValueTask InsertUserAsync(IUser user);
        ValueTask RemoveUserAsync(ulong id);

        ValueTask<IMember> GetMemberAsync(ulong guildId, ulong id, StateBehavior stateBehavior, RequestOptions? options);
        ValueTask<IReadOnlyCollection<IMember>> GetMembersAsync(ulong guildId, StateBehavior stateBehavior, RequestOptions? options);
        ValueTask InsertMemberAsync(IMember user);
        ValueTask RemoveMemberAsync(ulong id);

        ValueTask<IGuild> GetGuildAsync(ulong id, StateBehavior stateBehavior, RequestOptions? options);
        ValueTask<IReadOnlyCollection<IGuild>> GetGuildsAsync(StateBehavior stateBehavior, RequestOptions? options);
        ValueTask InsertGuildAsync(IGuild guild);
        ValueTask RemoveGuildAsync(ulong id);

        ValueTask<IRole> GetRoleAsync(ulong guildId, ulong id, StateBehavior stateBehavior, RequestOptions? options);
        ValueTask<IReadOnlyCollection<IRole>> GetRolesAsync(ulong guildId, StateBehavior stateBehavior, RequestOptions? options);
        ValueTask RemoveRoleAsync(ulong id);

        ValueTask<IAttachedEmote> GetEmoteAsync(ulong guildId, ulong id, StateBehavior stateBehavior, RequestOptions? options);
        ValueTask<IReadOnlyCollection<IAttachedEmote>> GetEmotesAsync(ulong guildId, StateBehavior stateBehavior, RequestOptions? options);
        ValueTask<IReadOnlyCollection<IAttachedEmote>> GetAllEmotesAsync(StateBehavior stateBehavior, RequestOptions? options);
        ValueTask RemoveEmoteAsync(ulong id);
    }
}
