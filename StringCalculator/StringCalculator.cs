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
                string[] tokens = numberString.Split(new char[] {DELIMITER_COMMA});
                int result = 0;

                foreach (string token in tokens) {
                    result += StringToInt(token);
                }

                return result;
            }

            return StringToInt(numberString);
        }

        public bool IsStringEmpty(string input) => input.Length == 0;

        public int StringToInt(string input) => int.Parse(input);
    }
}
