using System;
using System.Threading.Tasks;
using Wumpus;

namespace Discord
{
    public interface IDiscordClient
    {
        event Action Connected;
        event Action Disconnected;
        event Action Ready;

        event Action<IChannel> ChannelCreated;
        event Action<IChannel> ChannelDeleted;

        event Action<IMessage> MessageCreated;
        // todo: implement the rest of the events
        // review: event classes or just Action<A,B,C> types
        

        WumpusGatewayClient Gateway { get; }
        WumpusRestClient Rest { get; }

        Task StartAsync();
        Task StartAndWaitAsync();
        Task StopAsync();
    }
}
