// todo: docs
// todo: methods
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Wumpus.Entities;

namespace Discord
{
    public interface IMessage : ISnowflakeEntity, IDeletable
    {
        ValueTask<IChannel> GetChannelAsync(StateBehavior stateBehavior = default, RequestOptions? options = default);
        ValueTask<IGuild?> GetGuildAsync(StateBehavior stateBehavior = default, RequestOptions? options = default);
        ValueTask<IMember?> GetMemberAsync(StateBehavior stateBehavior = default, RequestOptions? options = default);

        IUser Author { get; }
        ulong ChannelId { get; }

        string Content { get; }
        bool IsTTS { get; }
        bool IsPinned { get; }
        MessageType Type { get; }
        MessageSource Source { get; }

        DateTimeOffset Timestamp { get; }
        DateTimeOffset? EditedTimestamp { get; }

        IReadOnlyCollection<IAttachment> Attachments { get; }
        IReadOnlyCollection<IEmbed> Embeds { get; }
        IReadOnlyCollection<ITag> Tags { get; }
        IReadOnlyCollection<ulong> MentionedChannelIds { get; }
        IReadOnlyCollection<ulong> MentionedRoleIds { get; }
        IReadOnlyCollection<ulong> MentionedUserIds { get; }

        // TODO: MessageActivity, MessageApplication
    }
}
