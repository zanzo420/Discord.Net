namespace Discord
{
    public sealed class DiscordClientBuilder
    {
        private DiscordClientBuilder() { }
        public static IDiscordClient FromConfig(DiscordClientConfig config)
        {
            return new DiscordClient(config);
        }
    }
}
