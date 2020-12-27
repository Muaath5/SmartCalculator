using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SmartCalculator
{
    public static class VariablesManager
    {
        public const string FileName = @"Variables.txt";
        public static readonly char[] Variables = new char[] { 'أ', 'ب', 'ج', 'د' };
        public static readonly char[] EnglishVariables = new char[] { 'A', 'B', 'C', 'D' };

        public static int LinesCount { get { return File.ReadAllLines(FileName).Length; } }

        internal static void AppendVariable(char var, decimal value)
        {
            CheckFile();
            string text = File.ReadAllText(FileName);
            string varLine = var + ":" + value.ToString();
            File.WriteAllText(FileName, text + varLine + Environment.NewLine);
        }

        internal static void DeleteAt(int index)
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

        internal static string[] ReadAllLines()
        {
            CheckFile();
            return File.ReadAllLines(FileName);
        }

        // API
        public static Variable[] ReadVariables()
        {
            CheckFile();

            Variable[] vars = new Variable[4];
            string[] lines = ReadAllLines();

            if (lines.Length != 4)
            {
                Error.ThrowError(ApplicationErrors.ReadingFileError);
                throw new ArgumentOutOfRangeException(nameof(lines), "Variables count must be 4 ONLY!");
            }

            for (int i = 0; i < vars.Length; i++)
            {
                vars[i] = Variable.FromString(lines[i]);
            }

            return vars;
        }

        internal static void Clear()
        {
            CheckFile();
            File.WriteAllText(FileName, "");
        }

        
        // API
        public static int IndexOf(Variable var)
        {
            string[] text = ReadAllLines();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == var.ToString())
                {
                    return i;
                }
            }

            return -1;
        }

        

        // API
        public static void SetValue(Variable var)
        {
            // Read
            CheckFile();
            string[] lines = File.ReadAllLines(FileName);
            List<string> newFile = new List<string>(lines);

            // Replace with new value
            int index = Variables.ToList().IndexOf(var.Name);
            if (index == -1)
            {
                throw new KeyNotFoundException("Can't find character!");
            }

            newFile.RemoveAt(index);
            newFile.Insert(index, var.ToString());

            // Write new data
            File.WriteAllLines(FileName, newFile.ToArray());
        }

        // API
        public static Variable GetVariable(char var)
        {
            CheckFile();
            string[] lines = File.ReadAllLines(FileName);
            List<string> newFile = new List<string>(lines);
            int index = newFile.IndexOf(var.ToString());

            Variable result = Variable.FromString(newFile[index]);
            return result;
        }

        // API
        public static bool Contains(Variable var)
        {
            foreach (string item in ReadAllLines())
            {
                if (item == var.ToString())
                {
                    return true;
                }
            }

            return false;
        }

        internal static bool CheckFile()
        {
            if (File.Exists(FileName))
            {
                return true;
            }
            else
            {
                FileStream fs = File.Create(FileName);
                using StreamWriter writer = new StreamWriter(fs);
                writer.WriteLine("أ:0");
                writer.WriteLine("ب:0");
                writer.WriteLine("ج:0");
                writer.WriteLine("د:0");
                return false;
            }
        }
    }
}
