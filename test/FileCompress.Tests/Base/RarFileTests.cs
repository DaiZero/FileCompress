using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace FileCompress.Tests.Base
{
    [TestClass()]
    public class RarFileTests
    {
        [TestMethod()]
        public void DeCompressTest()
        {
            var rarfilecp = new RarFile();
            var rarpath = @"F:\Test\压缩文件\测试.rar";
            var topath = @"F:\Test\解压文件";
            var actval = rarfilecp.DeCompress(rarpath, topath);
            actval.Should().BeTrue();
        }

        [TestInitialize()]
        public void ClearUnFile()
        {
            var topath = @"F:\Test\解压文件";
            ClearFolder(topath);
        }

        private void ClearFolder(string dir)
        {
            foreach (string d in Directory.GetFileSystemEntries(dir))
            {
                if (File.Exists(d))
                {
                    try
                    {
                        FileInfo fi = new FileInfo(d);
                        if (fi.Attributes.ToString().IndexOf("ReadOnly") != -1)
                            fi.Attributes = FileAttributes.Normal;
                        File.Delete(d);//直接删除其中的文件 
                    }
                    catch
                    {

                    }
                }
                else
                {
                    try
                    {
                        DirectoryInfo d1 = new DirectoryInfo(d);
                        if (d1.GetFiles().Length != 0)
                        {
                            ClearFolder(d1.FullName);////递归删除子文件夹
                        }
                        Directory.Delete(d);
                    }
                    catch
                    {

                    }
                }
            }
        }
    }
}
