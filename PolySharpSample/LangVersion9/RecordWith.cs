///<see cref="https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/builtin-types/record"/>
namespace PolySharpSample.LangVersion9
{
#if !NET35
 class RecordTest
    {
        public static void Foo()
        {
            RecordStruct3 item1 = new("aaa", 15);

            var item2 = item1 with { Age = 5 };

            var item3 = item1 with { Age = 5, Name = "ddd" };

            var item4 = item1 with { };

            var item5 = item1 with { Age = 5 } with { Name = "fff" };

            item1.Deconstruct(out var name, out var age);
        }

    }
    public record Record1();
    public record Record2(string Name);
    public record Record3(string Name, int Age = 15);
    public record Record4(string Name, int Age) : Record2(Name);
    public record Record5(string Name) : Record2(Name)
    {
        public required int Age { get; init; }
        protected override bool PrintMembers(StringBuilder stringBuilder)
        {
            if (base.PrintMembers(stringBuilder) && stringBuilder.Length != 0)
            {
                stringBuilder.Append(", ");
            };
            stringBuilder.Append($"Age = {Age}");
            return true;
        }
    };


    public record struct RecordStruct1;
    public record struct RecordStruct2(string Name);
    public record struct RecordStruct3(string Name, int Age = 15);
    public readonly record struct RecordStruct4(string Name, int Age = 15);
    public record struct RecordStruct5
    {
        public required string Name { get; init; }
        public required int Age { get; init; }
    };
#endif



}
