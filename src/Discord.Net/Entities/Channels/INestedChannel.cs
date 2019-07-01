// todo: docs
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Discord
{
    public interface INestedChannel : IGuildChannel
    {
        ValueTask<ICategoryChannel> GetCategoryAsync(StateBehavior stateBehavior = default, RequestOptions? options = default);
        ulong? CategoryId { get; }

        Task SyncPermissionsAsync(RequestOptions? options = default);

        // review: do we want long, paramaterized methods like this, or would we rather a CreateInviteProperties
        Task CreateInviteAsync(int? maxAge = 86400,
            int? maxUses = default,
            bool isTemporary = false,
            bool isUnique = false,
            RequestOptions? options = default);
        Task<IReadOnlyCollection<IInviteMetadata>> GetInvitesAsync(RequestOptions? options = default);
    }
}
