using System;
using System.IO;
using System.Windows.Forms;

namespace SingletonLibrary
{
    internal class FileService:IFileService
    {
        private static readonly FileService _instance = new FileService();
        private static readonly OpenFileDialog _openFileDialog = new OpenFileDialog();

        static FileService()
        {
        }

        public static FileService GetInstance()
        {
            return _instance;
        }


        public static string OpenFile()
        {
            _openFileDialog.Filter = "Mp3 files (*.mp3)|*.mp3|Wav files (*.wav)|*.wav";
            _openFileDialog.FilterIndex = 2;
            string name="";
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    name = _openFileDialog.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!");
                }
            }
            return name;
        }

        public static void SaveFile(string fileName, MemoryStream memoryStream)
        {
            File.WriteAllBytes(fileName, memoryStream.ToArray());
        }

        public static void DeleteFile(string fileName)
        {
            File.Delete(fileName);
        }

        public static void MoveFile(string fileFrom, string fileDist)
        {
            File.Move(fileFrom, fileDist);
        }

        string IFileService.OpenFile()
        {
            return OpenFile();
        }

        void IFileService.SaveFile(string fileName, MemoryStream memoryStream)
        {
            SaveFile(fileName, memoryStream);
        }

        void IFileService.DeleteFile(string fileName)
        {
            DeleteFile(fileName);
        }

        void IFileService.MoveFile(string fileFrom, string fileDist)
        {
            MoveFile(fileFrom, fileDist);
        }
    }
}