using System;

namespace SmartCalculator
{
    /// <summary>
    /// Probably be used soon
    /// </summary>
    public struct MemoryMember : IEquatable<MemoryMember>, IEquatable<string>
    {
        public string MathExeprission;
        public decimal Result;
        public CalculatorMode Mode;

        public MemoryMember(CalculatorMode mode, string mathExeprission)
        {
            Mode = mode;
            MathExeprission = mathExeprission;
            Result = MathExeprission.GetNaitveMathExeprission().Calculate();
        }

        public MemoryMember(CalculatorMode mode, string mathExeprission, decimal result)
        {
            Mode = mode;
            MathExeprission = mathExeprission;
            Result = result;
        }

        public override bool Equals(object obj)
        {
            if (obj is MemoryMember member)
            {
                return Equals(member);
            }

            if (obj is string value)
            {
                return Equals(value);
            }

            return false;
        }

        public override string ToString()
        {
            //eg. : " 123 × 456 - 789  =         "
            return $"{MathExeprission} = {Result}";
        }

        public bool Equals(MemoryMember other)
        {
            return (other.MathExeprission == MathExeprission) &&
                (other.Mode == Mode) &&
                (other.Result == Result);
        }

        public bool Equals(string other)
        {
            if (other == MathExeprission)
            {
                if (other.GetNaitveMathExeprission().Calculate() == Result)
                {
                    return true;
                }
                if (other.ToFahrenheit() == Result || other.ToCelisius() == Result)
                {
                    return true;
                }
            }

            return false;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public static bool operator ==(MemoryMember a, MemoryMember b) 
        {
            return a.Equals(b);
        }
        public static bool operator !=(MemoryMember a, MemoryMember b)
        {
            return !a.Equals(b);
        }
    }
}
