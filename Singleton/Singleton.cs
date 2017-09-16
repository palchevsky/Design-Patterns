using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SingletonLibrary;


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
        IFactory smt;
        //private string _fileName;
        AudioInfo audioInfo;
        public Test()
        {
            smt = new ServicesFactory();
            audioInfo = new AudioInfo();
            //_fileName = "";
            InitializeComponent();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            try
            {
                IAudioService aud = smt.CreateAudioService();
                aud.Play();
            }
            catch (Exception ex2)
            {
                IMessageService msg = smt.CreateMessageBoxService();
                msg.ExceptionMessageBox(ex2);
            }
        }

        private void StopPlay_Click(object sender, EventArgs e)
        {
            try
            {
                IAudioService aud = smt.CreateAudioService();
                aud.Stop();
            }
            catch (Exception ex2)
            {
                IMessageService msg = smt.CreateMessageBoxService();
                msg.ExceptionMessageBox(ex2);
            }
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                IFileService file = smt.CreateFileService();
                audioInfo.FileName=file.OpenFile();
                IAudioService audio = smt.CreateAudioService();
                audio.OpenMedia(audioInfo.FileName);
                WaveHeaderIN(audioInfo.FileName);
            }
            catch (Exception ex2)
            {
                IMessageService msg = smt.CreateMessageBoxService();
                msg.ExceptionMessageBox(ex2);
            }
        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream inMemoryCopy = new MemoryStream();
                using (FileStream fs = File.OpenRead(audioInfo.FileName))
                {
                    fs.CopyTo(inMemoryCopy);
                }

                IFileService file = smt.CreateFileService();
               file.SaveFile(@"copy.wav",inMemoryCopy);
                MessageBox.Show("File copy.wav saved to the folder with exe file!");
            }
            catch (Exception ex2)
            {
                IMessageService msg = smt.CreateMessageBoxService();
                msg.ExceptionMessageBox(ex2);
            }
        }

        private void btMove_Click(object sender, EventArgs e)
        {
            try
            {
                string destinationFile = @"E:\moved.wav";
                IFileService file = smt.CreateFileService();
                file.MoveFile(audioInfo.FileName, destinationFile);
                MessageBox.Show("Saved to: " + destinationFile, "File Moved");
                //file.DeleteFile(_fileName);
            }
            catch (Exception ex2)
            {
                IMessageService msg = smt.CreateMessageBoxService();
                msg.ExceptionMessageBox(ex2);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                IFileService file = smt.CreateFileService();
                file.DeleteFile(audioInfo.FileName);
                MessageBox.Show("File " + audioInfo.FileName + " succesfully deleted!", "File Deleted");
            }
            catch (Exception ex2)
            {
                IMessageService msg = smt.CreateMessageBoxService();
                msg.ExceptionMessageBox(ex2);
            }
        }

        private void WaveHeaderIN(string spath)
        {
            FileStream fs = new FileStream(spath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            audioInfo.Length= (int)fs.Length - 8;
            fs.Position = 22;
            audioInfo.Channels= br.ReadInt16();
            fs.Position = 24;
            audioInfo.SampleRate= br.ReadInt32();
            fs.Position = 34;
            audioInfo.BitsPerSample= br.ReadInt16();
            audioInfo.DataLength= (int)fs.Length - 44;
            br.Close();
            fs.Close();

            lbFileNameInfo.Text = audioInfo.FileName;
            lbLengthInfo.Text = audioInfo.Length.ToString() + " bytes";
            lbChannelsInfo.Text = audioInfo.Channels.ToString();
            lbSampleRateInfo.Text = audioInfo.SampleRate.ToString()+" Hz";
            lbBPSInfo.Text = audioInfo.BitsPerSample.ToString();
            lbDataLengthInfo.Text = audioInfo.DataLength.ToString()+ " bytes";

        }

    }
}
