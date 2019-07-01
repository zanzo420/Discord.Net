// todo: docs
using Voltaic;
using Wumpus.Entities;
using Model = Wumpus.Requests.ModifyGuildRoleParams;

namespace Discord
{
    public class RoleProperties
    {
        public Optional<string> Name { get; set; }
        public Optional<Color> Color { get; set; }
        public Optional<int> Position { get; set; }
        
        public Optional<bool> IsHoisted { get; set; }
        public Optional<bool> IsMentionable { get; set; }

        public Optional<GuildPermissions> Permissions { get; set; }

        internal Model ToWumpus()
        {
            var model = new Model();
            if (Name.IsSpecified)
                model.Name = new Utf8String(Name.Value);
            model.Color = Color;
            model.IsHoisted = IsHoisted;
            model.IsMentionable = IsMentionable;
            model.Permissions = Permissions;
            return model;

            // todo: handle Position reordering
        }
    }
}
