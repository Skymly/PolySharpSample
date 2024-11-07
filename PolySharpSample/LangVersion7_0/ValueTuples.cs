///<see cref="https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/builtin-types/value-tuples"/>
namespace PolyfillSample.LangVersion7_0
{
    internal class ValueTuples
    {
        public readonly (double, int) item = (4.5, 3);
        public (string Name, int Age) Person { get; } = ("AAA", 18);
    }
}
