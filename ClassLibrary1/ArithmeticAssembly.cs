using System;
using System.Diagnostics;
using System.Reflection;

namespace ClassLibrary1
{
    public class ArithmeticAssembly
    {
        /// <summary>
        /// 取得組建
        /// </summary>
        public static class GetArithmeticAssemblyVersion
        {
           private static Assembly ArithmeticAssembly = Assembly.GetExecutingAssembly();
           private static FileVersionInfo ArithmeticFileVersionInfo = FileVersionInfo.GetVersionInfo(ArithmeticAssembly.Location);

           public static String version
           {
                get
                {
                    return ArithmeticFileVersionInfo.ProductVersion;
                }
           }
        }
    }
}
