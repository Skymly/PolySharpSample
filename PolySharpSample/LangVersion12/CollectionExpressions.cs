///<see cref="https://learn.microsoft.com/zh-cn/dotnet/csharp/whats-new/csharp-12#collection-expressions"/>
namespace PolyfillSample.LangVersion12
{
    public class CollectionExpressions
    {
        public static void Foo()
        {
            int[] num1 = [1, 2];
            List<int> nums2 = [3, 4, 5];
            ICollection<int> nums3 = [];
            IList<int> nums = [.. num1, .. nums2, .. nums3, 6, 7];
        }

    }
}
