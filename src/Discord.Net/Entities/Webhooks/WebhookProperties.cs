// todo: docs
using Voltaic;
using Wumpus;
using Model = Wumpus.Requests.ModifyWebhookParams;

namespace Discord
{
    public class WebhookProperties
    {
        public Optional<string> Name { get; set; }
        public Optional<Image?> Avatar { get; set; }
        public Optional<SnowflakeOrEntity<ITextChannel>> Channel { get; set; }

        internal Model ToModel()
        {
            var model = new Model();
            if (Name.IsSpecified)
                model.Name = new Utf8String(Name.Value);
            model.Avatar = Avatar;
            if (Channel.IsSpecified)
                model.ChannelId = new Snowflake(Channel.Value.Id);
            return model;
        }
    }
}
