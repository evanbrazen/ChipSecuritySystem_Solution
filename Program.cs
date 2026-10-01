using System;
using System.Collections.Generic;

namespace ChipSecuritySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of ColorChips for testing
            // The chips are defined with their start and end colors
            // The longest solution should be 13 chips
            var chips = new List<ColorChip>
            {
                new ColorChip(Color.Yellow, Color.Blue),
                new ColorChip(Color.Red, Color.Yellow),
                new ColorChip(Color.Orange, Color.Red),
                new ColorChip(Color.Purple, Color.Orange),
                new ColorChip(Color.Yellow, Color.Purple),
                new ColorChip(Color.Red, Color.Yellow),
                new ColorChip(Color.Orange, Color.Red),
                new ColorChip(Color.Purple, Color.Orange),
                new ColorChip(Color.Yellow, Color.Purple),
                new ColorChip(Color.Red, Color.Yellow),
                new ColorChip(Color.Orange, Color.Red),
                new ColorChip(Color.Green, Color.Orange),
                new ColorChip(Color.Blue, Color.Red),
                new ColorChip(Color.Purple, Color.Red),
                new ColorChip(Color.Yellow, Color.Orange)
            };

            //var chips = new List<ColorChip>
            //{
            //    new ColorChip(Color.Blue, Color.Yellow),
            //    new ColorChip(Color.Yellow, Color.Red),
            //    new ColorChip(Color.Red, Color.Orange),
            //    new ColorChip(Color.Orange, Color.Purple),
            //    new ColorChip(Color.Purple, Color.Yellow),
            //    new ColorChip(Color.Red, Color.Purple),
            //    new ColorChip(Color.Orange, Color.Red),
            //    new ColorChip(Color.Purple, Color.Orange),
            //    new ColorChip(Color.Purple, Color.Yellow),
            //    new ColorChip(Color.Yellow, Color.Orange)
            //};

            var result = SecuritySystemSolver.FindLongestSolution(chips);

            if (result.Count > 0)
            {
                Console.WriteLine("Longest Solution: {0} Chips", result.Count);
                foreach (var chip in result)
                {
                    Console.WriteLine("[{0}]", chip);
                }
            }

            else
            {
                Console.WriteLine(Constants.ErrorMessage);
            }
        }
    }
}
