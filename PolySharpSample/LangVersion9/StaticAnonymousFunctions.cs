using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolySharpSample.LangVersion9
{
    internal class StaticAnonymousFunctions
    {

        public static void Foo()
        {
            Action action1 = static () => { };
            Func<string, int, string> func1 = static (str, index) => str[..index];
            AppDomain.CurrentDomain.UnhandledException += static (_, e) => Console.WriteLine(e.ExceptionObject);

        }

    }
}
