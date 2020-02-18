using System;

namespace RandomDouble
{
    /// <summary>
    /// Generates a random Double.
    /// </summary>
    public class RandomDouble
    {
        /// <summary>
        /// Returns a random double between max and min.
        /// </summary>
        /// <param name="min">The minimum value</param>
        /// <param name="max">The maximum value</param>
        /// <returns>Returns a random double between max and min</returns>
        public double Next(double min, double max)
        {
            Random rand = new Random();
            double Value;
            Value = min + (rand.NextDouble() * (max - min)); // NextDouble gives random number between 0.0 and 1.0, range is created by multiplying with max - min, then added to the min to create the true range.
            return Value;
        }
    }
}
