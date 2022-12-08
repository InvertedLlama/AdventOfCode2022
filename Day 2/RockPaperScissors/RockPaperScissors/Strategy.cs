using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Strategy
    {
        public static List<(char, char)> ChooseReponses(List<(char, char)> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                var roundInput = input[i];
                roundInput.Item2 = ChooseReponse(input[i].Item1, input[i].Item2);
                input[i] = roundInput;
            }
            return input;
        }

        public static char ChooseReponse(char theirChoice, char myChoice)
        {
            switch (myChoice)
            {
                case 'X':
                    return GetLoseResponse(theirChoice);
                case 'Y':
                    return GetDrawResponse(theirChoice);
                case 'Z':
                    return GetWinResponse(theirChoice);
            }

            throw new ArgumentOutOfRangeException();
        }

        public static char GetWinResponse(char theirChoice)
        {
            switch (theirChoice)
            {
                case 'A':
                    return 'Y';
                case 'B':
                    return 'Z';
                case 'C':
                    return 'X';
            }

            throw new ArgumentOutOfRangeException();
        }

        public static char GetDrawResponse(char theirChoice)
        {
            switch (theirChoice)
            {
                case 'A':
                    return 'X';
                case 'B':
                    return 'Y';
                case 'C':
                    return 'Z';
            }

            throw new ArgumentOutOfRangeException();
        }

        public static char GetLoseResponse(char theirChoice)
        {
            switch (theirChoice)
            {
                case 'A':
                    return 'Z';
                case 'B':
                    return 'X';
                case 'C':
                    return 'Y';
            }

            throw new ArgumentOutOfRangeException();
        }
    }
}
