namespace Core.UseCases
{
    public abstract class UseCaseResponseMessage
    {
        public bool Success { get; }
        public string Message { get; }
        public IEnumerable<string> Errors {  get; protected set; }

        protected UseCaseResponseMessage(bool success = false, string message = "")
        {
            Errors = Array.Empty<string>();
            Success = success;
            Message = message;
        }
    }
}
