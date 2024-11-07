///<see cref="https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/keywords/init"/>
namespace PolySharpSample.LangVersion9
{
    internal class Init
    {
        protected Init(string name,string description)
        {
            Name = name;
            Description = description;
        }
        public string Name { get; private init; }
        public string Description { get; protected init; }

        private int age;
        public int Age
        {
            get => age;
            init => age = 0;
        }
    }
}
