namespace GeminApi.Domain.Helpers
{
    public class IllegalArgumentException: Exception
    {
        public IllegalArgumentException(string message) : base(message)
        { }
    }
}
