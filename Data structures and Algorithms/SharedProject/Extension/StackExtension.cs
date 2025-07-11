namespace SharedProject.Extension
{
    public static class StackExtension
    {
        public static bool IsEmpty<T>(this Stack<T> stack)
        {
            return stack.Count == 0;
        }  
    }
}
