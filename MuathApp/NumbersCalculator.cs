using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SmartCalculator
{
    public static class NumbersCalculator
    {
        public readonly static char[] OperationOrder = new char[6]
        { '√', '^', '/', '*', '-', '+' };

        public const char Minus = '-';

        public static decimal CalculateString(string Formula)
        {
            try
            {
                string[] arr = Formula.Split("/+-*()".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                while (Formula.LastIndexOf("(") > -1)
                {
                    // Bracket indecies
                    int lastOpenBracketIndex = Formula.LastIndexOf("(");
                    int lastCloseBracketIndex = Formula.IndexOf(")", lastOpenBracketIndex);


                    decimal result = ProcessOperation(Formula.Substring(lastOpenBracketIndex + 1, lastCloseBracketIndex - lastOpenBracketIndex - 1));

                    // If Add asterix will be added.
                    //EX: 5(300)
                    bool AppendAsterix = false;

                    // If bracket wasn't at first
                    if (lastOpenBracketIndex > 0)
                    {
                        int beforeIndex = lastOpenBracketIndex - 1;
                        int afterIndex = lastCloseBracketIndex - 1;

                        if (Formula[beforeIndex] != '(' && !OperationOrder.Contains(Formula[afterIndex]))
                        {
                            AppendAsterix = true;
                        }
                    }

                    Formula = Formula.Substring(0, lastOpenBracketIndex) + (AppendAsterix ? "*" : "") + result.ToString() + Formula.Substring(lastCloseBracketIndex + 1);

                }
                return ProcessOperation(Formula);
            }
            catch
            {
                throw;
            }
        }

        private static decimal ProcessOperation(string operation)
        {
            ArrayList seperatedValues = new ArrayList();
            string lastPart = "";

            char currentCharacter;

            // Loop
            for (int i = 0; i < operation.Length; i++)
            {
                currentCharacter = operation[i];
                if (OperationOrder.Contains(currentCharacter))
                {
                    if (currentCharacter == '-' && i == 0)
                    {
                        lastPart += Minus;
                        continue;
                    }
                    if (lastPart != "")
                    {
                        seperatedValues.Add(lastPart);
                    }

                    seperatedValues.Add(currentCharacter);
                    lastPart = "";
                }
                else
                {
                    lastPart += currentCharacter;
                }
            }
            seperatedValues.Add(lastPart);

            foreach (char op in OperationOrder)
            {
                while (seperatedValues.Contains(op)) // If success
                {
                    // Indecies
                    int operatorIndex = seperatedValues.IndexOf(op);
                    int beforeIndex = operatorIndex - 1;
                    int afterIndex = operatorIndex + 1;

                    decimal mathExBeforeOperator = Convert.ToDecimal(seperatedValues[beforeIndex]);
                    decimal mathExAfterOperator;

                    if (seperatedValues[afterIndex].ToString().ToCharArray()[0] == Minus) // If current operation and next operation are '-'
                    {
                        seperatedValues.RemoveAt(afterIndex); // Remove minus operator from values
                        mathExAfterOperator = Convert.ToDecimal(seperatedValues[afterIndex]) * -1; // Convert current number to minus
                    }
                    else
                        mathExAfterOperator = Convert.ToDecimal(seperatedValues[afterIndex]);

                    // Calculate in current index
                    seperatedValues[operatorIndex] = CalculateByOperator(mathExBeforeOperator, mathExAfterOperator, op);

                    // Remove Math Exeprissions after and before; because it was calculated
                    seperatedValues.RemoveAt(afterIndex);
                    seperatedValues.RemoveAt(beforeIndex);
                }
            }
            return Convert.ToDecimal(seperatedValues[0]);
        }

        public static bool IsOperator(string str)
        {
            return OperationOrder.Contains(str.ToCharArray()[0]);
        }

        private static decimal CalculateByOperator(decimal number1, decimal number2, char op)
        {
            switch (op)
            {
                case '√':
                    return (decimal)Math.Pow((double)number1, 1 / (double)number2);
                case '^':
                    return (decimal)Math.Pow((double)number1, (double)number2);
                case '/':
                case '÷':
                    return number1 / number2;
                case '*':
                case '×':
                    return number1 * number2;
                case '-':
                    return number1 - number2;
                case '+':
                    return number1 + number2;
                default:
                    return 0;
            }
        }

        public static string GetNaitveMathExeprission(this string value)
        {
            return value.Replace('×', '*').Replace('÷', '/').Minmize();
        }

        public static decimal Calculate(this string value)
        {
            return CalculateString(value);
        }

        public static string ReplaceVariables(this string value, Variable[] vars)
        {
            string newText = value;
            foreach (Variable var in vars)
            {
                newText = newText.Replace(var.Name.ToString(), $"({var.Value})");
            }
            return newText;
        }

        public static string RemoveSpaces(this string value)
        {
            return value.Replace(" ", "");
        }

        public static string Minmize(this string value)
        {
            string result = value.Replace("\n", "");
            result = result.Replace("\r", "");
            result = result.Replace("\t", "");
            return result.RemoveSpaces();
        }
    }
}
