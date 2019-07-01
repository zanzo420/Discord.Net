using System.Threading.Tasks;
using Wumpus.Entities;

namespace Discord
{
    public interface IRole : ISnowflakeEntity
    {
        ValueTask<IGuild> GetGuildAsync(StateBehavior stateBehavior = default, RequestOptions? options = default);

        string Name { get; }
        Color Color { get; }
        int Position { get; }

        bool IsHoisted { get; }
        bool IsManaged { get; }
        bool IsMentionable { get; }

        GuildPermissions Permissions { get; } // review: use wump permissions directly or wrap?

        Task ModifyAsync(RoleProperties properties, RequestOptions? options = default);
    }
}
