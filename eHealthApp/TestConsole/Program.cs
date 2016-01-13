using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCareModel.ControlHandler;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insertion of alarm attendant via controller");
            Console.ReadLine();
            ExtendedControl.createAlarmAttendance("cacat", "shortie");
            Console.ReadLine();

        }
    }
}
