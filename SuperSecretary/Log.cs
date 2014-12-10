using System;
using System.IO;
using System.Text;

namespace SuperSecretary
{
    public static class Log
    {
        private static StringBuilder sb;

        public static void Write(string value)
        {
            if (sb == null)
            {
                sb = new StringBuilder();
                sb.AppendLine("--------------------------------SuperSecretary--------------------------------");
            }
            sb.AppendLine(String.Format("{0} {1}", DateTime.Now.ToString("hh:mm:ss"), value));
        }

        public static void Save(string path)
        {
            Write("Operation completed.");
            string fileName = String.Format(@"{0}\{1}.txt", path, DateTime.Now.ToString("MM.dd.yyyy-hh.mm.ss"));
            File.WriteAllText(fileName, sb.ToString());
            sb = null;
        }
    }
}
