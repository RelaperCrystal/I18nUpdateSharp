using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static TranslateA.Manager;
using System.IO;

namespace TranslateA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MCFolderC() == true)
            {
                if (Directory.Exists(@"cache") == false)
                {
                    Directory.CreateDirectory(@"cache");
                }
                File.Delete(@"cache/Mod-Language-Package.zip");
                kakeCache("cache/Mod-Language-Package.zip");
                string md51 = GetMD5HashFromFile("cache/Mod-Language-Package.zip");
                string md52 = GetMD5HashFromFile(".minecraft/resourcepacks/Mod-Language-Package.zip");
                if(md51 == md52)
                {
                    MessageBox.Show("您安装的汉化资源包为最新版本！已缓存最新版本");
                }
                else
                {
                    File.Delete(@".minecraft/resourcepacks/Mod-Language-Package.zip");
                    File.Copy(@"cache/Mod-Language-Package.zip", @".minecraft/resourcepacks/Mod-Language-Package.zip",true);
                }
            }
            else
            {
                MessageBox.Show("未找到.minecraft!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MCFolderC() == true)
            {
                if (Directory.Exists(@"cache") == false)
                {
                    Directory.CreateDirectory(@"cache");
                }
                File.Delete(@"cache/Lang-Updator.jar");
                kakeCacheMod("cache/Lang-Updator.jar");
                string md51 = GetMD5HashFromFile("cache/Lang-Updator.jar");
                string md52 = GetMD5HashFromFile(".minecraft/mods/Lang-Updator.jar");
                if (md51 == md52)
                {
                    MessageBox.Show("您安装的汉化更新模组为最新版本！已缓存最新版本");
                }
                else
                {
                    File.Delete(@".minecraft/mods/Lang-Updator.jar");
                    File.Copy(@"cache/Lang-Updator.jar", @".minecraft/mods/Lang-Updator.jar", true);
                }
            }
            else
            {
                MessageBox.Show("未找到.minecraft!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
