namespace AnaliseFinanceira
{
    public static class StringsExtensions
    {
        public static string DefaultIfNull(this string str, string valorDefault)
        {
            if (str is null)
            {
                return valorDefault;
            }
            return str;
        }
    }
}
