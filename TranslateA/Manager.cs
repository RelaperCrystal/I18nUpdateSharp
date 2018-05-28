using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace TranslateA
{
    /// <summary>
    /// 管理器类。
    /// </summary>
    public class Manager
    {
        // 有没有人能告诉我是不是可以直接返回Directory.Exists
        public static bool MCFolderC()
        {
            if(Directory.Exists(@".minecraft") == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
