using System;

namespace PolyfillSample.LangVersion11
{

    internal class RawStringIiterals
    {
        public static readonly string Str = $""""
            原始字符串字面量是字符串字面量的一种新格式。
            原始字符串字面量可以包含任意文本，包括空格、新行、嵌入引号和其他特殊字符，无需转义序列。 
            原始字符串字面量以至少三个双引号 (""") 字符开头。 它以相同数量的双引号字符结尾。 
            通常，原始字符串字面量在单个行上使用三个双引号来开始字符串，在另一行上用三个双引号来结束字符串。 
            左引号之后、右引号之前的换行符不包括在最终内容中
            {Environment.NewLine}{Environment.NewLine}{DateTime.Now:G}
            """";
        public static readonly string Str2 = $$""""
            注意 $ 数量不同带来的变化
            {{Environment.NewLine}}{{Environment.NewLine}}{{DateTime.Now:G}}
            """";

        public static readonly string Str3 = $""""""
            注意开头结尾的引号数量带来的变化
            可以包含的连续双引号数量不能超过两端的的双引号数
            "
            ""
            """
            """"
            """""
            {Environment.NewLine}{Environment.NewLine}{DateTime.Now:G}
            """""";


    }
}
