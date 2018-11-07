namespace Interfaces.FileEnv
{
    public interface IPhoto : IFile
    {
        string Dimensions { get; set; }
        int Width { get; set; }
        int Height { get; set; }
    }
}
