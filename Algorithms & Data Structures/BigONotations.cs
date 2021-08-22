using System.Collections.Generic;

namespace AlgorithmsAndDataStructures
{
    public class BigONotations
    {
        // O(1) -- Constants
        private void Function1(List<string> data)
        {
            var str = data[0];
        }

        // O(n) -- linear
        private void Function2(List<string> data)
        {
            foreach (var str in data)
                if (str == "shiv")
                    return;
        }

        // O(2n) or O(n^2) -- Quadratic
        private void Function3(List<string> data)
        {
            foreach (var str in data)
            foreach (var str1 in data)
            {
            }
        }
    }
}