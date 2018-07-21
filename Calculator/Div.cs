using System;

namespace Calculator
{
    /// <summary>
    /// Divide between 2 numbers
    /// Writed by Denis Zubairov
    /// </summary>
    class Div : Operation
    {
        /// <summary>
        /// Divide between 2 numbers
        /// Writed by Denis Zubairov
        /// </summary>
        /// <param name="one">First double</param>
        /// <param name="two">Not null second double</param>
        /// <returns>Result</returns>
        public override double execute(double one, double two)
        {

            if (two == 0)
            {
                throw new DivideByZeroException();
            }
            else
                return one / two;

        }
    }
}
