namespace Calculator
{
    /// <summary>
    /// Multiplicate 2 doubles
    /// Writed by Denis Zubairov
    /// </summary>
    class Mult : Operation
    {
        /// <summary>
        /// Multiplicate 2 doubles
        /// Writed by Denis Zubairov
        /// </summary>
        /// <param name="one">First double</param>
        /// <param name="two">Second double</param>
        /// <returns>Result</returns>
        public override double execute(double one, double two)
        {
            return one * two;
        }

    }
}
