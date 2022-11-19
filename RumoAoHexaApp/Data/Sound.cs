namespace RumoAoHexaApp.Data;

internal class Sound
{
    public required string DisplayName { get; set; }
    public required string FileName { get; set; }
    public bool Active { get; set; } = false;
    public required int DurationInSeconds { get; set; }
    public List<Task> Tasks { get; set; } = new();
}
