// todo: meth
// todo: prop
// todo: docs
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Wumpus.Entities;

namespace Discord
{
    public interface IMember : ISnowflakeEntity, IVoiceState
    {
        ValueTask<IUser> GetUserAsync(StateBehavior stateBehavior = default, RequestOptions? options = default);
        ValueTask<IGuild> GetGuildAsync(StateBehavior stateBehavior = default, RequestOptions? options = default);
        ValueTask<IReadOnlyCollection<IRole>> GetRoles(StateBehavior stateBehavior = default, RequestOptions? options = default);

        ulong GuildId { get; }
        IReadOnlyCollection<ulong> RoleIds { get; }
        IMemberPresence Presence { get; }

        DateTimeOffset? JoinedAt { get; }
        string Nickname { get; }
        GuildPermissions GuildPermissions { get; }

        ValueTask<ChannelPermissions> GetPermissionsAsync(IGuildChannel channel);

        Task ModifyAsync(MemberProperties properties, RequestOptions? options = default);

        // review: should these two be extensions on IGuild?
        Task KickAsync(string reason = default, RequestOptions? options = default);
        Task BanAsync(string reason = default, RequestOptions? options = default);

        Task AddRoleAsync(SnowflakeOrEntity<IRole> role, RequestOptions? options = default);
        Task AddRolesAsync(IEnumerable<SnowflakeOrEntity<IRole>> roles, RequestOptions? options = default);
        Task RemoveRoleAsync(SnowflakeOrEntity<IRole> role, RequestOptions? options = default);
        Task RemoveRolesAsync(IEnumerable<SnowflakeOrEntity<IRole>> roles, RequestOptions? options = default);
    }
}
