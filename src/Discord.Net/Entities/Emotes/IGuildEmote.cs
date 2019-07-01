// TODO: docs
namespace Discord
{ 
    public interface IGuildEmote : IEmote, ISnowflakeEntity
    {
        // this is purposefully empty! Name is satisfied by IEmote, Id is satisfied by Snowflake    
    }
}
