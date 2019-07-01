// todo: docs
using System.Threading.Tasks;

namespace Discord
{
    public interface IVoiceState
    {
        ValueTask<IVoiceChannel> GetVoiceChannelAsync(StateBehavior stateBehavior = default, RequestOptions? options = default);

        bool IsDeafened { get; }
        bool IsMuted { get; }
        bool IsSelfDeafened { get; }
        bool IfSelfMuted { get; }
        bool IsSuppressed { get; }

        ulong VoiceChannelId { get; }
        string VoiceSessionId { get; }
    }
}
