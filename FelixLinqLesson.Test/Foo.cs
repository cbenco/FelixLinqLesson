namespace FelixLinqLesson.Test
{
    internal class Foo
    {
        private string _v;

        public Foo(string v)
        {
            _v = v;
        }

        public override string ToString()
        {
            return $"Foo {_v}";
        }
    }
}