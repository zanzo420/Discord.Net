// todo: docs
using System.Threading.Tasks;

namespace Discord
{
    public interface IVoiceChannel : INestedChannel
    {
        // todo: v3 audio impl
        Task ConnectAsync(bool selfDeaf = false, bool selfMute = false, bool external = false);
        Task DisconnectAsync();

        int Bitrate { get; }
        int UserLimit { get; } // review: see ITextChannel SlowModeInterval

        Task ModifyAsync(VoiceChannelProperties properties, RequestOptions? options = default);
    }
}
