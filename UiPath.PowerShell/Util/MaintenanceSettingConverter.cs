using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UiPath.PowerShell.Util
{
    /// <summary>
    /// Converts maintenance logs into a dynamic objects
    /// </summary>
    public static class MaintenanceSettingConverter
    {
        private static dynamic resultTyped = new
        {
            State = "",
            MaintenanceLogs = new[] { new { State = "", TimeStamp = new Nullable<DateTime>(DateTime.Now) } },
            JobsStopped = 0,
            JobsKilled = 0,
            SchedulesFired = 0,
            SystemSchedulesFired = 0
        };

        public static dynamic ToMaintenanceSetting(this string input)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeAnonymousType(input, resultTyped);
        }
    }
}
