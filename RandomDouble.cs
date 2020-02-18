using System;

namespace RandomDouble
{
    /// <summary>
    /// Generates a random Double.
    /// </summary>
    public class RandomDouble
    {
        private readonly Random random;

        /// <summary>
        /// initiates RandomDouble with a time-dependant seed value.
        /// </summary>
        public RandomDouble()
        {
            random = new Random();
        }
        /// <summary>
        /// inititates RandomDouble with a seed value.
        /// </summary>
        public RandomDouble(int seed)
        {
            random = new Random(seed);
        }

        /// <summary>
        /// Returns a random double between 0 and max.
        /// </summary>
        /// <param name="max">The maximum value</param>
        /// <returns>Returns a random double between max and min</returns>
        public double Next(double max)
        {
            // NextDouble gives random number between 0.0 and 1.0.
            // Range is created by multiplying with max - min, 
            // then added to the min to create the true range.
            return random.NextDouble() * max;
        }
        /// <summary>
        /// Returns a random double between max and min.
        /// </summary>
        /// <param name="min">The minimum value</param>
        /// <param name="max">The maximum value</param>
        /// <returns>Returns a random double between max and min</returns>
        public double Next(double min, double max)
        {
            // NextDouble gives random number between 0.0 and 1.0.
            // Range is created by multiplying with max - min, 
            // then added to the min to create the true range.
            return min + (random.NextDouble() * (max - min));
        }
    }
}
