using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriterToFile
{
    public abstract class BaseWriter : IWriteableToFile
    {
        public void WriteToFile(string fileName)
        {
            File.WriteAllText(fileName, ToString());
        }
    }
}
