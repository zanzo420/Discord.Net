// todo: docs
using Voltaic;

namespace Discord
{
    public interface IAttachment : ISnowflakeEntity
    {
        string FileName { get; }
        int FileSize { get; }
        string Url { get; }
        string ProxyUrl { get; }
        Optional<int> Height { get; }
        Optional<int> Width { get; }
    }
}
