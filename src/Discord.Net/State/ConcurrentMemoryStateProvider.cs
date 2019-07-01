// todo: impl, docs
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Discord
{
    internal class ConcurrentMemoryStateProvider : IStateProvider
    {
        public ValueTask<IReadOnlyCollection<IAttachedEmote>> GetAllEmotesAsync(StateBehavior stateBehavior, RequestOptions? options)
        {
            throw new System.NotImplementedException();
        }

        public ValueTask<IAttachedEmote> GetEmoteAsync(ulong guildId, ulong id, StateBehavior stateBehavior, RequestOptions? options)
        {
            throw new System.NotImplementedException();
        }

        public ValueTask<IReadOnlyCollection<IAttachedEmote>> GetEmotesAsync(ulong guildId, StateBehavior stateBehavior, RequestOptions? options)
        {
            throw new System.NotImplementedException();
        }

        public ValueTask<IGuild> GetGuildAsync(ulong id, StateBehavior stateBehavior, RequestOptions? options)
        {
            throw new System.NotImplementedException();
        }

        public ValueTask<IReadOnlyCollection<IGuild>> GetGuildsAsync(StateBehavior stateBehavior, RequestOptions? options)
        {
            throw new System.NotImplementedException();
        }

        public ValueTask<IMember> GetMemberAsync(ulong guildId, ulong id, StateBehavior stateBehavior, RequestOptions? options)
        {
            throw new System.NotImplementedException();
        }

        public ValueTask<IReadOnlyCollection<IMember>> GetMembersAsync(ulong guildId, StateBehavior stateBehavior, RequestOptions? options)
        {
            throw new System.NotImplementedException();
        }

        public ValueTask<IRole> GetRoleAsync(ulong guildId, ulong id, StateBehavior stateBehavior, RequestOptions? options)
        {
            throw new System.NotImplementedException();
        }

        public ValueTask<IReadOnlyCollection<IRole>> GetRolesAsync(ulong guildId, StateBehavior stateBehavior, RequestOptions? options)
        {
            throw new System.NotImplementedException();
        }

        public ValueTask<IUser> GetUserAsync(ulong id, StateBehavior stateBehavior, RequestOptions? options)
        {
            throw new System.NotImplementedException();
        }

        public ValueTask<IReadOnlyCollection<IUser>> GetUsersAsync(StateBehavior stateBehavior, RequestOptions? options)
        {
            throw new System.NotImplementedException();
        }

        public ValueTask InsertGuildAsync(IGuild guild)
        {
            throw new System.NotImplementedException();
        }

        public ValueTask InsertMemberAsync(IMember user)
        {
            throw new System.NotImplementedException();
        }

        public ValueTask InsertUserAsync(IUser user)
        {
            throw new System.NotImplementedException();
        }

        public ValueTask RemoveEmoteAsync(ulong id)
        {
            throw new System.NotImplementedException();
        }

        public ValueTask RemoveGuildAsync(ulong id)
        {
            throw new System.NotImplementedException();
        }

        public ValueTask RemoveMemberAsync(ulong id)
        {
            throw new System.NotImplementedException();
        }

        public ValueTask RemoveRoleAsync(ulong id)
        {
            throw new System.NotImplementedException();
        }

        public ValueTask RemoveUserAsync(ulong id)
        {
            throw new System.NotImplementedException();
        }
    }
}
