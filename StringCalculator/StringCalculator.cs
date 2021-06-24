namespace CodingKata
{
    public class StringCalculator
    {
        public object Add(string v)
        {
            if (v.Length == 0)
                return 0;

            return int.Parse(v);
        }
    }
}
