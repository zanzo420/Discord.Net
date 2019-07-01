using System;
using System.Threading.Tasks;
using Discord;

namespace Sample
{
    public class Program
    {
        static void Main()
            => new Program().MainAsync().GetAwaiter().GetResult();
        public async Task MainAsync()
        {
            string token = "abc";
            var client = DiscordClientBuilder.FromConfig(new DiscordClientConfig
            {
                Token = token,
                DefaultStateBehavior = StateBehavior.SyncOnly
            });
            await client.StartAndWaitAsync();

            client.MessageCreated += msg => Task.Run(() => OnMessageCreated(msg)).Observe();

            await Task.Delay(-1);
        }
        public async Task OnMessageCreated(IMessage msg)
        {
            if (!(msg is IUserMessage message))
                return;
            var guild = await msg.GetGuildAsync();
            if (guild == null)
                return;
            var owner = await guild.GetOwnerAsync();
            var dm = await (await owner.GetUserAsync()).GetOrCreateDMChannelAsync();
            await dm.SendMessageAsync($"{msg.Author} said: {msg.Content}");
        }
    }

    public static class TaskExtensions
    {
        public static void Observe(this Task task)
        {
            task.ContinueWith(t =>
            {
                if (t.IsFaulted)
                {
                    var flattened = t.Exception.Flatten();
                    foreach (var ex in flattened.InnerExceptions)
                        Console.WriteLine(ex.ToString());
                }
            });
        }
    }
}
