// todo: docs
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Wumpus;

namespace Discord
{
    public interface IMessageChannel : IChannel
    {
        Task<IUserMessage> SendMessageAsync(string? text = null, bool isTTS = false, IEmbed? embed = null, RequestOptions? options = default);
        Task<IUserMessage> SendFileAsync(Stream fileStream, string filename, string? text = null, bool isTTS = false, IEmbed? embed = null, RequestOptions? options = default);
        // todo: SendFileAsync(string, ...) extension

        ValueTask<IMessage> GetMessageAsync(ulong id, StateBehavior stateBehavior = default, RequestOptions? options = default);
        IAsyncEnumerable<IMessage> GetMessagesAsync(int limit = default, SnowflakeOrEntity<IMessage> offset = default, Direction offsetDirection = default,
            StateBehavior stateBehavior = default, RequestOptions? options = default);
        Task<IReadOnlyCollection<IMessage>> GetPinnedMessagesAsync(RequestOptions? options = default);

        Task DeleteMessageAsync(SnowflakeOrEntity<IMessage> message, RequestOptions? options = default);

        Task TriggerTypingAsync(RequestOptions? options = default);
        IDisposable EnterTypingState(RequestOptions? options = default);
    }
}
