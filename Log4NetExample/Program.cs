using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Log4NetExample
{
    class Program
    {
        private static readonly ILog Logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            Logger.InfoFormat($"Running as {WindowsIdentity.GetCurrent().Name}");
            for (int i = 0; i < 100; i++)
                Logger.Info($"Writing log number {i + 1}");
        }
    }
}
