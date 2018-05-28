using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Security.Cryptography;

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
            if (Directory.Exists(@".minecraft") == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool kakeCache(string target)
        {
            WebClient wc = new WebClient();
            try
            {
                wc.DownloadFile("http://p985car2i.bkt.clouddn.com/Minecraft-Mod-Language-Modpack.zip", target);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("下载失败! 原因: " + ex.Message + Environment.NewLine + "(其实就是个" + ex.ToString() + "啦)");
                return false;
            }
        }
        public static string GetMD5HashFromFile(string filePath)

        {

            try

            {

                FileStream file = new FileStream(filePath, FileMode.Open);

                System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();

                byte[] retVal = md5.ComputeHash(file);

                file.Close();

                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < retVal.Length; i++)

                {

                    sb.Append(retVal[i].ToString("x2"));

                }

                return sb.ToString().ToUpper();

            }

            catch (Exception ex)

            {

                throw new Exception("GetMD5HashFromFile() fail,error:" + ex.Message);

            }

        }
        public static void kakeCacheMod(string target)
        {
            WebClient wc = new WebClient();
            try
            {
                wc.DownloadFile("https://github.com/CFPAOrg/I18nUpdateMod/releases/download/1.0.0/i18nupdatemod-1.12.2-1.0.0.jar", target);
            }
            catch (Exception ex)
            {
                MessageBox.Show("下载失败! 原因: " + ex.Message + Environment.NewLine + "(其实就是个" + ex.ToString() + "啦)");
            }
        }
    }
}
