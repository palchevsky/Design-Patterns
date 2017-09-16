using System;

namespace SingletonLibrary
{
    public interface IMessageService:IService
    {
        void ExceptionMessageBox(Exception exception);
    }
}