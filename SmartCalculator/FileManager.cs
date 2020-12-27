using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCalculator
{
    public class FileManager : IFileManager
    {
        private string path;
        public FileManager(string filePath)
        {
            path = filePath;
        }

        public string FilePath { get { return path; } }

        public string[] Lines { get => File.ReadAllLines(FilePath, Encoding); set => File.WriteAllLines(FilePath, value, Encoding); }

        public string Text { get => File.ReadAllText(FilePath, Encoding); set => File.WriteAllText(FilePath, value, Encoding); }

        public Encoding Encoding { get; set; }

        public void Delete()
        {
            File.Delete(FilePath);
        }

        public bool Exists()
        {
            return File.Exists(FilePath);
        }

        public int IndexOf(string t)
        {
            return Text.IndexOf(t);
        }

        public void InsertLine(int index, string line)
        {
            List<string> lines = new List<string>(Lines);
            lines.Insert(index, line);
            Lines = lines.ToArray();
        }

        public int LastIndexOf(string t)
        {
            return Text.LastIndexOf(t);
        }

        public void RemoveLine(int index)
        {
            List<string> lines = new List<string>(Lines);
            lines.RemoveAt(index);
            Lines = lines.ToArray();
        }

        public void Replace(string text, string newText)
        {
            throw new NotImplementedException();
        }

        public void ReplaceLine(int index, string newText)
        {
            throw new NotImplementedException();
        }
    }
}
