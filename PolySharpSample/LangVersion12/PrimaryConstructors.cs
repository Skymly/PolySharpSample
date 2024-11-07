///<see cref="https://learn.microsoft.com/zh-cn/dotnet/csharp/whats-new/csharp-12#primary-constructors"/>
namespace PolyfillSample.LangVersion12
{
    internal class Person(string name, int age)
    {
        public string Name { get; } = name;
        public int Age { get; private set; } = age;
    }

    internal class PersonInfo(string name, int age, string info) : Person(name, age)
    {
        public string Info { get; } = info;
    }

}
