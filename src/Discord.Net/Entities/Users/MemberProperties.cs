using System.Collections.Generic;
using Voltaic;
using Wumpus;
using Model = Wumpus.Requests.ModifyGuildMemberParams;

namespace Discord
{
    public class MemberProperties
    {
        public Optional<bool> IsDeafened { get; set; }
        public Optional<bool> IsMuted { get; set; }
        public Optional<string> Nickname { get; set; }
        public Optional<IEnumerable<SnowflakeOrEntity<IRole>>> Roles { get; set; }
        public Optional<SnowflakeOrEntity<IVoiceChannel>?> VoiceChannel { get; set; }

        public Model ToWumpus()
        {
            var model = new Model();
            model.Deaf = IsDeafened;
            model.Mute = IsMuted;
            if (Nickname.IsSpecified)
                model.Nickname = Nickname != null ? new Utf8String(Nickname.Value) : null;
            if (Roles.IsSpecified) // review: IEnumerable best type for this?
            {
                int count = 0;
                if (Roles.Value is ICollection<SnowflakeOrEntity<IRole>> c)
                    count = c.Count;
                else
                {
                    foreach (var role in Roles.Value)
                        count++;
                }

                var roleIds = new Snowflake[count];
                int current = 0;
                foreach (var role in Roles.Value)
                {
                    roleIds[current] = role.Id;
                    current++;
                }
                model.RoleIds = roleIds;
            }
            if (VoiceChannel.IsSpecified)
            {
                // todo: needs wumpus support for disconnecting from channel
                model.ChannelId = VoiceChannel.Value.HasValue ? new Snowflake(VoiceChannel.Value.Value.Id) : 0;
            }
            return model;
        }
    }
}
