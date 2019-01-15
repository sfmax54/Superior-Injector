using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Superior_Injector
{
    class Config
    {
        public static int InjectionDelay = 0;
        public static string InjectionMethod = "LoadLibrary";
        public static string Process = string.Empty;
        public static bool AsyncInjection = true;
        public static bool SecureMode = false;
        public static List<string> DLLPathes = new List<string>();

        public static void SaveConfig()
        {
            string config = "InjectionDelay=" + InjectionDelay + ";" +
                            "InjectionMethod=" + InjectionMethod + ";" +
                            "Process=" + Process + ";" +
                            "AsyncInjection=" + AsyncInjection + ";" +
                            "SecureMode=" + SecureMode + ";";
            if (DLLPathes.Count > 0)
            {
                config += "DLLList=" + string.Join(",", DLLPathes) + ";";
            }     
            File.WriteAllText("config.ini", Convert.ToBase64String(Encoding.ASCII.GetBytes(config)));
        }

        public static void LoadConfig()
        {
            if (File.Exists("config.ini"))
            {
                try
                {
                    string config = Encoding.ASCII.GetString(Convert.FromBase64String(File.ReadAllText("config.ini")));
                    foreach (var item in config.Split(';'))
                    {
                        var separateditem = item.Split('=');
                        switch (separateditem[0])
                        {
                            case "InjectionDelay": InjectionDelay = int.Parse(separateditem[1]); break;
                            case "InjectionMethod": InjectionMethod = separateditem[1]; break;
                            case "Process": Process = separateditem[1]; break;
                            case "AsyncInjection": AsyncInjection = bool.Parse(separateditem[1]); break;
                            case "SecureMode": SecureMode = bool.Parse(separateditem[1]); break;
                            case "DLLList": DLLPathes = new List<string>(separateditem[1].Split(',')); break;
                        }
                    }
                } catch
                {
                    File.Delete("config.ini");
                }
            }
        }
    }
}
