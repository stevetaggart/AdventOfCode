using System;

namespace AdventOfCode.Solutions.Year2021
{

    class Day01 : ASolution
    {
        readonly string[] measurements;

        public Day01() : base(01, 2021, "")
        {
            measurements = Input.SplitByNewline();
        }

        protected override string SolvePartOne()
        {
            var increaseCount = 0;
            var lastMeasurement = -1;
            foreach (var measurement in measurements)
            {
                var currentMeasurement = Convert.ToInt16(measurement);
                if (lastMeasurement == -1)
                {
                    Console.WriteLine($"First measurement is: {currentMeasurement}");
                }
                else if (currentMeasurement > lastMeasurement)
                {
                    increaseCount++;
                }
                lastMeasurement = currentMeasurement;
            }
            return increaseCount.ToString();
        }

        protected override string SolvePartTwo()
        {
            var increaseCount = 0;
            var lastSum = -1;
            for (var i=0;i < measurements.Length - 2;i++)
            {
                var currentSum = Convert.ToInt16(measurements[i]) + Convert.ToInt16(measurements[i + 1]) + Convert.ToInt16(measurements[i + 2]);
                if (lastSum == -1)
                {
                    Console.WriteLine($"First sum is: {currentSum}");
                }
                else if (currentSum > lastSum)
                {
                    increaseCount++;
                }
                lastSum = currentSum;
            }
            return increaseCount.ToString();
        }
    }
}
