namespace SingletonLibrary
{
    public class ServicesFactory:IFactory
    {
        public IAudioService CreateAudioService()
        {
            return AudioService.GetInstance(); ;
        }

        public IFileService CreateFileService()
        {
            return FileService.GetInstance();
        }

        public IMessageService CreateMessageBoxService()
        {
            return MessageBoxService.GetInstance();
        }
    }
}