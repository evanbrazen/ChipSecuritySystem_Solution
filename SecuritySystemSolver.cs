using System.Collections.Generic;
using System.Linq;

namespace ChipSecuritySystem
{
    public class SecuritySystemSolver
    {
        private const Color StartColor = Color.Blue;
        private const Color EndColor = Color.Green;

        public static List<ColorChip> FindLongestSolution(List<ColorChip> chips)
        {
            List<ColorChip> longestSolution = new List<ColorChip>();

            // Start the recursive search with the initial color Blue and an empty current solution
            FindLongestSolutionRecursive(StartColor, chips, new List<ColorChip>(), longestSolution);

            return longestSolution;
        }

        private static void FindLongestSolutionRecursive(
            Color currentColor,
            List<ColorChip> unusedChips,
            List<ColorChip> currentSolution,
            List<ColorChip> longestSolution)
        {
            // Check if the solution ends with Green
            if (currentColor == EndColor)
            {
                // Check if the current solution is longer than the longest solution found so far
                if (currentSolution.Count > longestSolution.Count)
                {
                    longestSolution.Clear();
                    longestSolution.AddRange(currentSolution);
                }
            }

            // Iterate through the unused chips and try to add them to the current solution
            // Create a copy of the unusedChips list to avoid modifying it while iterating
            foreach (var chip in unusedChips.ToList())
            {
                // Can match to either side of chip
                bool matchesStartColor = chip.StartColor == currentColor || chip.EndColor == currentColor;

                // If the chip does not match the current color, skip it
                if (!matchesStartColor)
                {
                    continue;
                }

                // Create a copy of the unusedChips list to avoid modifying it while iterating
                // Add the chip to the current solution and remove it from the unused chips
                unusedChips.Remove(chip);
                currentSolution.Add(chip);

                // Determine the next color to match based on the current chip
                Color nextColor = chip.StartColor == currentColor ? chip.EndColor : chip.StartColor;

                // Recursively call the function with the new state
                FindLongestSolutionRecursive(nextColor, unusedChips, currentSolution, longestSolution);

                // remove the chip from the current solution and add back to the unused chips for the next iteration
                currentSolution.RemoveAt(currentSolution.Count - 1);
                unusedChips.Add(chip);
            }

        }
    }
}
