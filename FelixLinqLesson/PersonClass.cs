namespace FelixLinqLesson
{
    public class PersonClass
    {
        public string PersonId { get; set; }
        public Class Class { get; set; }
    }

    public enum Class
    {
        Lower,
        Middle,
        Upper
    }
}