using Plugin.Maui.Audio;

namespace RumoAoHexaApp.Data;

internal class Sound
{
    public required string DisplayName { get; set; }
    public required string FileName { get; set; }
    public bool Active { get; set; } = false;
    public IAudioPlayer Player { get; set; }
}
