namespace PolySharpSample.LangVersion7_1
{

    internal class DefaultIiteral
    {
        public (int, int?, int[], string, object) Foo(out double[] nums, string str)
        {
            nums = [3.5d, default, 500];
            str = default;
            return (default, default, [default, default], default, default);
        }
        public int? AddOrDefault(int? a, int? b)
        {
            return a.HasValue && b.HasValue ? a + b : default;
        }
    }
}
