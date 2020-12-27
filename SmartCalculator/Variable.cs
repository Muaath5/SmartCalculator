using System;
using System.Collections.Generic;
using System.Globalization;

namespace SmartCalculator
{
    public struct Variable : IEquatable<Variable>, IEquatable<string>
    {
        public char Name;
        public decimal Value;
        

        public Variable(char name)
        {
            this.Name = name;
            this.Value = 0;
        }

        public Variable(char name, decimal value)
        {
            this.Name = name;
            this.Value = value;
        }


        public static Variable FromString(string data)
        {
            return new Variable(data[0], decimal.Parse(data.Split(":".ToCharArray())[1]));
        }

        public bool Equals(string other)
        {
            return other == this.ToString();
        }

        public bool Equals(Variable other)
        {
            return other.ToString() == this.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is Variable otherVar)
            {
                return Equals(otherVar);
            }

            if (obj is string otherStr)
            {
                return Equals(otherStr);
            }

            return false;
        }

        public bool Equals(IList<IDictionary<char, decimal>> other)
        {
            throw new NotImplementedException();
        }



        public override int GetHashCode()
        {
            string hash = Name.GetHashCode().ToString();
            hash += Value.GetHashCode();
            return int.Parse(hash);
        }

        public override string ToString()
        {
            return Name + ":" + Value.ToString();
        }

        // Operators
        public static bool operator ==(Variable a, Variable b)
        {
            return a.Equals(b);
        }
        public static bool operator !=(Variable a, Variable b)
        {
            return a.Equals(b);
        }

        public static implicit operator string(Variable var)
        {
            return var.ToString();
        }
        public static implicit operator Variable(string var)
        {
            return Variable.FromString(var);
        }
    }
}
