namespace UsemKalitim
{
    class Logger
    {
        //
        public void LogInfo(string mesaj)
        {
            System.Console.WriteLine("INFO: " + mesaj);
        }
        public void LogError(string mesaj)
        {
            System.Console.WriteLine("ERROR: " + mesaj);
        }
    }

}