// todo: docs
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Discord
{
    public interface ITextChannel : IMessageChannel, INestedChannel, ITaggable
    {
        string Topic { get; }
        int SlowModeInterval { get; } // review: int vs int? vs TimeSpan
        // present behavior: 0 = no slow mode, > 1 = yes slow mode

        bool IsNsfw { get; }

        Task ModifyAsync(TextChannelProperties properties, RequestOptions? options = default);

        Task DeleteMessagesAsync(IEnumerable<SnowflakeOrEntity<IMessage>> messages, RequestOptions? options = default);

        Task<IWebhook> CreateWebhookAsync(string name, Stream avatar = default, RequestOptions? options = default);
        // review: allow webhooks to be held in state? (no gateway event will populate them though)
        ValueTask<IWebhook> GetWebhookAsync(ulong id, StateBehavior stateBehavior, RequestOptions? options = default);
    }
}
