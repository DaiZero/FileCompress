using System;
using System.IO;
using SharpCompress.Archives;
using SharpCompress.Archives.Rar;
using SharpCompress.Common;
using SharpCompress.Readers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCompress.SharpCompress
{
    public class RarFile : IRarFile
    {
        /// <summary>
        /// 压缩文件
        /// </summary>
        /// <param name="fileOrDirPath">要压缩的文件或文件夹路径</param>
        /// <param name="rarFilePath">压缩后的rar保存路径</param>
        /// <returns>是否压缩压成功</returns>
        public bool Compress(string fileOrDirPath, string rarFilePath)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 解压rar文件
        /// </summary>
        /// <param name="rarFilePath">要解压的rar文件路径</param>
        /// <param name="destDirPath">解压后保存到的目录</param>
        /// <param name="password">文件密码</param>
        /// <returns>是否解压成功</returns>
        public bool DeCompress(string rarFilePath, string destDirPath, string password = null)
        {
            var complete = false;
            using (Stream stream = File.OpenRead(rarFilePath))
            {
                using (var rar = RarArchive.Open(stream, new ReaderOptions() { Password = password }))
                {
                    rar.WriteToDirectory(destDirPath, new ExtractionOptions() { ExtractFullPath = true, Overwrite = true });
                    complete = true;
                }
            }
            return complete;
        }
    }
}
