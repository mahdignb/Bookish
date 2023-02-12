namespace Bookish
{
    public class Helper
    {
        public static string LoadToken()
        {
            if (File.Exists("token.txt"))
            {
                return File.ReadAllText("token.txt");
            }
            else
            {
                return string.Empty;
            }
        }

    }
}
