// TODO: docs
// TODO: methods
using System.Threading.Tasks;

namespace Discord
{
    interface ISelfUser : IUser, IMemberPresence
    {
        // not applicable: verified, email, MFA

        Task ModifyAsync(SelfUserProperties properties, RequestOptions? options = default);
    }
}
