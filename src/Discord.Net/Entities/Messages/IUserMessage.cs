// todo: docs
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Discord
{
    public interface IUserMessage : IMessage
    {
        string JumpUrl { get; } // review: use System.Uri for this?
        IReadOnlyDictionary<IEmote, IReactionInfo> Reactions { get; }

        Task ModifyAsync(MessageProperties properties, RequestOptions? options = default);
        Task PinAsync(RequestOptions? options = default);
        Task UnpinAsync(RequestOptions? options = default);

        Task AddReactionAsync(IEmote emote, RequestOptions? options = default);
        Task RemoveReactionAsync(IEmote emote, SnowflakeOrEntity<IUser> user, RequestOptions? options = default);
        Task ClearReactionsAsync(RequestOptions? options = default);

        IAsyncEnumerable<IUser> GetReactionUsersAsync(IEmote emote, int limit, RequestOptions? options = default);

        string Resolve(); // todo: tag handling
    }
}
