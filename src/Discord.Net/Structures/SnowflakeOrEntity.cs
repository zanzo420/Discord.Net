namespace Discord
{
    /// <summary>
    ///     SnowflakeOrEntity is a structure allowing any entity to be implicitly converted to a Snowflake, for
    ///     use in method parameters.
    /// </summary>
    /// <typeparam name="TEntity">
    ///     The type of Entity expected by this parameter.
    /// </typeparam>
    public struct SnowflakeOrEntity<TEntity>
        where TEntity : ISnowflakeEntity
    {
        public ulong Id { get; }

        public SnowflakeOrEntity(TEntity entity)
        {
            Id = entity.Id;
        }
        public SnowflakeOrEntity(ulong id)
        {
            Id = id;
        }

        public static implicit operator SnowflakeOrEntity<TEntity>(TEntity entity)
        {
            return new SnowflakeOrEntity<TEntity>(entity);
        }
        public static implicit operator SnowflakeOrEntity<TEntity>(ulong id)
        {
            return new SnowflakeOrEntity<TEntity>(id);
        }
    }

    public struct SnowflakeOrEntities<TEntity1, TEntity2>
        where TEntity1 : ISnowflakeEntity
        where TEntity2 : ISnowflakeEntity
    {
        public ulong Id { get; }

        public SnowflakeOrEntities(TEntity1 entity)
        {
            Id = entity.Id;
        }
        public SnowflakeOrEntities(TEntity2 entity)
        {
            Id = entity.Id;
        }
        public SnowflakeOrEntities(ulong id)
        {
            Id = id;
        }

        public static implicit operator SnowflakeOrEntities<TEntity1, TEntity2>(ulong id)
        {
            return new SnowflakeOrEntities<TEntity1, TEntity2>(id);
        }
    }
}
