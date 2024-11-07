///<see cref="https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/statements/iteration-statements#await-foreach"/>
namespace PolySharpSample.LangVersion8
{
    internal class AsyncEnumerableAwaitForeach
    {
#if NETSTANDARD2_1 || NETCOREAPP3_1_OR_GREATER
        static async IAsyncEnumerable<long> GetData()
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(100);
                yield return DateTime.Now.Ticks;
            }
        }
#endif
    }
}
