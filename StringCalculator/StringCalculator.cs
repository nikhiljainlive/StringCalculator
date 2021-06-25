namespace CodingKata
{
    public class StringCalculator
    {
        public static char DELIMITER_COMMA = ',';

        public int Add(string numberString)
        {
            if (IsStringEmpty(numberString))
                return 0;

            if (numberString.Contains(DELIMITER_COMMA.ToString())) {
                string[] tokens = ConvertToTokens(numberString);
                int result = 0;

                foreach (string token in tokens) {
                    result += StringToInt(token);
                }

                return result;
            }

            return StringToInt(numberString);
        }

        private bool IsStringEmpty(string input) => input.Length == 0;

        private int StringToInt(string input) => int.Parse(input);

        private string[] ConvertToTokens(string input) => input.Split(new char[] { DELIMITER_COMMA });
    }
}
