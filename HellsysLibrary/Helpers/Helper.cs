namespace HellsysLibrary.Helpers
{
    public static class Helper
    {
        public static LogHelper EPILog { get; private set; }
        public static JsonHelper EPIJson { get; private set; }
        public static IniHelper EPIIni { get; private set; }
        public static RootHelper EPIRoot { get; private set; }
        static Helper()
        {
            EPILog = new LogHelper();
            EPIJson = new JsonHelper();
            EPIIni = new IniHelper();
            EPIRoot = new RootHelper();
        }
    }
}
