using System;

namespace AdventOfCode.Solutions.Year2021
{

    class Day02 : ASolution
    {
        readonly string[] instructions;

        public Day02() : base(02, 2021, "")
        {
             instructions = Input.SplitByNewline();
        }

        protected override string SolvePartOne()
        {
            var horizontalPosition = 0;
            var depth = 0;
            foreach (var instruction in instructions)
            {
                var split = instruction.Split();
                var direction = split[0];
                var amount = Convert.ToInt32(split[1]);
                _ = direction switch
                {
                    "forward" => horizontalPosition += amount,
                    "down" => depth += amount,
                    "up" => depth -= amount,
                    _ => throw new Exception("Invalid instruction"),
                };
                Console.WriteLine($"Direction: {direction} Amount: {amount}");
            }
            return $"{horizontalPosition * depth}";
        }

        protected override string SolvePartTwo()
        {
            var horizontalPosition = 0;
            var depth = 0;
            var aim = 0;
            foreach (var instruction in instructions)
            {
                var split = instruction.Split();
                var direction = split[0];
                var amount = Convert.ToInt32(split[1]);
                if (direction == "forward")
                {
                    horizontalPosition += amount;
                    depth += aim * amount;
                }
                if (direction == "down")
                    aim += amount;
                if (direction == "up")
                    aim -= amount;
                Console.WriteLine($"Direction: {direction} Amount: {amount} Aim: {aim}");
            }
            return $"{horizontalPosition * depth}";
        }
    }
}
