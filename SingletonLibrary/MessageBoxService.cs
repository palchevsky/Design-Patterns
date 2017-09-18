using System;
using System.Windows.Forms;

namespace SingletonLibrary
{
    internal class MessageBoxService:IMessageService
    {
        private static readonly MessageBoxService _instance = new MessageBoxService();

        static MessageBoxService()
        {
        }

        public static MessageBoxService GetInstance()
        {
            return _instance;
        }

        public static void ExceptionMessageBox(Exception exception)
        {
            MessageBox.Show(exception.Message,@"Возникло исключение!");
        }

        void IMessageService.ExceptionMessageBox(Exception exception)
        {
            ExceptionMessageBox(exception);
        }
    }
}