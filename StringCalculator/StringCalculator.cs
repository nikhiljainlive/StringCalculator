namespace CodingKata
{
    public class StringCalculator
    {
        public int Add(string numberString)
        {
            if (isStringEmpty(numberString))
                return 0;

            return int.Parse(numberString);
        }

        public bool isStringEmpty(string input) => input.Length == 0;
    }
}
