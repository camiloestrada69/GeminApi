namespace GeminApi.Domain.Helpers
{
    public class DataDuplicatedException: Exception
    {
        public DataDuplicatedException(string message) : base(message)
        { }
    }
}
