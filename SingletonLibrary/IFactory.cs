namespace SingletonLibrary
{
    public interface IFactory
    {
        IAudioService CreateAudioService();
        IFileService CreateFileService();
        IMessageService CreateMessageBoxService();
    }
}