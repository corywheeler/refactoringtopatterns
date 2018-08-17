namespace MoveEmbellishmentToDecorator.MyWork
{
    public class Translate
    {
        public static string decode(string result)
        {
            return System.Net.WebUtility.HtmlDecode(result);
        }
    }
}