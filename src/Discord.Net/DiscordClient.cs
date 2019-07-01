using System;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Wumpus;
using Wumpus.Events;

namespace Discord
{
    internal class DiscordClient : IDiscordClient, IDisposable
    {
        public event Action Ready;
        public event Action Connected;
        public event Action Disconnected;
        public event Action<IChannel> ChannelCreated;
        public event Action<IChannel> ChannelDeleted;
        public event Action<IMessage> MessageCreated;

        private readonly int _shard, _totalShards;
        private TaskCompletionSource<bool>? _readyPromise;

        public WumpusGatewayClient Gateway { get; }
        public WumpusRestClient Rest { get; }

        public DiscordClient(DiscordClientConfig config)
        {
            _shard = config.Shard;
            _totalShards = config.TotalShards;

            Gateway = new WumpusGatewayClient();
            Rest = new WumpusRestClient();

            if (config.Token == null)
                throw new ArgumentNullException(nameof(config.Token), "The client token must be set.");
            var auth = new AuthenticationHeaderValue("", config.Token);
            // todo: port ChrisJ's token validator
            Gateway.Authorization = auth;
            Rest.Authorization = auth;

            RegisterEvents();
        }

        public async Task StartAsync()
        {
            if (Gateway.State != ConnectionState.Disconnected)
                await StopAsync().ConfigureAwait(false);

            var gateway = await Rest.GetBotGatewayAsync().ConfigureAwait(false);
            await Gateway.RunAsync(gateway.Url.ToString(), _shard, _totalShards).ConfigureAwait(false);
        }

        public async Task StartAndWaitAsync()
        {
            if (Gateway.State != ConnectionState.Disconnected)
                await StopAsync().ConfigureAwait(false);

            _readyPromise = new TaskCompletionSource<bool>();
            await StartAsync().ConfigureAwait(false);
            await _readyPromise.Task; // todo: need a timeout or cancellation token
            _readyPromise = null;
        }

        public async Task StopAsync()
        {
            await Gateway.StopAsync().ConfigureAwait(false);
        }

        private void RegisterEvents()
        {
            Gateway.Connected += OnConnected;
            Gateway.Disconnected += OnDisconnected;
            Gateway.Ready += OnReady;
        }
        private void OnConnected()
        {
            Connected?.Invoke();
        }
        private void OnDisconnected(Exception e)
        {
            Disconnected?.Invoke();
        }
        private void OnReady(ReadyEvent args)
        {
            if (_readyPromise != null)
                _readyPromise.TrySetResult(true);
            // TODO: Cache
            Ready?.Invoke();
        }

        public void Dispose()
        {
            Gateway.Dispose();
            Rest.Dispose();
        }
    }
}
