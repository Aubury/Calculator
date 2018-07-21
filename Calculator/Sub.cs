namespace Calculator
{
    /// <summary>
    /// Deducts 2 doubles
    /// Writed by Vladislav Sich
    /// </summary>
    class Sub : Operation
    {
        /// <summary>
        /// Deducts 2 doubles
        /// </summary>
        /// <param name="a">First double</param>
        /// <param name="b">Second double</param>
        /// <returns>Result</returns>
        public override double execute(double a, double b)
        {
            return a - b;
        }
    }
}
