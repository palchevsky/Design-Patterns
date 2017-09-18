using SingletonLibrary;
using System;
using System.IO;
using System.Windows.Forms;


/*
 * Задание № 1
 * Реализуйте три класса (сервиса):
 * 1. MessageBoxService - Позволяет отлавливать возникшее исключение и выводить 
 * на экран его детали в виде MessageBox;
 * 3. AudioService - Позволияет проигрывать музыкальный файл, сохранять его на диск (используя сервис из п.3),
 * предоставлять информацию о файле в виде структуры AudioInfo (структуру также необходимо реализовать
 * самостоятельно);
 * 3. FileService - Сервис, позволяющий открывать файлы для чтения, сохранять на диск, удалять с диска и 
 * перемещать.
 * 
 * Все сервисы должны быть реализованы с помощью паттерна Singleton и не доступны для клиентского кода.
 * Для доступа к сервисам из сторонних сборок напишите Abstract Factory, позволяющую получить экземпляр
 * необходимого сервиса. Продемонстрируйте работу фабрики на примере WPF/Windows Forms приложения.
 * 
 */


namespace Singleton
{
    public partial class Test : Form
    {
        private readonly IFactory _smt;
        private AudioInfo _audioInfo;

        public Test()
        {
            _smt = new ServicesFactory();
            _audioInfo = new AudioInfo();
            InitializeComponent();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            try
            {
                IAudioService aud = _smt.CreateAudioService();
                aud.Play();
            }
            catch (Exception ex2)
            {
                IMessageService msg = _smt.CreateMessageBoxService();
                msg.ExceptionMessageBox(ex2);
            }
        }

        private void StopPlay_Click(object sender, EventArgs e)
        {
            try
            {
                IAudioService aud = _smt.CreateAudioService();
                aud.Stop();
            }
            catch (Exception ex2)
            {
                IMessageService msg = _smt.CreateMessageBoxService();
                msg.ExceptionMessageBox(ex2);
            }
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                IFileService file = _smt.CreateFileService();
                _audioInfo.FileName=file.OpenFile();
                IAudioService audio = _smt.CreateAudioService();
                audio.OpenMedia(_audioInfo.FileName);
                WaveHeaderIn(_audioInfo.FileName);
            }
            catch (Exception ex2)
            {
                IMessageService msg = _smt.CreateMessageBoxService();
                msg.ExceptionMessageBox(ex2);
            }
        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream inMemoryCopy = new MemoryStream();
                using (FileStream fs = File.OpenRead(_audioInfo.FileName))
                {
                    fs.CopyTo(inMemoryCopy);
                }

                IFileService file = _smt.CreateFileService();
               file.SaveFile(@"copy.wav",inMemoryCopy);
                MessageBox.Show(@"File copy.wav saved to the folder with exe file!");
            }
            catch (Exception ex2)
            {
                IMessageService msg = _smt.CreateMessageBoxService();
                msg.ExceptionMessageBox(ex2);
            }
        }

        private void btMove_Click(object sender, EventArgs e)
        {
            try
            {
                string destinationFile = @"E:\moved.wav";
                IFileService file = _smt.CreateFileService();
                file.MoveFile(_audioInfo.FileName, destinationFile);
                MessageBox.Show(@"Saved to: " + destinationFile, @"File Moved");
            }
            catch (Exception ex2)
            {
                IMessageService msg = _smt.CreateMessageBoxService();
                msg.ExceptionMessageBox(ex2);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                IFileService file = _smt.CreateFileService();
                file.DeleteFile(_audioInfo.FileName);
                MessageBox.Show(@"File " + _audioInfo.FileName + @" succesfully deleted!", @"File Deleted");
            }
            catch (Exception ex2)
            {
                IMessageService msg = _smt.CreateMessageBoxService();
                msg.ExceptionMessageBox(ex2);
            }
        }

        private void WaveHeaderIn(string spath)
        {
            FileStream fs = new FileStream(spath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            _audioInfo.Length= (int)fs.Length - 8;
            fs.Position = 22;
            _audioInfo.Channels= br.ReadInt16();
            fs.Position = 24;
            _audioInfo.SampleRate= br.ReadInt32();
            fs.Position = 34;
            _audioInfo.BitsPerSample= br.ReadInt16();
            _audioInfo.DataLength= (int)fs.Length - 44;
            br.Close();
            fs.Close();

            lbFileNameInfo.Text = _audioInfo.FileName;
            lbLengthInfo.Text = _audioInfo.Length.ToString() + @" bytes";
            lbChannelsInfo.Text = _audioInfo.Channels.ToString();
            lbSampleRateInfo.Text = _audioInfo.SampleRate.ToString()+ @" Hz";
            lbBPSInfo.Text = _audioInfo.BitsPerSample.ToString();
            lbDataLengthInfo.Text = _audioInfo.DataLength.ToString()+ @" bytes";
        }
    }
}
