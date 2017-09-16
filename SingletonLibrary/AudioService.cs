using System.Media;
using System.Windows.Forms;

namespace SingletonLibrary
{
    internal class AudioService:IAudioService
    {
        private static readonly SoundPlayer player = new SoundPlayer();

        private static readonly AudioService _instance = new AudioService();

        static AudioService()
        {
        }

        public static AudioService GetInstance()
        {
            return _instance;
        }


        public static void OpenMedia(string fileName)
        {
            //IFileService fileService= new FileService();
            player.SoundLocation = fileName;
            player.Load();
        }

        public static void Play()
        {
            player.Play();
            //player.Stop();
        }

        public static void Stop()
        {
            player.Stop();
        }

        public static void GetInfo()
        {
            MessageBox.Show("Пока ничего нет");
        }

        void IAudioService.OpenMedia(string fileName)
        {
            OpenMedia(fileName);
        }

        void IAudioService.Play()
        {
            Play();
        }

        void IAudioService.Stop()
        {
            Stop();
        }

        void IAudioService.GetInfo()
        {
            GetInfo();
        }
    }
}