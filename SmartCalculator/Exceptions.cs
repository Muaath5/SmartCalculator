using System;
using System.Windows.Forms;

namespace SmartCalculator
{

    [Serializable]
    public class SmartCalculatorException : Exception
    {
        public IWin32Window Window { get; set; }

        public SmartCalculatorException() : base() { }
        public SmartCalculatorException(IWin32Window window) { Window = window; }
        public SmartCalculatorException(IWin32Window window, string message) : base(message)
        {
            Window = window;
        }
        public SmartCalculatorException(string message) : base(message) { }
        public SmartCalculatorException(string message, Exception inner) : base(message, inner) { }


        protected SmartCalculatorException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }


    [Serializable]
    public class CalculatingException : SmartCalculatorException
    {
        public string MathExeprission { get; }

        public decimal Result { get; }

        public CalculatingException() : base(Texts.GetString("CalculatingError")) { }
        public CalculatingException(string mathEx, decimal result) : base(Application.OpenForms["MainForm"])
        {
            
            MathExeprission = mathEx;
            Result = result;
        }
        public CalculatingException(string message) : base(message) { }
        public CalculatingException(string message, Exception inner) : base(message, inner) { }

        protected CalculatingException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }


    [Serializable]
    public class ConversionException : SmartCalculatorException
    {
        public string From { get; }
        public string To { get; }
        public string ConversionType { get; set; }
        public ConversionException() { }
        public ConversionException(string message, string conversionType, string to, string from) : base(message)
        {
            ConversionType = conversionType;
            From = from;
            To = to;
        }
        public ConversionException(string message, string conversionType) : base(message)
        {
            ConversionType = conversionType;
        }
        public ConversionException(string message) : base(message) { }
        public ConversionException(string message, Exception inner) : base(message, inner) { }
        protected ConversionException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    [Serializable]
    public class ReadingFileException : SmartCalculatorException
    {
        public string FileName { get; }
        public ReadingFileException() { }
        public ReadingFileException(string message, string fileName) : base(message)
        {
            FileName = fileName;
        }
        public ReadingFileException(string message) : base(message) { }
        public ReadingFileException(string message, Exception inner) : base(message, inner) { }
        protected ReadingFileException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
