// todo: docs
namespace Discord
{
    // review: marker interfaces suck! should we just have an "IsNews" property on ITextChannel?
    public interface INewsChannel : ITextChannel
    {
        // news channels add nothing
    }
}
