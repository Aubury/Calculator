namespace Calculator
{
    /// <summary>
    /// Abstrct class of operation.
    /// Writed by Olga Kulina
    /// </summary>
    public abstract class Operation
    {
        /// <summary>
        /// Abstract method of exute between 2 doubles
        /// Writed by Olga Kulina
        /// </summary>
        /// <param name="a">First double</param>
        /// <param name="b">Second double</param>
        /// <returns>Result</returns>
        public abstract double execute(double a, double b);
    }
}
