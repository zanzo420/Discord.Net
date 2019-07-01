// todo: docs
using Voltaic;
using Wumpus;
using Model = Wumpus.Requests.ModifyChannelParams;

namespace Discord
{
    public class GuildChannelProperties
    {
        public Optional<string> Name { get; set; }
        public Optional<int> Position { get; set; }
        public Optional<SnowflakeOrEntity<ICategoryChannel>?> Category { get; set; }

        internal virtual Model ToWumpus()
        {
            var model = new Model();
            if (Name.IsSpecified)
                model.Name = new Utf8String(Name.Value);
            model.Position = Position;
            if (Category.IsSpecified)
            {
                model.ParentId = Category.Value.HasValue ? Category.Value.Value.Id : (Snowflake?)null;
            }

            return model;
        }
    }
}
