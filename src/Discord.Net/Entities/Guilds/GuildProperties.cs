// todo: docs
using Voltaic;
using Wumpus;
using Wumpus.Entities;
using Model = Wumpus.Requests.ModifyGuildParams;

namespace Discord
{
    public class GuildProperties
    {
        public Optional<string> Name { get; set; }
        public Optional<string> RegionId { get; set; } // review: do we need to wrap VoiceRegion
        public Optional<int> AfkTimeout { get; set; }
        public Optional<Image?> Icon { get; set; }
        public Optional<Image?> Splash { get; set; }
        public Optional<Image?> Banner { get; set; }
        public Optional<SnowflakeOrEntity<IVoiceChannel>> AfkChannel { get; set; }
        public Optional<SnowflakeOrEntity<ITextChannel>> SystemChannel { get; set; }
        public Optional<SnowflakeOrEntity<IUser>> Owner { get; set; }
        public Optional<VerificationLevel> VerificationLevel { get; set; }
        public Optional<DefaultMessageNotifications> DefaultMessageNotifications { get; set; }
        public Optional<ExplicitContentFilter> ExplicitContentFilter { get; set; }
        // TODO: BOOST SystemChannelFlags - needs Wumpus

        internal Model ToWumpus()
        {
            var model = new Model();
            if (Name.IsSpecified)
                model.Name = new Utf8String(Name.Value);
            if (RegionId.IsSpecified)
                model.Region = new Utf8String(RegionId.Value);
            model.AfkTimeout = AfkTimeout;
            model.Icon = Icon;
            model.Splash = Splash;
            // todo: banner BOOST
            if (AfkChannel.IsSpecified)
                model.AfkChannelId = new Snowflake(AfkChannel.Value.Id);
            if (SystemChannel.IsSpecified)
                model.SystemChannelId = new Snowflake(SystemChannel.Value.Id);
            if (Owner.IsSpecified)
                model.OwnerId = new Snowflake(Owner.Value.Id);
            model.VerificationLevel = VerificationLevel;
            model.DefaultMessageNotifications = DefaultMessageNotifications;
            model.ExplicitContentFilter = ExplicitContentFilter;
            return model;
        }
    }
}
