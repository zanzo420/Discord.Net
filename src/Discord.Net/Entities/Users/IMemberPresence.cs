// todo: docs
using Wumpus.Entities;

namespace Discord
{
    public interface IMemberPresence
    {
        IActivity Activity { get; }
        UserStatus Status { get; }
    }
}
