using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCompress.SharpZipLib
{
    public class ZipFile : IZipFile
    {
        public bool Compress(string fileOrDirPath, string cpFilePath)
        {
            throw new NotImplementedException();
        }

        public bool DeCompress(string cpFilePath, string destDirPath, string password = null)
        {
            throw new NotImplementedException();
        }
    }
}
