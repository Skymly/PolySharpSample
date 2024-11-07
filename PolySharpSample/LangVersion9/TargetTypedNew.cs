using System.Threading;
///<see cref="https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/proposals/csharp-9.0/target-typed-new"/>
namespace PolySharpSample.LangVersion9
{
    internal class TargetTypedNew
    {
        public static void Foo()
        {
            Func<DateTime> now = new(() => DateTime.Now);
            object obj = new();
            List<int> arr = new();
            (int a, bool b) = (3, true); 
            Thread.CurrentThread.CurrentUICulture = new("en-US");
        }


    }
}
