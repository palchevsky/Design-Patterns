namespace SingletonLibrary
{
    public interface IAudioService:IService
    {
        void OpenMedia(string fileName);
        void Play();
        void Stop();
        void GetInfo();
    }
}