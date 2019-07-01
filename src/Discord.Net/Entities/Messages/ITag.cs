// todo: docs
using System;

namespace Discord
{
    public interface ITag
    {
        Index Index { get; } // review: is this big brained? would it be bigger brained to just use a ReadOnlySpan?
        int Length { get; }
        TagType Type { get; }
        ulong Key { get; }
        object Value { get;}
    }
}
