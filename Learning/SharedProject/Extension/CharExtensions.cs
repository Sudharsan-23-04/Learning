namespace SharedProject.Extension
{
    public static class CharExtensions
    {
        public static int ToInt(this char c)
        {
            _ = int.TryParse(c.ToString(), out int res);
            return res;
        }
    }
}
