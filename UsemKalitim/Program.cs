using System;

namespace UsemKalitim
{
    class Program
    {
        static void Main(string[] args)
        {
            var log = new Logger();
            var insWithLog = new Installer(log);
            var ins = new Installer();

            ins.Start();
            insWithLog.Start();
        }
    }
}
