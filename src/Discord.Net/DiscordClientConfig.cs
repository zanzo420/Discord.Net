namespace Discord
{
    public class DiscordClientConfig
    {
        public string? Token { get; set; }

        public int Shard { get; set; } = 0;
        public int TotalShards { get; set; } = 1;

        IStateProvider StateProvider { get; set; } = new ConcurrentMemoryStateProvider(); // todo: use a factory so the state is never exposed
        public StateBehavior DefaultStateBehavior { get; set; } = StateBehavior.Default;
    }
}
