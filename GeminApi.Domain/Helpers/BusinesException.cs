namespace GeminApi.Domain.Helpers
{
    public class BusinesException: Exception
    {
        public BusinesException(string message) : base(message)
        { }
    }
}
