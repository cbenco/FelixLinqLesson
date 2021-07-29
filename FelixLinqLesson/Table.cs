using System.Collections.Generic;

namespace FelixLinqLesson
{
    public class Table
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Field> Fields { get; set; }
    }
}