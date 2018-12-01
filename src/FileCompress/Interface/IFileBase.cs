using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCompress
{
    public interface IFileBase
    {

        /// <summary>
        /// 解压文件
        /// </summary>
        /// <param name="cpFilePath">压缩文件路径</param>
        /// <param name="destDirPath">解压后保存到的目录</param>
        /// <param name="password">文件密码</param>
        /// <returns>是否解压成功</returns>
        bool DeCompress(string cpFilePath, string destDirPath, string password = null);

        /// <summary>
        /// 压缩文件
        /// </summary>
        /// <param name="fileOrDirPath">要压缩的文件或文件夹路径</param>
        /// <param name="cpFilePath">压缩后保存路径</param>
        /// <returns>是否压缩压成功</returns>
        bool Compress(string fileOrDirPath, string cpFilePath);
    }
}
