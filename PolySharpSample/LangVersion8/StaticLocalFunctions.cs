///<see cref="https://learn.microsoft.com/zh-cn/dotnet/csharp/programming-guide/classes-and-structs/local-functions"/>
namespace PolyfillSample.LangVersion8
{
    internal class StaticLocalFunctions
    {
        public int Add(int a, int b)
        {
            return MyAdd(a, b);
            static int MyAdd(int n1, int n2) => n1 + n2;
        }
    }
}
