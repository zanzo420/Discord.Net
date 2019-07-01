// todo: docs
using Voltaic;
using Wumpus;
using Model = Wumpus.Requests.ModifyCurrentUserParams;

namespace Discord
{
    public class SelfUserProperties
    {
        public Optional<string> Username { get; set; }
        public Optional<Image?> Avatar { get; set; }

        public Model ToWumpus()
        {
            var model = new Model();
            if (Username.IsSpecified)
                model.Username = new Utf8String(model.Username.Value);
            model.Avatar = Avatar;
            return model;
        }
    }
}
