// todo: docs
using Voltaic;
using Model = Wumpus.Requests.ModifyChannelParams;

namespace Discord
{
    public class TextChannelProperties : GuildChannelProperties
    {
        public Optional<string> Topic { get; set; }
        public Optional<bool> IsNsfw { get; set; }
        public Optional<int> SlowModeInterval { get; set; } // review: int vs TimeSpan

        internal override Model ToWumpus()
        {
            var model = base.ToWumpus();
            if (Topic.IsSpecified)
                model.Topic = new Utf8String(Topic.Value);
            model.IsNsfw = IsNsfw;
            model.RateLimitPerUser = SlowModeInterval;

            return model;
        }
    }
}
