using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angelwings.Supplemental
{
    public static class Dice
    {
        private static readonly Random _rng = new();

        public static int RollD20() => _rng.Next(1, 21); // Returns a random number between 1 and 20 inclusive
        public static int RollD12() => _rng.Next(1, 13); // Returns a random number between 1 and 12 inclusive
        public static int RollD10() => _rng.Next(1, 11); // Returns a random number between 1 and 10 inclusive
        public static int RollD8() => _rng.Next(1, 9); // Returns a random number between 1 and 8 inclusive
        public static int RollD6() => _rng.Next(1, 7); // Returns a random number between 1 and 6 inclusive
        public static int RollD4() => _rng.Next(1, 5); // Returns a random number between 1 and 4 inclusive

        public record HopeFearResult (int Hope, int Fear, int Total, string Outcome);

        public static HopeFearResult RollHopeAndFear()
        {
            var message = string.Empty;
            // Get hope die and roll it
            var hope = RollD12();
            // Get fear die and roll it
            var fear = RollD12();
            /// Logic:
            /// Compare the two rolls and add them together.
            /// - If hope was bigger, add "with hope" to the result.
            /// - If fear was bigger, add "with fear" to the result.
            /// - If they are equal, add "CRITICAL SUCCESS" to the result.
           
            int total = hope + fear;
            string outcome = hope > fear ? "with hope"
                : fear > hope ? "with fear"
                : "CRITICAL SUCCESS";

            return new HopeFearResult(hope, fear, total, outcome);
        }

    }
}
