using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriterToFile
{
    public class TimeWriter : BaseWriter
    {
        public TimeOnly CurrentTime { get; init; }

        public TimeWriter() 
        {
            var now = DateTime.Now;
            CurrentTime = new TimeOnly(now.Hour, now.Minute, now.Second);
        }
        public override string ToString()
        {
            return CurrentTime.ToString();
        }
    }
}
