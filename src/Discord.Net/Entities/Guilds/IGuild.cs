// todo: impl, docs
using System.Collections.Generic;
using System.Threading.Tasks;
using Wumpus;
using Wumpus.Entities;

namespace Discord
{
    public interface IGuild : ISnowflakeEntity, IDeletable
    {
        // todo: IAudioClient
        string Name { get; }
        ulong? ApplicationId { get; }
        ulong EveryoneRoleId { get; }
        ulong OwnerId { get; }

        int AFKTimeout { get; }
        bool IsEmbeddable { get; } //review: is this still applicable
        string VoiceRegionId { get; }

        DefaultMessageNotifications DefaultMessageNotifications { get; }
        MfaLevel MfaLevel { get; }
        VerificationLevel VerificationLevel { get; }
        ExplicitContentFilter ExplicitContentFilter { get; }

        string? IconId { get; }
        string? IconUrl { get; }
        string? SplashId { get; }
        string? SplashUrl { get; }

        bool Attached { get; } // review: how to make this more consumable

        ulong? AFKChannelId { get; }
        ulong? DefaultChannelId { get; } // todo: can we expose this synchronously? needs access to channels
        ulong? EmbedChannelId { get; }
        ulong? SystemChannelId { get; }

        IReadOnlyCollection<string> Features { get; }

        // TODO: BOOST (needs Wumpus support)
        string? BannerId { get; }
        string? BannerUrl { get; }
        string? VanityUrl { get; }
        string? Description { get; }
        int BoostCount { get; }

        Task ModifyAsync(GuildProperties properties, RequestOptions? options = default);
        Task ModifyEmbedAsync(GuildEmbedProperties properties, RequestOptions? options = default);
        // todo: reorder channels, reorder roles
        Task LeaveAsync(RequestOptions? options = default);

        IAsyncEnumerable<IBan> GetBansAsync(RequestOptions? options = default);
        Task<IBan> GetBanAsync(SnowflakeOrEntity<IUser> user, RequestOptions? options = default);
        Task AddBanAsync(SnowflakeOrEntity<IUser> user, int? pruneDays = default, string? reason = default, RequestOptions? options = default);
        Task RemoveBanAsync(SnowflakeOrEntity<IUser> user, RequestOptions? options = default);

        ValueTask<IReadOnlyCollection<IGuildChannel>> GetChannelsAsync(StateBehavior stateBehavior = default, RequestOptions? options = default);
        ValueTask<IGuildChannel?> GetChannelAsync(ulong id, StateBehavior stateBehavior = default, RequestOptions? options = default);
        // extensions -- review: should move to an extensions class?
        // todo: write extensions

        Task CreateTextChannelAsync(TextChannelProperties properties, RequestOptions? options = default);
        Task CreateVoiceChannelAsync(TextChannelProperties properties, RequestOptions? options = default);
        Task CreateCategoryAsync(GuildChannelProperties properties, RequestOptions? options = default);

        // review: should we wrap this?
        Task<IReadOnlyCollection<VoiceRegion>> GetVoiceRegionsAsync(RequestOptions? options = default);
        // todo: integrations ResidentSleeper

        Task<IReadOnlyCollection<IInviteMetadata>> GetInvitesAsync(RequestOptions? options = default);
        Task<IInviteMetadata> GetVanityInviteAsync(RequestOptions? options = default);

        ValueTask<IReadOnlyCollection<IRole>> GetRolesAsync(StateBehavior stateBehavior = default, RequestOptions? options = default);
        ValueTask<IRole> GetRoleAsync(StateBehavior stateBehavior = default, RequestOptions? options = default);
        ValueTask<IRole> GetEveryoneRoleAsync(StateBehavior stateBehavior = default, RequestOptions? options = default);
        Task<IRole> CreateRoleAsync(RoleProperties properties, RequestOptions? options = default);

        ValueTask<IReadOnlyCollection<IMember>> GetMembersAsync(StateBehavior stateBehavior = default, RequestOptions? options = default);
        ValueTask<IMember?> GetMemberAsync(ulong id, StateBehavior stateBehavior = default, RequestOptions? options = default);
        Task<IMember> AddMemberAsync(ulong id, string accessToken, MemberProperties? properties = default, RequestOptions? options = default);
        Task<int> PruneMembersAsync(int days = 30, bool simulate = false, RequestOptions? options = default);
        Task DownloadMembersAsync(); // review: do we want to keep this
        // extensions -- review: should move to an extensions class? see above
        ValueTask<IMember> GetOwnerAsync(StateBehavior stateBehavior = default, RequestOptions? options = default);

        ValueTask<IReadOnlyCollection<IAttachedEmote>> GetEmotesAsync(StateBehavior stateBehavior = default, RequestOptions? options = default);
        ValueTask<IAttachedEmote> GetEmoteAsync(StateBehavior stateBehavior = default, RequestOptions? options = default);
        Task CreateEmoteAsync(string name, Image image, RequestOptions? options = default);
    }
}
