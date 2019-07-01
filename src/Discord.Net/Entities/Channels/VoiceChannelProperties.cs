// todo: meth
using Voltaic;
using Model = Wumpus.Requests.ModifyChannelParams;

namespace Discord
{
    public class VoiceChannelProperties : GuildChannelProperties
    {
        public Optional<int> Bitrate { get; set; }
        public Optional<int> UserLimit { get; set; }

        internal override Model ToWumpus()
        {
            var model = base.ToWumpus();
            model.Bitrate = Bitrate;
            model.UserLimit = UserLimit;
            return model;
        }
    }
}
