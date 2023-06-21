namespace GeminApi.Domain.Helpers
{
    public class DataNotFoundException: Exception
    {
        public DataNotFoundException(string message) : base(message)
        { }
    }
}
