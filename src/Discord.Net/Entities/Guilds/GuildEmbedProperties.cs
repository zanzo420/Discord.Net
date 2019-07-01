// todo: docs
using Voltaic;
using Wumpus;
using Model = Wumpus.Requests.ModifyGuildEmbedParams;

namespace Discord
{
    public class GuildEmbedProperties
    {
        public Optional<bool> Enabled { get; set; }
        public Optional<SnowflakeOrEntity<INestedChannel>> Channel { get; set; }

        internal Model ToWumpus()
        {
            var model = new Model();
            model.Enabled = Enabled;
            if (Channel.IsSpecified)
                model.ChannelId = new Snowflake(Channel.Value.Id);
            return model;
        }
    }
}
