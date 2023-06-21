namespace GeminApi.Domain.Helpers
{
    public class GeneralRunTimeException: Exception
    {
        public GeneralRunTimeException(string message) : base(message)
        { }
    }
}
