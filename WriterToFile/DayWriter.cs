using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriterToFile
{
   public class DayWriter : BaseWriter
    {
        public string CurrentDay { get; set; }

        public DayWriter() 
        {
            CurrentDay = DateTime.Now.DayOfWeek.ToString();
                
        }

        public override string ToString()
        {
            return CurrentDay;
        }
    }
}
