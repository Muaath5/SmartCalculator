using System.Text;

namespace SmartCalculator
{
    interface IFileManager : ISearchable<string>
    {
        string FilePath { get; }
        string[] Lines { get; set; }
        string Text { get; set; }
        Encoding Encoding { get; set; }
        void Delete();
        bool Exists();
        void Replace(string text, string newText);
        void RemoveLine(int index);
        void ReplaceLine(int index, string newText);
        void InsertLine(int index, string line);
    }

    public interface ISearchable<T>
    {
        int IndexOf(T t);
        int LastIndexOf(T t);
    }
}
