using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkypeStatus
{
    public partial class Common
    {
        public static Time time = new Time();
        private static DateTime limit;

        public static DateTime Limit
        {
            get
            {
                if (limit == DateTime.MinValue)
                    limit = new DateTime(1753, 1, 1, 1, 0, 0);

                return limit;
            }
            set
            {
                limit = value;
            }
        }

        public static bool CheckTimeEquiv(Time timeToCheck, DateTime dateTimeToCheck)
        {
            bool result = false;

            if (timeToCheck.hours == dateTimeToCheck.Hour &&
                timeToCheck.minutes == dateTimeToCheck.Minute &&
                timeToCheck.seconds == dateTimeToCheck.Second)
                result = true;

            return result;
        }

        public class Time
        {
            public int hours = 0;
            public int minutes = 0;
            public int seconds = 0;
        }
    }
}
