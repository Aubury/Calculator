namespace Calculator
{
    /// <summary>
    /// Pows double in power
    /// Writed by Nikita Honcharov
    /// </summary>
    class Pow : Operation
    {
        /// <summary>
        /// Pows double 1 in 2
        /// Writed by Nikita Honcharov
        /// </summary>
        /// <param name="a">Value</param>
        /// <param name="b">Power</param>
        /// <returns>Value</returns>
        public override double execute(double a, double b)
        {
            double result = 1;
            if (b < 0)
            {
                for (int i = 0; i < -b; i++)
                {
                    result *= a;
                }
                return 1 / result;
            }
            if (b == 0)
            {
                result = 1;
            }
            else
            {
                for (int i = 0; i < b; i++)
                {
                    result *= a;
                }
            }
            return result;
        }
    }
}
