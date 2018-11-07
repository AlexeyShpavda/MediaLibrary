namespace Interfaces.FileEnv
{
    public interface IAudioParameters : IPlayTime
    {
        int BitRate { get; set; }
        int SampleRate { get; set; }
    }
}
