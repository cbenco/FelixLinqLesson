namespace FelixLinqLesson
{
    public class ErrorReport
    {
        public string Id { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public int? ExternalProviderId { get; set; }
    }
}