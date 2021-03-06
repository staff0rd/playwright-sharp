using System.Threading.Tasks;
using PlaywrightSharp.Input;
using PlaywrightSharp.Transport.Channels;

namespace PlaywrightSharp
{
    internal class Keyboard : IKeyboard
    {
        private readonly PageChannel _channel;

        public Keyboard(PageChannel channel)
        {
            _channel = channel;
        }

        public Task DownAsync(string key) => _channel.KeyboardDownAsync(key);

        public Task UpAsync(string key) => _channel.KeyboardUpAsync(key);

        public Task PressAsync(string key, int delay = 0) => _channel.PressAsync(key, delay);

        public Task TypeAsync(string text, int delay = 0) => _channel.TypeAsync(text, delay);

        public Task InsertTextAsync(string text) => _channel.InsertTextAsync(text);
    }
}
