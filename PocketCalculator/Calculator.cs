using System;

namespace PocketCalculator
{
    public class Calculator
    {
        public double Value { get; private set; }
        public double MemoryValue { get; private set; }

        public Calculator()
        {
            this.Value = 0;
            this.MemoryValue = 0;
        }

        /// <summary>This method changes calculator's value based on passed math operations</summary>
        /// <param name="operation">Operation - adding, subtracting, multiplying and dividing</param>
        /// <param name="value">Value</param
        public void Calculate(string operation, double value)
        {
            switch (operation)
            {
                case "+":
                    Add(value);
                    break;
                case "−":
                    Subtract(value);
                    break;
                case "X":
                    Multiply(value);
                    break;
                case "÷":
                    Divide(value);
                    break;
            }
        }

        /// <summary>This method changes calculator's value to the given value</summary>
        /// <param name="value">the new value</param>
        public void SetValue(double value)
        {
            this.Value = value;
        }

        /// <summary>This method clears calculator's value</summary>
        public void Clear()
        {
            this.Value = 0;
        }

        /// <summary>This method adds a given number to the value </summary>
        /// <param name="value">Value</param
        private void Add(double value)
        {
            this.Value += value;
        }

        /// <summary>This method substracts a given number to the value </summary>
        /// <param name="value">Value</param
        private void Subtract(double value)
        {
            this.Value -= value;
        }

        /// <summary>This method mutiplies a given number to the value </summary>
        /// <param name="value">Value</param
        private void Multiply(double value)
        {
            this.Value *= value;
        }

        /// <summary>This method divides a given number to the value </summary>
        /// <param name="value">Value</param
        /// <returns> An exception if the passed value is zero </returns>
        private void Divide(double value)
        {
            if (value == 0)
            {
                throw new ArgumentException("Division by zero is undefined");
            }

            this.Value /= value;
        }

        /// <summary>This method sets the memory value to zero</summary>
        public void MemoryClear()
        {
            this.MemoryValue = 0;
        }


        /// <summary>This method takes a given number and puts the result into memory</summary>
        /// <param name="value">Value</param
        public void MemoryStore(double value)
        {
            this.MemoryValue = value;
        }

        /// <summary>This method takes a given number, adds it to the memory, and puts the result into memory value</summary>
        /// <param name="value">Value</param
        public void MemoryAddition(double value)
        {
            this.MemoryValue += value;
        }

        /// <summary>This method takes a given number, subtracts it to the memory, and puts the result into memory value</summary>
        /// <param name="value">Value</param
        public void MemorySubtraction(double value)
        {
            this.MemoryValue -= value;
        }

        /// <summary>This method calculates the multiplicative inverse of a passed value </summary>
        /// <param name="value">Value</param
        /// <returns> Result of the operation </returns>
        public static double OneDivideBy(double value)
        {
            if (value == 0)
            {
                throw new ArgumentException("Division by zero is undefined");
            }
            else
            {
                return 1 / value;
            }
        }

        /// <summary>This method returns the square root of a specified number. </summary>
        /// <param name="value">Value</param
        /// <returns> Result of the operation </returns>
        public static double SquareRoot(double value)
        {
            return Math.Sqrt(value);
        }

        /// <summary>This method calculates power of 2 of a value </summary>
        /// <param name="value">Value</param
        /// <returns> Result of the operation </returns>
        public static double PowerOfTwo(double value)
        {
            return Math.Pow(value, 2);
        }

        /// <summary>This method calculates the percentage a passed value </summary>
        /// <param name="value">Value</param
        /// <returns> Result of the operation </returns>
        public static double Percentage(double value)
        {
            return value == 0 ? 0 : (value / 100);
        }
    }
}
