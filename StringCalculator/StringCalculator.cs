namespace CodingKata
{
    public class StringCalculator
    {
        public int Add(string numberString)
        {
            if (isStringEmpty(numberString))
                return 0;

            if (numberString.Contains(",")) {
                string[] tokens = numberString.Split(new char[] {','});
                return int.Parse(tokens[0]) + int.Parse(tokens[1]);
            }

            return int.Parse(numberString);
        }

        public bool isStringEmpty(string input) => input.Length == 0;
    }
}
