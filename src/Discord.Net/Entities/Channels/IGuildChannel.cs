// todo: docs
using System.Collections.Generic;
using System.Threading.Tasks;
using Voltaic;
using Wumpus.Entities;

namespace Discord
{
    public interface IGuildChannel : IChannel, IDeletable
    {
        ValueTask<IGuild> GetGuildAsync(StateBehavior stateBehavior = default, RequestOptions? options = default);
        ulong GuildId { get; }

        int Position { get; } // todo: validate that this can be populated

        Task ModifyAsync(GuildChannelProperties properties, RequestOptions? options = default);

        // todo: use Overwrite directly or create a wrapper?
        IReadOnlyCollection<Overwrite> PermissionOverwrites { get; }
        Optional<Overwrite> GetPermissionOverwrite(SnowflakeOrEntities<IUser, IRole> entity);

        Task AddPermissionOverwriteAsync(SnowflakeOrEntities<IUser, IRole> entity, Overwrite overwrite, RequestOptions? options = default);
        Task RemovePermissionOverwriteAsync(SnowflakeOrEntities<IUser, IRole> entity, RequestOptions? options = default);

        // review: separate GetMember methods here, or shadow GetUser
        ValueTask<IMember> GetMemberAsync(ulong id, StateBehavior stateBehavior = default, RequestOptions? options = default);
        IAsyncEnumerable<IMember> GetMembersAsync(StateBehavior stateBehavior = default, RequestOptions? options = default);
    }
}
