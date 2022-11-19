namespace RumoAoHexaApp.Interfaces
{
    internal interface ISoundService
    {
        Task PauseAsync();
        Task PauseAsync(string id);
        Task PlayAsync(string id);
    }
}
