///<see cref="https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/operators/member-access-operators#range-operator-"/>
namespace PolyfillSample.LangVersion8
{
    internal class IndexRange 
    {
        private string array = "";
        
        public char IndexOf(Index index)
        {
            var result= array[index];
            return result;
        }

        public string RangeOf(Range range)
        {
            string result = array[3..5];
            return result;
        }
    }
}
