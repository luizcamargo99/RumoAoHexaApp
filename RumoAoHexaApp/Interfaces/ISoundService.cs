namespace RumoAoHexaApp.Interfaces
{
    internal interface ISoundService
    {
        Task Pause();
        Task Pause(string id);
        Task Play(string id);
    }
}
