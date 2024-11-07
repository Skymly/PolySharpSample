///<see cref="https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/operators/patterns#relational-patterns"/>
///<see cref="https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/operators/patterns#logical-patterns"/>
namespace PolySharpSample.LangVersion9
{
    internal class Patterns
    {

        //< <= > >= 
        static string RelationalPatterns(int score) => score switch
        {
            < 60 => "D",
            < 80 => "C",
            < 90 => "B",
            _ => "A",
        };

        // not and or
        static void LogicalPatterns(int num)
        {
            bool good = num is (not (0 or 50 or -50)) and < 100 and > -100;
        }
    }
}
