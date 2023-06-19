using NLog;

namespace HellsysLibrary.Helpers
{
    public enum LogType
    {
        Debug,
        Info, 
        Warn, 
        Error,
        Fatal
    }
    public class LogHelper
    {
        private readonly Logger logger =LogManager.GetCurrentClassLogger();
        public void LogWrite(string message, LogType logtype)
        {
            switch (logtype)
            {
                case LogType.Debug:
                    logger.Debug(message);
                    break;
                case LogType.Info:
                    logger.Info(message);
                    break;
                case LogType.Warn:
                    logger.Warn(message); 
                    break;
                case LogType.Error:
                    logger.Error(message);
                    break;
                default:
                    break;
            }
        }
    }
}
