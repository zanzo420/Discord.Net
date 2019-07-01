// todo: docs
using System.Threading.Tasks;

namespace Discord
{
    public interface IDMChannel : IMessageChannel
    {
        ValueTask<IUser> GetRecipientAsync(StateBehavior stateBehavior, RequestOptions? options = default);
        ulong RecipientId { get; }

        // not applicable: CloseAsync
    }
}
