namespace FelixLinqLesson
{
    public class ProblemDetails
    {
        public string ErrorTraceId { get; set; }
        public int ErrorCode { get; set; }
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
        public int ExternalProviderId { get; set; }
    }
}