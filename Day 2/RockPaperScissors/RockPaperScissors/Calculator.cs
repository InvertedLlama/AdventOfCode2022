namespace RockPaperScissors
{
    public class Calculator
    {
        public static int CalculateScore(List<(char, char)> input)
        {
            var total = 0;
            foreach(var roundInput in input)
            {
                total += CalculateScore(roundInput);
            }
            return total;
        }

        public static int CalculateScore((char, char) roundInput)
        {
            return ScoreChoice(roundInput.Item2) + ScoreWin(roundInput.Item1, roundInput.Item2);
        }

        public static int ScoreChoice(char myChoice)
        {
            switch (myChoice)
            {
                case 'X':
                    return 1;
                case 'Y':
                    return 2;
                case 'Z':
                    return 3;
            }

            throw new ArgumentOutOfRangeException();
        }

        public static int ScoreWin(char theirChoice, char myChoice)
        {
            var myChoiceValue = (int)myChoice - 23 - 65;
            var theirChoiceValue = (int)theirChoice - 65;

            if (theirChoiceValue == myChoiceValue)
                return 3;

            switch (theirChoice, myChoice)
            {
                case ('A', 'Y'):
                case ('B', 'Z'):
                case ('C', 'X'):
                    return 6;
                default:
                    return 0;
            }
        }
    }
}