using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogBookConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            LogBook frontDeskLog = new LogBook();
            frontDeskLog.Name = "Front Desk Log";
            frontDeskLog.AddTaskItem("Copies", "Check In Log Copies Needed", "We are running low on check in log sheets. Please help make more copies! Thank you.");
            frontDeskLog.AddTaskItem("Paper", "Paper is running low", "Please refill the printer paper. Make sure the front desk, hallway, and office printers have enough paper. Thanks!");
            User user = new User();
        }
    }
}
