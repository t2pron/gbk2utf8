using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gbk2utf8
{
    public partial class Form1 : Form
    {
        string mSrcPath;
        string mDesPath;
        public Form1()
        {
            InitializeComponent();
            mSrcPath = "";
            mDesPath = "";
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            mSrcPath = tbSourceFolderPath.Text;
            mDesPath = tbTargetFolderPath.Text;
            if (mSrcPath == "" || mDesPath == "")
            {
                MessageBox.Show("请选择文件夹！");
                return;
            }
            if (!mSrcPath.EndsWith("\\"))
            {
                mSrcPath += "\\";
            }
            if (!mDesPath.EndsWith("\\"))
            {
                mDesPath += "\\";
            }

            //执行转换代码
            Thread thread = new Thread(converTo);
            thread.Start();
        }

        private void converTo()
        { 
            //获取路径中的文件、文件夹进行转换
            if (!Directory.Exists(mSrcPath))
            {
                this.Invoke(new Action(() =>
                {
                    invokeMethod("原文件夹不存在！");
                }));

                return;
            }
            
            gbk2utfFolder(mSrcPath, mDesPath);
            this.Invoke(new Action(() =>
            {
                invokeMethod("转换完成");
            }));
                 
        }

        private void gbk2utfFolder(string src, string des) 
        {
            //获取文件夹中所有的文件 
            DirectoryInfo srcFolder = new DirectoryInfo(src);
            FileInfo[] files = srcFolder.GetFiles();   

            //转换
            foreach (FileInfo item in files)
            {
                string fileDes = des + item.Name;
                gbk2utf8file(item.FullName, fileDes);
            }

            DirectoryInfo[] dirs = srcFolder.GetDirectories();
            foreach (DirectoryInfo item in dirs)
            {
                string folderdes = des + item.Name + "//";
                if (!Directory.Exists(folderdes))
                {
                    Directory.CreateDirectory(folderdes);
                }
                gbk2utfFolder(item.FullName, folderdes);
            }
        }

        private void gbk2utf8file(string src, string des)
        {
            //var buffer = File.ReadAllBytes(src);
            string strGbk = File.ReadAllText(src, Encoding.Default);
            byte[] buffer = Encoding.GetEncoding("GBK").GetBytes(strGbk);
            byte[] buffer2 = Encoding.Convert(Encoding.Default, Encoding.UTF8, buffer);
            //buffer = Encoding.Convert(Encoding.GetEncoding("GBK"), Encoding.UTF8, buffer);
            //if (!File.Exists(des))
            //{
            //    File.Create(des, );
            //}
            //File.WriteAllText(des, utf);
            File.WriteAllBytes(des, buffer2);
        }

        private void btnSelectSourceFolder_Click_1(object sender, EventArgs e)
        {
             if (DialogResult.OK == folderBrowserDialog.ShowDialog())
            {
                tbSourceFolderPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnSelectTargetFolder_Click_1(object sender, EventArgs e)
        {
            if (DialogResult.OK == folderBrowserDialog.ShowDialog())
            {
                tbTargetFolderPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void invokeMethod(string message)
        {
            MessageBox.Show(message);
        } 
    }
}
