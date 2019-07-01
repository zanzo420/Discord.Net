// todo: docs
using Voltaic;
using Model = Wumpus.Requests.ModifyMessageParams;

namespace Discord
{
    public class MessageProperties
    {
        public Optional<string> Content { get; set; }
        public Optional<IEmbed> Embed { get; set; }

        internal Model ToWumpus() // review: internal or external ToWumpus meths?
        {
            var model = new Model();
            if (Content.IsSpecified)
                model.Content = Content.Value != null ? new Utf8String(Content.Value) : null;
            if (Embed.IsSpecified)
                model.Embed = Embed.Value?.ToWumpus();
            return model;
        }
    }
}
