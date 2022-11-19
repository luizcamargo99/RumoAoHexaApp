using Microsoft.JSInterop;
using RumoAoHexaApp.Interfaces;

namespace RumoAoHexaApp.Services
{
    internal class SoundService : ISoundService
    {
        private IJSRuntime _jsRuntime { get; set; }

        public SoundService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }
        public async Task Pause()
        {
            await _jsRuntime.InvokeVoidAsync("soundService.pauseAll");
        }

        public async Task Pause(string id)
        {
            await _jsRuntime.InvokeVoidAsync("soundService.pauseById", id);
        }


        public async Task Play(string id)
        {
            await _jsRuntime.InvokeVoidAsync("soundService.playSound", id);
        }
    }
}
