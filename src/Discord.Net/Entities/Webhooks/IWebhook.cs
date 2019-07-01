// todo: docs
using System.Threading.Tasks;

namespace Discord
{
    public interface IWebhook
    {
        ValueTask<IUser> GetCreatorAsync(StateBehavior stateBehavior = default, RequestOptions? options = default);
        ValueTask<ITextChannel> GetChannelAsync(StateBehavior stateBehavior = default, RequestOptions? options = default);
        ValueTask<IGuild> GetGuildAsync(StateBehavior stateBehavior = default, RequestOptions? options = default);
        // review: does this need to be an async retrieval? the only path to get an IWebhook should be via an ITextChannel

        string Token { get; }

        // note: yeah, the full creator is included in the payload, but we don't want entities to hold direct references to other entities
        ulong CreatorId { get; } 
        ulong ChannelId { get; }
        ulong GuildId { get; } // review: this is impl'd as a ulong? in d.net legacy, todo-ensure there is no case we wouldn't have the guild ID

        string Name { get; }
        string AvatarId { get; }

        Task ModifyAsync(WebhookProperties properties, RequestOptions? options = default);
    }
}
