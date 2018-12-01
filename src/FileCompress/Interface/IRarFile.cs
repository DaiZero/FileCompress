using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCompress
{
  public  interface IRarFile: IFileBase
    {
        ///// <summary>
        ///// 解压rar文件
        ///// </summary>
        ///// <param name="rarFilePath">要解压的rar文件路径</param>
        ///// <param name="destDirPath">解压后保存到的目录</param>
        ///// <param name="password">文件密码</param>
        ///// <returns>是否解压成功</returns>
        //bool DeCompress(string rarFilePath, string destDirPath, string password=null);

        ///// <summary>
        ///// 压缩文件
        ///// </summary>
        ///// <param name="fileOrDirPath">要压缩的文件或文件夹路径</param>
        ///// <param name="rarFilePath">压缩后的rar保存路径</param>
        ///// <returns>是否压缩压成功</returns>
        //bool Compress(string fileOrDirPath, string rarFilePath);
    }
}
