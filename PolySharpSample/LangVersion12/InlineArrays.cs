///<see cref="https://learn.microsoft.com/zh-cn/dotnet/csharp/whats-new/csharp-12#inline-arrays"/>
namespace PolyfillSample.LangVersion12
{

    //目前好像不支持以Polyfill的方式开放给低版本目标
#if NET8_0_OR_GREATER
    [System.Runtime.CompilerServices.InlineArray(10)]
    public struct Array10
    {
        private int _item0;
    }
    class Array10Test
    {
        static void Foo()
        {
            Array10 array = new Array10();
            for (int i = 0; i < 10; i++)
            {
                array[i] = i * i;
            }
        }
    }
#endif
}
