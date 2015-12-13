using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBook.Business
{
    public class LogBook
    {
        public LogBook()
        {
            logs = new List<Log>();
        } 

        public string Title;
        public string Creator;
        public List<Log> logs;
            
    }
}
