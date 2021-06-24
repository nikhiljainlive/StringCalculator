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
                return StringToInt(tokens[0]) + StringToInt(tokens[1]);
            }

            return StringToInt(numberString);
        }

        public bool IsStringEmpty(string input) => input.Length == 0;

        public int StringToInt(string input) => int.Parse(input);
    }
}
