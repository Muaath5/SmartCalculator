using System;
using System.Collections.Generic;
using System.IO;

namespace SmartCalculator
{
    public static class MemoryManager
    {
        public const string FileName = Constants.MemoryFileName;

        public static int Count { get { return File.ReadAllLines(FileName).Length; } }

        public static void AppendLine(string line)
        {
            CheckFile();
            string text = File.ReadAllText(FileName);
            File.WriteAllText(FileName, text + line + Environment.NewLine);
        }

        public static void WriteLines(string[] lines)
        {
            CheckFile();
            File.WriteAllText(FileName, lines.AsLines());
        }

        public static void DeleteAt(int index)
        {
            if (File.Exists(FileName))
            {
                string[] lines = File.ReadAllLines(FileName);
                List<string> newFile = new List<string>(lines);
                newFile.RemoveAt(index);
            }
            else
            {
                File.Create(FileName);
            }
        }

        public static string[] ReadAllLines()
        {
            CheckFile();
            return File.ReadAllLines(FileName);
        }

        public static void Clear()
        {
            CheckFile();
            File.WriteAllText(FileName, "");
        }

        public static bool Contains(string line)
        {
            foreach (string item in ReadAllLines())
            {
                if (item == line)
                {
                    return true;
                }
            }

            return false;
        }

        public static int IndexOf(string line)
        {
            string[] text = ReadAllLines();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == line)
                {
                    return i;
                }
            }

            return -1;
        }

        public static void EditAt(int index, string newEx)
        {
            CheckFile();
            string[] lines = File.ReadAllLines(FileName);
            lines.SetValue(newEx, index);
            File.WriteAllLines(FileName, lines);
        }

        internal static bool CheckFile()
        {
            if (File.Exists(FileName))
            {
                return true;
            }
            else
            {
                File.Create(FileName);
                return false;
            }
        }
    }
}
