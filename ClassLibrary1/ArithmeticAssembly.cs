using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
