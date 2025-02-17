using System.Runtime.InteropServices;

namespace logger
{
    public static class Debug
    {
        private static bool s_usePrevCheck = true;
        private static bool usePrevLineBefore = false;


        /// <summary>
        /// Creates a console for non-console apps (like windows forms)
        /// </summary>
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern bool AllocConsole();

        public static void Log(object msg) { Log(msg, false); }
        public static void Log(object msg, bool usePrevLine)
        {
            if (usePrevLineBefore && !usePrevLine && s_usePrevCheck) Console.Write("\n");
            if (!usePrevLine)
            {
                Console.WriteLine(msg);
                usePrevLineBefore = false;
            }
            else
            {
                Console.Write($"\r{msg}");
                usePrevLineBefore = true;
            };
            Console.ResetColor();
        }

        public static void LogWarning(object msg) { LogWarning(msg, false); }
        public static void LogWarning(object msg, bool usePrevLine)
        {
            if (usePrevLineBefore && !usePrevLine && s_usePrevCheck) Console.Write("\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (!usePrevLine)
            {
                Console.WriteLine(msg);
                usePrevLineBefore = false;
            }
            else
            {
                Console.Write($"\r{msg}");
                usePrevLineBefore = true;
            };
            Console.ResetColor();
        }

        public static void LogError(object msg) { LogError(msg, false); }
        public static void LogError(object msg, bool usePrevLine)
        {
            if (usePrevLineBefore && !usePrevLine && s_usePrevCheck) Console.Write("\n");
            Console.ForegroundColor = ConsoleColor.Red;
            if (!usePrevLine)
            {
                Console.WriteLine(msg);
                usePrevLineBefore = false;
            }
            else
            {
                Console.Write($"\r{msg}");
                usePrevLineBefore = true;
            };
            Console.ResetColor();
        }

        public static void LogClear() { LogClear(false); }
        public static void LogClear(bool announceCleared)
        {
            Console.Clear();
            usePrevLineBefore = false;
            if (!announceCleared) return; 
            Console.WriteLine("Cleared!");
        }

        public static string LogInput()
        {
            string? s = Console.ReadLine();
            if (s != null)
            {
                return s;
            }
            return "";
        }
    }
}
