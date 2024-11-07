
///<see cref="https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/program-structure/top-level-statements"/>

#region 注意:在WPF或者Winform中使用顶级语句
//--------------------------------------------------------------------------------------------
//如果要在WPF或者Winform中使用顶级语句
//可以使用如下方法实现STAThreadAttribute效果
//System.Threading.Thread.CurrentThread.SetApartmentState(System.Threading.ApartmentState.Unknown);
//System.Threading.Thread.CurrentThread.SetApartmentState(System.Threading.ApartmentState.STA);
//--------------------------------------------------------------------------------------------
#endregion

foreach (var item in args)
{
#if  NET35 || NET40
    Console.Out.WriteLine(item);
#else
    await Console.Out.WriteLineAsync(item);
    
#endif
}

return 0;