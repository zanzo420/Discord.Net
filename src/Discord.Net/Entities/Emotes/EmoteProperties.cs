// TODO: docs
using Voltaic;
using Model = Wumpus.Requests.ModifyGuildEmojiParams;

namespace Discord
{
    public class EmoteProperties
    {
        public Optional<string> Name { get; set; }
        // review: do we care about RoleIds? can bots even do anything with them?

        internal Model ToWumpus()
        {
            var model = new Model();
            if (Name.IsSpecified)
                model.Name = new Utf8String(Name.Value);
            return model;
        }
    }
}
