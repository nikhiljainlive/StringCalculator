namespace CodingKata
{
    public class StringCalculator
    {
        private static string DELIMITER_COMMA = ",";
        private static string DELIMITER_NEW_LINE = "\n";

        public int Add(string numberString)
        {
            if (IsStringEmpty(numberString))
                return 0;

            if (numberString.StartsWith("//"))
            {
                string delimiter = numberString.Substring(2, 1);
                string tokensString = numberString.Split('\n')[1];
                string[] numbers = tokensString.Split(new string[] { delimiter },
                    System.StringSplitOptions.None);

                int sum = 0;
                foreach (string token in numbers)
                {
                    sum += StringToInt(token);
                }

                return sum;
            }

            string[] tokens = ConvertToTokens(numberString);
            int result = 0;

            foreach (string token in tokens)
            {
                result += StringToInt(token);
            }

            return result;
        }

        private bool IsStringEmpty(string input) => input.Length == 0;

        private int StringToInt(string input) => int.Parse(input);

        private string[] ConvertToTokens(string input) => input.Split(new string[]
        { DELIMITER_COMMA, DELIMITER_NEW_LINE }, System.StringSplitOptions.None);
    }
}
